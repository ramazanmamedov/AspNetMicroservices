using Identity.Common;

namespace OnlineShop.Services.Identity;

public interface IAuthorizeApi
{
    Task Login(LoginParameters loginParameters);
    Task Register(RegisterParameters registerParameters);
    Task Logout();
    Task<UserInfo> GetUserInfo();
}