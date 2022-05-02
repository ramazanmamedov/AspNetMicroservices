using System.Collections.Generic;
using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> products)
        {
            bool existProduct = products.Find(p => true).Any();
            if (!existProduct)
            {
                products.InsertManyAsync(GetPreconfiguredList());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredList()
        {
            return new List<Product>()
            {
                new()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone X",
                    Summary = "Apple iPhone X 64GB (серый космос)",
                    Description = "Дисплей выполнен с применением матрицы типа Amoled. Диагональ дисплея составляет 5,8 дюйма, разрешение — 2436×1125 пикселей, плотность изображения — 458 точек на дюйм. Используются технологии Dolby Vision, HDR 10 и ранее опробованная на iPad Pro система оптимизации цвета True Tone.",
                    ImageFile = "https://photographylife.com/wp-content/uploads/2019/08/iPhone-X-1536x1152.jpg",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Samsung 10",
                    Summary = "Упаковка достаточно надежная и отлично сохраняет всю комплектацию во время транспортировки.",
                    Description = "Cтильный стеклянный смартфон. Всю лицевую поверхность смартфона занимает яркий 6,1 дюймовый Dynamic AMOLED экран с изогнутыми краями и тонкой алюминиевой рамкой. Для любителей тонких рамок данное устройство точно придется по вкусу. В верхнем правом углу имеется круглое отверстие фронтальной камеры.",
                    ImageFile = "https://cdn.dxomark.com/wp-content/uploads/medias/post-28424/SamsungGalaxyS105G-rear-1024x768.jpg",
                    Price = 840.00M,
                    Category = "Smart Phone"
                },
                new()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Huawei Plus",
                    Summary = "P10 Plus (VKY-L29)(DGA03K)",
                    Description = "Самообучающийся и сверхбыстрый процессор Kirin 960 обеспечивает высочайшую производительность смартфона Huawei P10 Plus в моменты наибольшей нагрузки во время игр. В сочетании с технологией Huawei Ultra Memory с функцией экономного использования памяти любимые приложения будут загружаться быстрее, чем когда-либо.",
                    ImageFile = "https://phonesdata.com/files/models/Huawei--Enjoy-10-Plus-459.jpg",
                    Price = 650.00M,
                    Category = "Smart Phone"
                },
                new()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "Xiaomi Mi 9",
                    Summary = "Xiaomi Mi 9 32GB (Purpure)",
                    Description = "Качественный OLED-экран с небольшим отверстием сверху Интегрированный в экран датчик отпечатков работает идеально Более дешевый, чем большинство конкурентов Оптимизированная операционная система Очень быстрый процессор Отличная автономность",
                    ImageFile = "https://avatars.mds.yandex.net/get-mpic/5296089/img_id7462600326231848749.png/orig",
                    Price = 470.00M,
                    Category = "Smart Phone"
                },
                new()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "HTC U11+ Plus",
                    Summary = "Android 8.0 с HTC Sense",
                    Description = "Смартфон оснащен 6-дюймовым LCD дисплеем с разрешением 2880×1440 пикселей и поддержкой HDR10. В качестве процессора установлен Snapdragon 835. В зависимости от страны доступно две модификации — с 4 ГБ оперативной и 64 ГБ встроенной памяти или с 6 и 128 ГБ",
                    ImageFile = "https://phonesdata.com/files/models/HTC-U11+-730.jpg",
                    Price = 380.00M,
                    Category = "Smart Phone"
                },
                new()
                {
                    Id = "602d2149e773f2a3990b47fa",
                    Name = "LG G7 ThinQ",
                    Summary = "SoC Qualcomm Snapdragon 845, 8 ядер",
                    Description = "Одна из немногих моделей корейского бренда, которая использует IPS-экран. Так или иначе, это очень качественная матрица с предельной яркостью 1000 нит и плотностью пикселей 563 точки на дюйм. Разрешение 6.1-дюймовой панели составляет 3120 на 1440 пикселей, что даже больше, чем в Galaxy S10",
                    ImageFile = "https://4.img-dpreview.com/files/p/E~TS590x0~articles/1904986381/lgg7.jpeg",
                    Price = 240.00M,
                    Category = "Smart Phone"
                },
                new()
                {
                    Id = "626fa15e4ffc6046de8c9254",
                    Name = "HP Omen 15",
                    Summary = "Ноутбук HP Omen 15-ek1004ur (39V98EA)",
                    Description = "Процессор: AMD Ryzen 5 / Модель процессора: 4500U / Частота процессора, ГГц: 2.3 / Объем оперативной памяти: 8 ГБ / Конфигурация оперативной памяти: 2 х 4 ГБ / Жесткий диск: HDD нет / Твердотельный накопитель: 512 ГБ SSD / Интегрированная в процессор графика: AMD Radeon Graphics / Диагональ экрана, дюйм: 15.6 / Разрешение экрана: 1920 x 1080 Full HD / USB Type-C Power Delivery: Да / Операционная система: Windows 11 Home (x64) / Вес, кг: 1.6",
                    ImageFile = "https://www.omen.com/content/dam/sites/omen/worldwide/laptops/omen-15-laptop/2-0/starmade-15-50-w-numpad-4-zone-oled-shadow-black-nt-h-dcam-non-odd-non-fpr-freedos-core-set-front-right-copy.png",
                    Price = 1000.00M,
                    Category = "Notebook"
                },
                new()
                {
                    Id = "626fa16fd174cc757ac95b3f",
                    Name = "Apple MacBook Air 13",
                    Summary = "Ноутбук Apple MacBook Air 13 MGN63 серый",
                    Description = "Самый тонкий и лёгкий ноутбук Apple полностью преобразился с появлением чипа Apple M1. Центральный процессор теперь работает до 3,5 раза быстрее. Графический — до 5 раз. А благодаря передовой системе Neural Engine от Apple скорость машинного обучения возросла до 9 раз. Новый MacBook Air работает без подзарядки дольше, чем предыдущие модели. И совсем не шумит, потому что у него нет вентилятора. Мощность ещё никогда не была такой компактной.",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/h65/h0f/33125684084766/apple-macbook-air-2020-13-3-mgn63-seryj-100797845-1-Container.jpg",
                    Price = 1230.00M,
                    Category = "Notebook"
                },
                new()
                {
                    Id = "626fa17952a66ca959a10639",
                    Name = "Acer Nitro 5",
                    Summary = "Ноутбук Acer Nitro 5 AN515-55-546H NH.Q7MER.00A черный",
                    Description = "Доминируйте в играх благодаря сочетанию мощного процессора Intel® Core™ i7 12-го поколения1 и графических процессоров NVIDIA® GeForce RTX™ серии 30 (с полной оптимизацией для максимальной модифицированной градиентной проекции). Максимальная скорость и большой объем памяти благодаря двум разъемам M.2 PCIe 4-го поколения и поддержке до 32 ГБ ОЗУ DDR4 3200.",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/h90/hb0/48739795599390/acer-nitro-5-an515-55-546h-nh-q7mer-00a-cernyj-103698221-1.jpg",
                    Price = 830.00M,
                    Category = "Notebook"
                },
                new()
                {
                    Id = "626fa18a0dca67fb83110b43",
                    Name = "Lenovo IdeaPad Gaming 3",
                    Summary = "Ноутбук Lenovo IdeaPad Gaming 3 15IHU6 82K1005ARK черный",
                    Description = "Благодаря мощному процессору Intel® Core™ 11-го поколения и видеокарте NVIDIA® GeForce RTX™ ноутбук IdeaPad Gaming 3i Gen 6 (15) позволит вам раскрыть весь свой игровой потенциал. Играйте на профессиональном уровне благодаря безупречному качеству изображения на дисплее стандарта FHD (1920 x 1080) с матрицей IPS и частотой обновления до 165 Гц, покоряйте гоночный трек благодаря поддержке технологии одновременного нажатия клавиш Full N-Key Rollover, эффективнее остужайте пыл сражений с помощью мощной системы охлаждения и точно определяйте местоположение противников с аудиосистемой Nahimic с эффектом погружения.",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/hb7/h54/47697415864350/lenovo-ideapad-gaming-3-15ihu6-82k1005ark-cernyj-103140545-1.jpg",
                    Price = 720.00M,
                    Category = "Notebook"
                },
                new()
                {
                    Id = "626fa180fd9924605ae5e235",
                    Name = "ASUS TUF Gaming",
                    Summary = "Ноутбук ASUS TUF Gaming FX506LH-HN004 90NR03U2-M00860 черный",
                    Description = "Ноутбуки серии TUF Gaming представляют собой портативные игровые платформы, ориентированные на массового геймера. Они отличаются особой надежностью и современным техническим оснащением, включая дисплеи с высокой частотой обновления и быстрые видеокарты.",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/h2e/h28/33511043498014/asus-tuf-gaming-fx506lh-hn004-90nr03u2-m00860-cernyj-101426399-1-Container.jpg",
                    Price = 680.00M,
                    Category = "Notebook"
                },
                new()
                {
                    Id = "626fa19156c22460b2e034ec",
                    Name = "CYBER MARKET Pro Gaming 15",
                    Summary = "Системный блок CYBER MARKET Pro Gaming 15 черный",
                    Description = @"- процессор: Intel Core i5 10400F
                                    - форм-фактор корпуса: Midi-Tower
                                    - размер оперативной памяти: 16 Гб
                                    - установленная ос: Win 10
                                    - объем ssd: 240 Гб
                                    - видеопроцессор: NVIDIA GeForce GTX 1650
                                    - объем hdd: 1024 Гб",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/h68/h33/47274201612318/cyber-market-pro-gaming-15-102927848-1.jpg",
                    Price = 599.00M,
                    Category = "Computer"
                },
                new()
                {
                    Id = "626fa1997b252fc48403a456",
                    Name = "Apple Mac Mini",
                    Summary = "Неттоп Apple Mac Mini 2020 MGNT3 серебристый",
                    Description = "Чип Apple M1 выводит самый универсальный настольный компьютер Apple на принципиально новый уровень. Мощность процессора выросла до 3 раз. Графика обрабатывается до 6 раз быстрее. А благодаря самой передовой системе Neural Engine от Apple скорость машинного обучения возросла до 15 раз. Mac mini даст вам новые ресурсы для работы, игр и творчества — больше, чем вы могли себе представить.",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/h4c/h5d/34346859790366/apple-mac-mini-mgnt3-serebristyj-101369083-1-Container.jpg",
                    Price = 1100.00M,
                    Category = "Computer"
                },
                new()
                {
                    Id = "626fa19fa9f9670169251d56",
                    Name = "Lenovo IdeaCentre Gaming5",
                    Summary = "Системный блок Lenovo IdeaCentre Gaming5 14IOB6 90RE0054RS черный",
                    Description = @"- процессор: Intel Core i5-11400F
                                    - форм-фактор корпуса: Mini-Tower
                                    - размер оперативной памяти: 16 Гб
                                    - установленная ос: ОС не установлена
                                    - объем ssd: 512 Гб
                                    - видеопроцессор: NVIDIA GeForce GTX 1660 Super",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/h80/hd6/48702659067934/lenovo-ideacentre-gaming5-14iob6-90re0054rs-cernyj-103675041-1.jpg",
                    Price = 930.00M,
                    Category = "Computer"
                },
                new()
                {
                    Id = "626fa1a6ced2520b23f28cf2",
                    Name = "19Volt ProGame 2",
                    Summary = "Системный блок 19Volt ProGame 2 00002SB черный",
                    Description = @"- процессор: Intel Core i7 3770
                                    - форм-фактор корпуса: Midi-Tower
                                    - размер оперативной памяти: 16 Гб
                                    - установленная ос: Win 10
                                    - объем ssd: 120 Гб
                                    - видеопроцессор: NVIDIA GeForce GTX 1060
                                    - объем hdd: 500 Гб",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/hbd/h3b/47009754218526/19volt-progame-2-00002sb-cernyj-102798049-1.jpg",
                    Price = 710.00M,
                    Category = "Computer"
                },
                new()
                {
                    Id = "626fa1ac3612c36655f0cba8",
                    Name = "Delux Avalon School",
                    Summary = "Системный блок Delux Avalon School Core I5-4440 черный",
                    Description = @"- процессор: Intel Core i5-4440
                                    - форм-фактор корпуса: Midi-Tower
                                    - размер оперативной памяти: 8 Гб
                                    - установленная ос: Win 10
                                    - объем ssd: 120 Гб
                                    - объем hdd: 1000 Гб",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/hc7/hac/32643811311646/delux-avalon-school-core-i5-4440-cernyj-100843076-1-Container.jpg",
                    Price = 430.00M,
                    Category = "Computer"
                },
                new()
                {
                    Id = "626fa1b237637e88da9c9391",
                    Name = "Logitech MK235 Wireless Combo ",
                    Summary = "Клавиатура Logitech MK235 Wireless Combo черный",
                    Description = @"- тип: мембранная
                                    - дизайн: классическая
                                    - назначение: для настольного компьютера
                                    - тип подключения: беспроводная",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/h70/hd3/31599087091742/logitech-mk235-wireless-combo-cernyj-9200195-1.jpg",
                    Price = 40.00M,
                    Category = "Other"
                },
                new()
                {
                    Id = "626fa1befaf528f1d710c764",
                    Name = "Keychron K3",
                    Summary = "Клавиатура Keychron K3 HotSwap Gateron Red Switch серый",
                    Description = @"- тип: механическая
                                    - дизайн: классическая
                                    - назначение: для настольного компьютера
                                    - тип подключения: беспроводная
                                    - тип механических клавиш: Gateron Red",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/h22/hfe/46510854373406/keychron-k3-seryj-102561326-1.jpg",
                    Price = 150.00M,
                    Category = "Other"
                },
                new()
                {
                    Id = "626fa1b807ba39f49d92f22e",
                    Name = "Apple Magic Mouse 2",
                    Summary = "Мышь Apple Magic Mouse 2 белый",
                    Description = @"- тип сенсора: оптическая светодиодная
                                    - дизайн: для правой и левой руки
                                    - тип подключения: беспроводная
                                    - интерфейс: Bluetooth",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/h88/hd7/49828687413278/apple-magic-mouse-2-white-9100708-1-Container.jpg",
                    Price = 180.00M,
                    Category = "Other"
                },
                new()
                {
                    Id = "626fa1c412e078eb1d9ee833",
                    Name = "Xiaomi Mi Wireless Mouse 2",
                    Summary = "Мышь Xiaomi Mi Wireless Mouse 2 черный",
                    Description = @"- тип сенсора: оптическая светодиодная
                                    - дизайн: для правой и левой руки
                                    - тип подключения: беспроводная
                                    - интерфейс: USB",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/h79/hd2/32973766098974/xiaomi-mi-wireless-mouse-2-cernyj-100576920-1-Container.jpg",
                    Price = 20.00M,
                    Category = "Other"
                },
                new()
                {
                    Id = "626fa1ca5e89c0de758fa60a",
                    Name = "Samsung Odyssey G3",
                    Summary = "Монитор Samsung Odyssey G3 LF24G33TFWIXCI черный",
                    Description = @"- диагональ: 24 дюйм
                                    - разрешение: 1920x1080
                                    - тип жк-матрицы: TFT *VA
                                    - яркость: 200 кд/м2
                                    - время отклика: 1 мс
                                    - макс. частота обновления кадров: 144 Гц
                                    - входы: HDMI, DisplayPort, VGA (D-Sub)",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/hc1/hc6/33889863893022/samsung-odyssey-g3-lf24g33tfwixci-cernyj-101494481-1-Container.jpg",
                    Price = 300.00M,
                    Category = "Other"
                },
                new()
                {
                    Id = "626fa1d1a5a501b5b5380727",
                    Name = "Apple Display 27",
                    Summary = "Монитор Apple Thunderbolt Display 27 белый",
                    Description = @"- диагональ: 27 дюйм
                                    - разрешение: 2560x1440
                                    - тип жк-матрицы: IPS
                                    - яркость: 375 кд/м2
                                    - время отклика: 12 мс
                                    - входы: Thunderbolt",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/hb5/hbf/31506675662878/apple-thunderbolt-display-27-white-1700265-1.jpg",
                    Price = 3000.00M,
                    Category = "Other"
                },
                new()
                {
                    Id = "626fa1def7374645e42f461f",
                    Name = "Samsung LH49Q",
                    Summary = "Монитор Samsung LH49QBREBGCXCI черный",
                    Description = @"- диагональ: 49 дюйм
                                    - разрешение: 3840x2160
                                    - яркость: 350 кд/м2
                                    - время отклика: 8 мс
                                    - макс. частота обновления кадров: 75 Гц
                                    - входы: DVI, USB, HDMI",
                    ImageFile = "https://resources.cdn-kaspi.kz/shop/medias/sys_master/images/images/h84/h6f/32727450451998/samsung-lh49qbrebgcxci-cernyj-100745979-1.jpg",
                    Price = 3800.00M,
                    Category = "Other"
                }
            };
        }
    }
}