using EFCORE.TRAINING.WITH.AI.EFCORE;
using EFCORE.TRAINING.WITH.AI.EFCORE.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCORE.TRAINING.WITH.AI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Created Context Instance
            eKutuphaneWithAIDbContext context = new();

            //Dummy Data Added
            #region Dummy Data Added

            List<Address> addressList = new()
            {
                new Address()
                {
                    Country ="Türkiye",
                    City = "Tokat",
                    Quarter ="Cedit Mahallesi",
                    Street="Şehit Uzman Samet Pişkin Sokak",
                    BuildingNo ="99/A",
                    ZipCode ="60600"
                },
                new Address()
                {
                    Country ="Türkiye",
                    City = "Kayseri",
                    Quarter ="Melikgazi Mahallesi",
                    Street="Şehit Uzman Pilot Ahmet Yıldırım",
                    BuildingNo ="23/C",
                    ZipCode ="38000"
                },
                new Address()
                {
                    Country ="Türkiye",
                    City = "Çorum",
                    Quarter ="Alaca Mahallesi",
                    Street="İskilipli Atıf Hoca Caddesi",
                    BuildingNo ="54/B",
                    ZipCode ="19000"
                },
            };
            List<User> userList = new()
            {
                new User
                {
                    Name = "Melih",
                    Surname = "Koçak",
                    Mail ="melih3660k@gmail.com",
                    PhoneNumber="5414043661",
                    Gender='E',
                    AddressId =1
                },
                 new User
                {
                    Name = "Göktürk",
                    Surname = "Serttaş",
                    Mail ="gokturk@gmail.com",
                    PhoneNumber="5411111111",
                    Gender='E',
                    AddressId =2
                },
                  new User
                {
                    Name = "Kürşat",
                    Surname = "Ersin",
                    Mail ="kursat@gmail.com",
                    PhoneNumber="5422222222",
                    Gender='E',
                    AddressId =3
                }
            };
            List<Library> libraryList = new()
            {
                new Library
                {
                    Name = "Kayseri Kütüphanesi",
                    AddressId=2
                },
                new Library
                {
                    Name = "Çorum Kütüphanesi",
                    AddressId=3
                },
                new Library
                {
                    Name = "Tokat Kütüphanesi",
                    AddressId=1
                }
            };
            List<Category> categoryList = new()
            {
                new Category
                {
                    Name = "Bilim Kurgu",
                    Description = "Dune ve Yüzüklerin Efendisi Bu kategorinin kralıdır."
                },
                 new Category
                {
                    Name = "Tarih",
                    Description = "Tarihi bilmeyen millet yok olmaya mahkumdur"
                },
                  new Category
                {
                    Name = "Felsefe",
                    Description = "Dipsiz kuyuların bulunduğu alan. Bu alanda hareket edecek kişi ilk önce mantık ilmini tahsil etmelidir."
                },
            };
            List<Author> authorList = new()
            {
                new Author
                {
                    Name = "John Ronald Reuel",
                    Surname ="Tolkien"
                },
                new Author
                {
                    Name = "Frank",
                    Surname ="Herbert"
                },
                new Author
                {
                    Name = "İmam",
                    Surname ="Gazali"
                }
            };
            List<Book> bookList = new()
            {
                new Book
                {
                    Name ="Mekâsidü’l Felâsife",
                    PageCount = 562,
                    PublishedDate = DateOnly.FromDateTime(DateTime.Now.Date.AddDays(-20)),
                   ISBN=Guid.NewGuid()
                },
                 new Book
                {
                    Name ="Dune Çöl Gezegeni",
                    PageCount = 562,
                    PublishedDate = DateOnly.FromDateTime(DateTime.Now.Date.AddDays(-40)),
                   ISBN=Guid.NewGuid()
                },
                  new Book
                {
                    Name ="Sultan II. Abdülhamid Han’la 113 Gün",
                    PageCount = 562,
                    PublishedDate = DateOnly.FromDateTime(DateTime.Now.Date.AddYears(-14)),
                   ISBN=Guid.NewGuid()
                }
            };
            List<Deposit> depositList = new()
            {
                new Deposit
                {
                    UserId = 10,
                    DepositDate = DateOnly.FromDateTime(DateTime.Now),
                    DeliveryDate = DateOnly.FromDateTime(DateTime.Now.AddDays(15)),
                },
                 new Deposit
                {
                    UserId = 11,
                    DepositDate = DateOnly.FromDateTime(DateTime.Now),
                    DeliveryDate = DateOnly.FromDateTime(DateTime.Now.AddDays(15)),
                },
                  new Deposit
                {
                    UserId = 12,
                    DepositDate = DateOnly.FromDateTime(DateTime.Now),
                    DeliveryDate = DateOnly.FromDateTime(DateTime.Now.AddDays(15)),
                }

            };

            context.Addresses.AddRange(addressList);
            context.AddRange(userList);
            context.AddRange(libraryList);
            context.AddRange(categoryList);
            context.AddRange(authorList);
            context.AddRange(bookList);
            context.AddRange(depositList);

            context.SaveChanges();

            #endregion
        }
    }
}

