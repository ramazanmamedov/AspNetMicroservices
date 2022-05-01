using Identity.API.Data;
using Identity.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity.API.Controllers;

[Route("api/v1/[controller]/[action]")]
[ApiController]
public class AuthorizeController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AuthorizeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginParameters parameters)
    {
        var user = await _userManager.FindByNameAsync(parameters.UserName);
        if (user == null) return BadRequest("Пользователя не существует");
        var singInResult = await _signInManager.CheckPasswordSignInAsync(user, parameters.Password, false);
        if (!singInResult.Succeeded) return BadRequest("Неверный пароль");

        await _signInManager.SignInAsync(user, parameters.RememberMe);

        return Ok();
    }


    [HttpPost]
    public async Task<IActionResult> Register(RegisterParameters parameters)
    {
        var user = new ApplicationUser();
        user.UserName = parameters.UserName;
        var result = await _userManager.CreateAsync(user, parameters.Password);
        if (!result.Succeeded) return BadRequest(result.Errors.FirstOrDefault()?.Description);

        return await Login(new LoginParameters
        {
            UserName = parameters.UserName,
            Password = parameters.Password
        });
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return Ok();
    }

    [HttpGet]
    public UserInfo UserInfo()
    {
        return BuildUserInfo();
    }


    private UserInfo BuildUserInfo()
    {
        return new UserInfo
        {
            IsAuthenticated = User.Identity.IsAuthenticated,
            UserName = User.Identity.Name,
            ExposedClaims = User.Claims
                .ToDictionary(c => c.Type, c => c.Value)
        };
    }
}