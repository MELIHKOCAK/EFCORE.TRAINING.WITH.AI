using EFCORE.TRAINING.WITH.AI.EFCORE;
using EFCORE.TRAINING.WITH.AI.EFCORE.Entity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace EFCORE.TRAINING.WITH.AI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Chat's Link On Gemini: https://gemini.google.com/share/a2ce82588876

            //Created Context Instance
            eKutuphaneWithAIDbContext context = new();

            //Dummy Data Added
            #region Dummy Data Added

            //List<Address> addressList = new()
            //{
            //    new Address()
            //    {
            //        Country ="Türkiye",
            //        City = "Tokat",
            //        Quarter ="Cedit Mahallesi",
            //        Street="Şehit Uzman Samet Pişkin Sokak",
            //        BuildingNo ="99/A",
            //        ZipCode ="60600"
            //    },
            //    new Address()
            //    {
            //        Country ="Türkiye",
            //        City = "Kayseri",
            //        Quarter ="Melikgazi Mahallesi",
            //        Street="Şehit Uzman Pilot Ahmet Yıldırım",
            //        BuildingNo ="23/C",
            //        ZipCode ="38000"
            //    },
            //    new Address()
            //    {
            //        Country ="Türkiye",
            //        City = "Çorum",
            //        Quarter ="Alaca Mahallesi",
            //        Street="İskilipli Atıf Hoca Caddesi",
            //        BuildingNo ="54/B",
            //        ZipCode ="19000"
            //    },
            //};
            //List<User> userList = new()
            //{
            //    new User
            //    {
            //        Name = "Melih",
            //        Surname = "Koçak",
            //        Mail ="melih3660k@gmail.com",
            //        PhoneNumber="5414043661",
            //        Gender='E',
            //        AddressId =1
            //    },
            //     new User
            //    {
            //        Name = "Göktürk",
            //        Surname = "Serttaş",
            //        Mail ="gokturk@gmail.com",
            //        PhoneNumber="5411111111",
            //        Gender='E',
            //        AddressId =2
            //    },
            //      new User
            //    {
            //        Name = "Kürşat",
            //        Surname = "Ersin",
            //        Mail ="kursat@gmail.com",
            //        PhoneNumber="5422222222",
            //        Gender='E',
            //        AddressId =3
            //    }
            //};
            //List<Library> libraryList = new()
            //{
            //    new Library
            //    {
            //        Name = "Kayseri Kütüphanesi",
            //        AddressId=2
            //    },
            //    new Library
            //    {
            //        Name = "Çorum Kütüphanesi",
            //        AddressId=3
            //    },
            //    new Library
            //    {
            //        Name = "Tokat Kütüphanesi",
            //        AddressId=1
            //    }
            //};
            //List<Category> categoryList = new()
            //{
            //    new Category
            //    {
            //        Name = "Bilim Kurgu",
            //        Description = "Dune ve Yüzüklerin Efendisi Bu kategorinin kralıdır."
            //    },
            //     new Category
            //    {
            //        Name = "Tarih",
            //        Description = "Tarihi bilmeyen millet yok olmaya mahkumdur"
            //    },
            //      new Category
            //    {
            //        Name = "Felsefe",
            //        Description = "Dipsiz kuyuların bulunduğu alan. Bu alanda hareket edecek kişi ilk önce mantık ilmini tahsil etmelidir."
            //    },
            //};
            //List<Author> authorList = new()
            //{
            //    new Author
            //    {
            //        Name = "John Ronald Reuel",
            //        Surname ="Tolkien"
            //    },
            //    new Author
            //    {
            //        Name = "Frank",
            //        Surname ="Herbert"
            //    },
            //    new Author
            //    {
            //        Name = "İmam",
            //        Surname ="Gazali"
            //    }
            //};
            //List<Book> bookList = new()
            //{
            //    new Book
            //    {
            //        Name ="Mekâsidü’l Felâsife",
            //        PageCount = 562,
            //        PublishedDate = DateOnly.FromDateTime(DateTime.Now.Date.AddDays(-20)),
            //       ISBN=Guid.NewGuid()
            //    },
            //     new Book
            //    {
            //        Name ="Dune Çöl Gezegeni",
            //        PageCount = 562,
            //        PublishedDate = DateOnly.FromDateTime(DateTime.Now.Date.AddDays(-40)),
            //       ISBN=Guid.NewGuid()
            //    },
            //      new Book
            //    {
            //        Name ="Sultan II. Abdülhamid Han’la 113 Gün",
            //        PageCount = 562,
            //        PublishedDate = DateOnly.FromDateTime(DateTime.Now.Date.AddYears(-14)),
            //       ISBN=Guid.NewGuid()
            //    }
            //};
            //List<Deposit> depositList = new()
            //{
            //    new Deposit
            //    {
            //        UserId = 10,
            //        DepositDate = DateOnly.FromDateTime(DateTime.Now),
            //        DeliveryDate = DateOnly.FromDateTime(DateTime.Now.AddDays(15)),
            //    },
            //     new Deposit
            //    {
            //        UserId = 11,
            //        DepositDate = DateOnly.FromDateTime(DateTime.Now),
            //        DeliveryDate = DateOnly.FromDateTime(DateTime.Now.AddDays(15)),
            //    },
            //      new Deposit
            //    {
            //        UserId = 12,
            //        DepositDate = DateOnly.FromDateTime(DateTime.Now),
            //        DeliveryDate = DateOnly.FromDateTime(DateTime.Now.AddDays(15)),
            //    }

            //};

            //context.Addresses.AddRange(addressList);
            //context.AddRange(userList);
            //context.AddRange(libraryList);
            //context.AddRange(categoryList);
            //context.AddRange(authorList);
            //context.AddRange(bookList);
            //context.AddRange(depositList);

            //context.SaveChanges();

            #endregion


            //@TODO: Soruları query syntax ile tekrardan çöz.
            //Questions
            #region GEMINI Soru 1: Ekleme (Create) - Yeni Bir Üye Kaydı

            //QUESTION
            /*
             Yeni bir üye kütüphaneye kaydoluyor. Görev: UYELER tablosuna aşağıdaki bilgilere
             sahip yeni bir üye kaydı ekleyin. Adres bilgisini boş bırakabilirsiniz 
             (çünkü ilişki 1-1 olsa da, adres verisi ayrı bir işlemde eklenebilir). 
            */


            //ANSWER
            /*
                User newUser = new User()
                {
                    Name = "Ayşe",
                    Surname = "Yılmaz",
                    Gender = 'K',
                    Mail = "ayse.yilmaz@ornek.com",
                    PhoneNumber = "5321112233",
                    AddressId = 1
                };

            context.Users.Add(newUser);
            context.SaveChanges();
            */


            //SQL KARŞILIĞI
            /*
                INSERT INTO USER 
                VALUES('Ayşe', 'Yılmaz', 'K', 'ayse.yilmaz@ornek.com','5321112233',1)
            */
            #endregion

            #region GEMINI Soru 2: Okuma (Read) - Temel Listeleme
            //QUESTION
            /*
             KATEGORILER tablosundaki tüm kategorilerin ID'sini ve Ad'ını listeleyen
             bir sorgu yazın. Sorguyu, kategori adına göre alfabetik olarak sıralayın.
            */

            //METHOD SYNTAX ANSWER
            /*
            var questionTwo = context
                .Categories
                .Select(c => new { c.Id, c.Name })
                .OrderBy(c => c.Name)
                .AsNoTracking();

            foreach (var item in questionTwo)
                Console.WriteLine($"{item.Id}, {item.Name}");
            */

            //QUERY SYNTAX ANSWER,
            /*
            var result = (from c in context.Categories
                          orderby c.Name
                          select new
                          {
                              c.Id,
                              c.Name
                          })
                          .AsNoTracking();
            foreach (var item in result)
                Console.WriteLine($"{item.Id}, {item.Name}");
            */

            //SQL Karşılığı
            /*
                SELECT ID, NAME FROM Categories ORDER BY NAME
            */
            #endregion

            #region GEMINI Soru 3: Güncelleme (Update) - Yazar Adı Düzeltme
            //Question
            /*
                ID'si 5 olan yazarın Ad bilgisini "Mehmet" yerine "Ahmet" olarak güncelleyen 
                ve bu değişikliği veritabanına kaydeden kodu yazın. (ID 5'in var olduğunu varsayıyoruz).
            */

            //Method Syntax Answer
            /*
            var questionThree = context
            .Authors
            .FirstOrDefault(a => a.Id == 5);

            questionThree.Name = "Ahmet";

            context.SaveChanges();
            */

            //Query Syntax Answer
            /*
            var result = (from item in context.Authors
                          where item.Id == 5
                          select item).FirstOrDefault();

            result.Name = "Ahmet";
            context.SaveChanges();
            */

            //SQL Karşılığı
            /*
                UPDATE AUTHORS SET NAME = 'AHMET' WHERE ID = 5
            */
            #endregion

            #region GEMINI Soru 4: Silme (Delete) - Eski Bir Kitabı Kaldırma

            //QUESTION
            /*
             * ID'si 10 olan kitabı KITAPLAR tablosundan veritabanından tamamen silen kodu yazın.
             * (ID 10'un var olduğunu ve ilişkisel kısıtlamaların buna izin verdiğini varsayıyoruz).
             */

            //METHOD SYNTAX ANSWER
            /*
            var questionFour = context
            .Books
            .FirstOrDefault(b => b.Id == 14);
            context.Books.Remove(questionFour!);
            context.SaveChanges();
            */


            //QUERY SYNTAX ANSWER
            /*
            var result = (from item in context.Books
                          where item.Id == 10
                          select item).FirstOrDefault();

            context.Books.Remove(result);
            context.SaveChanges();
            */

            //SQL Karşılığı
            /*
                DELETE FROM BOOKS WHERE ID = 10
            */
            #endregion

            #region GEMINI Soru 5: Okuma (Read) - Koşullu Filtreleme

            //QUESTION
            /*
             * Soru 5: KITAPLAR tablosundan Yayın Tarihi 2020 yılından büyük veya eşit olan
             * (yani YayinTarihi >= 2020) tüm kitapların Ad ve ISBN bilgilerini listeleyen
             * bir sorgu yazın. 
             */

            //METHOD SYNTAX ANSWER
            /*
            var questionFive = context
                .Books
                .Where(b => b.PublishedDate.Year >= 2020)
                .Select(b => new { b.Name, b.ISBN })
                .AsNoTracking();

            foreach (var item in questionFive)
                Console.WriteLine($"{item.Name}, {item.ISBN}");
            */

            //QUERY SYNTAX ANSWER
            /*
            var result = from book in context.Books
                         where book.PublishedDate.Year >= 2020
                         select new {book.Name, book.PublishedDate};

            foreach (var item in result)
                Console.WriteLine($"{item.Name}   ---   {item.PublishedDate}");
            */

            //SQL KARŞILIĞI
            /*
             SELECT NAME, ISBN FROM BOOKS WHERE PublishedDate >= '2020'
            */
            #endregion

            #region GEMINI Soru 6: İlişkisel Sorgulama (Inner Join)

            //QUESTION
            /*
             Hangi üyenin (üyelerin) hangi kitabı (kitapları) ödünç aldığını görmek istiyorsunuz.
             Görev: Henüz teslim edilmemiş olan (yani TeslimTarihi alanı NULL olan) tüm emanet 
             kayıtlarını listeleyin. Listede her kayıt için aşağıdaki bilgileri getirin:
             Üye Adı Soyadı (UYELER tablosundan)
             Kitap Adı (KITAPLAR tablosundan)
             Veriliş Tarihi (EMANET tablosundan)
            */

            //ANSWER
            /*
                var result = context
                    .Users
                    .Join(context.Deposits, u => u.Id, d => d.UserId, (x, y) => new
                {
                    UserName = x.Name,
                    UserSurname = x.Surname,
                    DepositDate = y.DepositDate,
                    BookId = y.BookId,
                    DeliveryDate = y.DeliveryDate
                })
                    .Join(context.Books, d => d.BookId, b => b.Id, (x, y) => new
                {
                    UserName = x.UserName,
                    UserSurname = x.UserSurname,
                    DepositDate = x.DepositDate,
                    BookName = y.Name,
                    DeliveryDate = x.DeliveryDate
                })
                .Where(c => c.DeliveryDate.Year > 2020)
                .AsNoTracking()
                .ToList();
            */

            //QUERY SYNTAX ANSWER
            /*
            var results = from user in context.Users
                          join deposit in context.Deposits
                                on user.Id equals deposit.UserId
                          join book in context.Books
                                on deposit.BookId equals book.Id
                          where deposit.DeliveryDate == null
                          select new
                          {
                              userName = user.Name,
                              userSurname = user.Surname,
                              bookName = book.Name,
                              depositDate = deposit.DepositDate,
                          };
              */

            //SQL KARŞILIĞI
            /*
                SELECT U.Name, U.Surname, D.DeliveryDate FROM Deposits D
                JOIN Users U 
                ON U.Id = D.UserId
                JOIN
                Books B
                ON
                B.Id = D.BookId
                WHERE DeliveryDate IS NULL
             */
            #endregion

            #region GEMINI Soru 7: Çoklu İlişki Ekleme (Many-to-Many)
            /*
             ID'si 50 olan bir kitap (varsayın ki context.Books.Find(50) ile getirdiniz)
            ve ID'leri 1 ve 3 olan kategoriler (varsayın ki bunlar mevcut) arasında many-to-many 
            ilişkisi kuran kodu yazın. (Kitap-Kategori ilişkisi BULUNUR ara tablosu ile sağlanıyor 
            olmalı). 
            */

            //METHOD SYNTAX ANSWER
            /*
            var book = context.Books.Include(b => b.Categories).FirstOrDefault(b => b.Id == 50);
            var kategori1 = context.Categories.Find(1);
            var kategori3 = context.Categories.Find(3);

            book.Categories.Add(kategori1);
            book.Categories.Add(kategori3);

            context.SaveChanges();
            */

            //QUERY SYNTAX ANSWER -> Bu çözüm aşırı zorlama ve saçma olduğunu biliyorum, hiç bir yerde kullanılmayacağını tahmin ediyorum lakin farklı düşünmek amaçlı uyguladım.
            /*
            Book oneBook = default!;
            Category categoryOne = default!;
            Category categoryThree = default!;

            var book = (from bk in context.Books
                              where bk.Id == 13
                              select bk)
                              .Include(b => b.Categories);

            foreach (Book item in book)
                oneBook = item;

            var kategori1 = (from ct in context.Categories
                                       where ct.Id == 13
                                       select ct);

            var kategori3 = (from ct in context.Categories
                                       where ct.Id == 14
                                       select ct);

            foreach (Category item in kategori1)
                categoryOne = item;

            foreach (Category item in kategori3)
                categoryThree = item;

            oneBook.Categories.Add(categoryOne);
            oneBook.Categories.Add(categoryThree);

            context.SaveChanges();
            */

            //SQL KARŞILIĞI
            /*
                INSERT INTO BookCategory (BookID, CategoryID)
                VALUES (50, 1);

                INSERT INTO BookCategory (BookID, CategoryID)
                VALUES (50, 3);
             */
            #endregion

            #region GEMINI Soru 8: Gruplama ve Agregasyon (Grouping & Aggregation)

            //Question
            /*
             YAZARLAR ve KITAPLAR tablolarını kullanarak, tüm yazarları (yazar adı ve soyadı) 
             listeleyin ve yanına o yazarın yazdığı kitap sayısını getirin. Kitap sayısı 
             azalan sırada sıralanmalıdır.
             */

            //Method Syntax Answer
            /*
                var result = context.Authors.
                    Select(a => new
                    {
                        Name = a.Name,
                        Surname = a.Surname,
                        TotalBooks = a.Books.Count
                    })
                    .OrderByDescending(a => a.TotalBooks)
                    .AsNoTracking();
             */


            //Query Syntax Answer
            /*
            var result = from at in context.Authors
                         select new
                         {
                             Name = at.Name,
                             Surname = at.Surname,
                             Deger = at.Books.Count
                         };
                         

            foreach (var item in result)
                Console.WriteLine($"{item.Name}, {item.Surname}, {item.Deger}");
            */

            //SQL KARŞILIĞI
            /*
                SELECT 
                        AuthorId,
                        Authors.Name,
                        Authors.Surname,
                        Count(BooksId) as 'Yazarın Toplam Kitap Sayısı'
                FROM AuthorBook
                JOIN Authors
                ON AuthorBook.AuthorId = Authors.Id
                GROUP BY AuthorId, Authors.Name, Authors.Surname
            */
            #endregion

            #region GEMINI Soru 9: Eager Loading (Include)
            //Question
            /*
              Tüm kütüphane kayıtlarını ve bunlara ait adres bilgilerini tek 
              bir sorguda getirmek istiyorsunuz.Görev: KUTUPHANE varlıklarını
              sorgulayın ve bu sorguya, ilişkili oldukları ADRESLER varlığını 
              da tek bir veritabanı sorgusunda getiren(Eager Loading) kodu yazın.
              Sonuçları listeleyip, her kütüphane için Kütüphane Adını ve Adresindeki 
              Şehir bilgisini yazdırın.
            */

            //Answer
            /*
                var result = context.Libraries
                    .Include(b => b.Address)
                    .AsNoTracking();

                foreach (var item in result)
                    Console.WriteLine($"{item.Name}, {item.Address.City}");
            */

            //SQL Karşılığı
            /*
             SELECT L.Name, A.City FROM Libraries AS L JOIN Addresses AS A ON L.AddressId = A.ID 
            */
            #endregion

            #region GEMINI Soru 10: İlişkisel Silme Kontrolü (Cascade Delete)
            //QUESTION
            /*
             Soru 10: ID'si 2 olan adresi veritabanından silmek üzere işaretleyen
            kodu yazın. Bu adresin hem bir üyeye hem de bir kütüphaneye ait olduğunu 
            varsayarsak, bu silme işleminin veritabanı kısıtlamaları veya EF Core model
            ayarları nedeniyle hangi durumlarda sorun çıkaracağını (ya da Cascade Delete ile 
            otomatik silineceğini) kodunuzun altında açıklayın.
            */

            //ANSWER
            /*
                var address = context.Addresses.FirstOrDefault(a => a.ID == 2);
                context.Addresses.Remove(address);
                context.SaveChanges();

            //• Cascade Delete aktifse → Sorunsuz
            //• Cascade Delete iki tarafta ise → SQL Multiple Cascade Path hatası verebilir
            //• Restrict / NoAction ise → Kesinlikle hata verir, silinemez
            //• Silinebilmesi için: ilişkilerin modelde doğru yapılandırılmış olması gerekir
             */

            //SQL KARŞILIĞI
            /*
                DELETE FROM ADDRESSES WHERE ID = 2
             */
            #endregion

            #region GEMINI Soru 11: Bire Çoğa İlişki Sorgusu (1-N)

            //QUESTION
            /* 
            Görev: Tüm üyeleri (Ad ve Soyad) ve her üyenin toplam kaç kitap ödünç 
            aldığını (EMANET kaydı sayısını) listeleyin. Sonuçları ödünç alınan kitap 
            sayısına göre azalan sırada sıralayın.
             */

            //METHOD SYNTAX ANSWER ONE
            /*
            var result = context.Deposits
                .GroupBy(d => d.UserId)
                .Select(g => new
                {
                    NameAndSurname = g.First().User.Name + " " + g.First().User.Surname,
                    ToplamDeposit = g.Count()
                });

            foreach (var item in result)
                Console.WriteLine($"{item.NameAndSurname}, {item.ToplamDeposit}");
            */

            //METHOD SYNTAX ANSWER TWO
            /*
            var result = context.Users.Select(d => new
            {
                Name = d.Name,
                Surname = d.Surname,
                Toplam = d.Deposits.Count()
            })
            .OrderByDescending(x => x.Toplam);

            foreach (var item in result)
                Console.WriteLine($"{item.Name}, {item.Surname}, {item.Toplam}");
            */

            //Query Syntax Answer
            /*
            var result = from us in context.Deposits
                         group us by new
                         {
                             us.UserId,
                             us.User.Name,
                             us.User.Surname
                         } into ud orderby ud.Count() descending
                         select new
                         {
                             Name = ud.Key.Name,
                             Surname = ud.Key.Surname,
                             Count = ud.Count()
                         };

            foreach (var item in result)
                Console.WriteLine($"{item.Name}, {item.Surname}, {item.Count}");
            */


            //SQL KARŞILIĞI
            // select Name, Surname, Count(Deposits.UserId) from Users join Deposits on Deposits.UserId = Users.Id group by Name,Surname
            #endregion

            #region GEMINI Soru 12: Çoka Çoğa İlişki Sorgusu (M-N)
            //QUESTION
            /*
                Görev: ID'si 7 olan yazarın yazdığı tüm kitapların ait olduğu 
                farklı kategorilerin (Ad ve Açıklama) listesini getirin.
            */

            //ANSWER
            /*
            var result = context.Authors.Where(a => a.Id == 7)
                .SelectMany(a => a.Books)
                .SelectMany(b => b.Categories)
                .Select(c => new
                {
                    CategoryName = c.Name,
                    CategoryDescription = c.Description
                })
                .Distinct()
                .AsNoTracking();

            foreach (var item in result)
                Console.WriteLine($"{item.CategoryName}, {item.CategoryDescription}");
            */

            //SQL KARŞILIĞI
            /*
             select distinct c.Name, c.Description from AuthorBook a join BookCategory bc on a.BooksId = bc.BooksId join Categories c on c.Id = bc.CategoriesId where AuthorId = 15
             */
            #endregion

            #region GEMINI Soru 13: Agregasyon Ve Filtreleme (Aggregation & Filtering)
            //QUESTION
            /*
                Yalnızca toplam sayfa sayısı 1000'den fazla olan yazarları (Ad ve Soyad)
                ve bu yazarların kitaplarının toplam sayfa sayısını 
                (Sayfa Sayısı alanını toplayarak) listeleyin.
             */

            //ANSWER
            /*
             var result = context.Authors
            .Select(a => new
                 {
                     YazarAdSoyad = a.Name + " " + a.Surname,
                     ToplamSayfaSayisi = a.Books.Sum(b => b.PageCount)
                 })
            .Where(r => r.ToplamSayfaSayisi > 1000)
            .AsNoTracking();

             foreach (var item in result)
                 Console.WriteLine($"{item.YazarAdSoyad}, {item.ToplamSayfaSayisi}");
            */

            //SQL KARŞILIĞI
            /*
            select a.Name, a.Surname, SUM(b.PageCount), a.Id 
            from Authors a
            join AuthorBook ab on a.Id = ab.AuthorId
            join Books b on b.Id = ab.BooksId
            group by a.Id, a.Name, a.Surname
            having SUM(b.PageCount) > 1000
            */
            #endregion

            #region GEMINI Soru 14: İlişkisel Filtreleme ve Kontrol (Any/All)
            //QUESTION
            /*
              Henüz hiçbir kitabının ödünç verilmediği yazarları bulmak istiyorsunuz.
              Görev: Hiçbir kitabının EMANET tablosunda kaydı bulunmayan yazarların (Ad ve Soyad) 
              listesini getiren bir sorgu yazın.
            */

            //ANSWER
            /*
            var result = context.Authors
            .Where(a => a.Books.All(b => !b.Deposit.Any()))
            .Select(a => new
            {
                a.Name,
                a.Surname
            })
            .AsNoTracking()
            .ToList();

            foreach (var item in result)
                Console.WriteLine($"{item.Name}, {item.Surname}");
            */

            //SQL KARŞILIĞI
            /*
             select A.Name, A.Surname from Authors A
                Where NOT EXISTS 
                (
                    select * FROM AuthorBook AB
                    JOIN Deposits D ON AB.BooksId = D.BookId
                    Where AB.AuthorId = A.Id
                )
            */
            #endregion

            #region GEMINI Soru 15: Çoklu Şartlı Güncelleme (Bulk Update Simülasyonu)
            //QUESTION
            /*
             Yayın Tarihi 2010'dan küçük olan ve Sayfa Sayısı 150'den az olan tüm kitapların
            (KITAPLAR tablosu) Sayfa Sayısı değerini 10 artıran kodu yazın. Bu işlemi EF Core'un
            her varlığı tek tek yükleyip güncelleme (Connected) yöntemini kullanarak yapın.
            (Bu, normalde Bulk Update ile daha hızlı yapılır, ancak burada EF Core'u pratik ediyoruz.)
            */

            //ANSWER

            /*
            var result = context.Books.Where(b => b.PublishedDate.Year < 2010 && b.PageCount < 150);

            foreach (var item in result)
                item.PageCount += 10;

            context.SaveChanges();
            */

            //SQL KARŞILIĞI
            /*
             UPDATE Books SET PageCount = PageCount+10 where PageCount<170 AND PublishedDate < '01-01-2010'
            */
            #endregion

            #region GEMINI SORU 16: İki Aşırı İlişkide Filtreleme ve Sıralama

            //QUESTION
            /* 
              Görev: ID'si 4 olan kategoriye ait tüm kitapları (KITAPLAR tablosundan) bulun. 
              Bu kitapları Yayın Tarihi'ne göre azalan(en yeniden en eskiye) sırada sıralayın 
              ve yalnızca kitapların Ad'ını ve Yayın Tarihi'ni listeleyin.
            */

            //METHOD SYNTAX ANSWER 1
            /*
              var result = context.Books
                 .SelectMany(b => b.Categories, (book, category) => new
             {
                 BookName = book.Name,
                 BookDate = book.PublishedDate,
                 CategoryId = category.Id,  
             })
                 .Where(b => b.CategoryId == 4)
                 .OrderByDescending(a =>a.BookDate)
                 .AsNoTracking();

             foreach (var item in result)
                 Console.WriteLine($"{item.BookName}, {item.BookDate}");
            */


            //METHOD SYNTAX ANSWER 2
            /*
            var result = context.Books
                .AsNoTracking()
                .Where(b => b.Categories.Any(c => c.Id == 4))
                .OrderByDescending(b => b.PublishedDate)
                .Select(b => new
                {
                    BookName = b.Name,
                    BookDate = b.PublishedDate,
                });

            foreach (var item in result)
                Console.WriteLine($"{item.BookName}, {item.BookDate}");
            */

            //SQL KARŞILIĞI
            /*
                select Books.Name, Books.PublishedDate from Books 
                join BookCategory
                on Books.Id = BookCategory.BooksId 
                where BookCategory.CategoriesId = 4 
                Order By Books.PublishedDate desc
            */
            #endregion

            #region GEMINI SORU 17: Null Kontrolü ve Varsayılan Değer Atama
            //QUESTION
            /*
              Teslim Tarihi (DeliveryDate) NULL olan tüm emanet kayıtlarını 
              (ID, Veriliş Tarihi) listeleyin ve sorguya NULL kontrolü yaparak, 
              Teslim Tarihi yerine (eğer NULL ise) "Teslim Edilmedi" metnini getiren 
              bir alan ekleyin.
            */

            //METHOD SYNTAX ANSWER
            /*
            var result = context.Deposits
                .Where(d => d.DeliveryDate == null)
                .Select(d => new
                {
                    EmanetId = d.Id,
                    VerilisTarihi = d.DepositDate,
                    TeslimDurumu = d.DeliveryDate == null
                       ? "Teslim Edilmedi"
                       : d.DeliveryDate.ToString()
                });

            foreach (var item in result)
                Console.WriteLine($"{item.EmanetId}   ---   {item.VerilisTarihi}   ---   {item.TeslimDurumu}");
            */

            //SQL KARŞILIĞI
            /*
             select Id, DepositDate ,
                Case
                        when DeliveryDate IS NULL then 'Teslim Edilmedi'
                        else CONVERT(NVARCHAR(MAX), DeliveryDate)
                    end as TeslimDurumu
                from Deposits where DeliveryDate is null
             */

            #endregion

            #region GEMINI SORU 18: Karmaşık İlişkilerde Count Kontrolü
            //QUESTION
            /*
             Senaryo: En az 3 farklı kategoride yer alan kitapları bulmak istiyorsunuz. 
             Görev: Ait olduğu kategori sayısı 3'e eşit veya daha fazla olan tüm 
             kitapların (Ad ve ISBN) listesini getirin.
            */

            //METHOD SYNTAX ANSWER
            /*
            var result = context.Books
                                .Where(b => b.Categories.Count() >= 3)
                                .Select(b => new
                                {
                                    BookName = b.Name,
                                    ISBN = b.ISBN
                                })
                                .AsNoTracking();
            
            foreach (var item in result)
                Console.WriteLine($"{item.BookName}, {item.ISBN}");
            */

            //SQL KARŞILIĞI
            /*
                SELECT  Books.Name, Books.ISBN 
                FROM BookCategory 
                JOIN Books ON BookCategory.BooksId = Books.Id
                GROUP BY Books.Name, Books.ISBN 
                HAVING COUNT(BookCategory.CategoriesId) >=3
             */
            #endregion

            #region GEMINI SORU 19: İlişkisel Veri İle Güncelleme
            //QUESTION
            /*
                ID'si 15 olan üyenin ödünç aldığı ve Teslim Tarihi NULL 
                olan tüm emanet kayıtlarının Teslim Tarihi alanını DateTime.Today 
                olarak güncelleyen kodu yazın.
            */

            //METHOD SYNTAX ANSWER
            /*
            var result = context.Deposits
                .Where(d => d.UserId == 15 && d.DeliveryDate == null)
                .ToList();

            foreach (var item in result)
                item.DeliveryDate = new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            context.SaveChanges();
            */

            //SQL KARŞILIĞI
            /*
             UPDATE Deposits Set DeliveryDate = '2025-12-12'
             Where Deposits.UserId = 15 and DeliveryDate IS null
             */
            #endregion

            #region GEMINI SORU 20: Dış Birleştirme (Left Join Simülasyonu)
            //QUESTION
            /*
                Tüm kütüphaneleri (Kütüphane Adı) listeleyin ve yanına o kütüphanede 
                bulunan farklı kitap sayısını getirin. Kitabı hiç bulunmayan kütüphaneler 
                bile listede olmalı ve kitap sayısı sıfır olarak görünmelidir.
             */

            //NOT:
            /*  Not: Çoka Çok ilişki bulunan entitylerde foreign key bulunmuyor ise sorgulama 
                işlemleri navigation property üzerinden olur.
               
                Çok çok ilişkide, bir entitydeki diğer tablo ile bağlantıyı sağlayan navigation
                propertyde group by kurmadan agregasyon fonksiyonlarını çalıştırabiliriz.
                
                Örnek:  1- Bir öğrencinin aldığı toplam ders sayısı
                        2- Bir ürünün bulunduğu toplam kategori sayısı
            */

            //METHOD SYNTAX ANSER
            /*
            var result = context.Libraries
                .AsNoTracking()
                .Select(l => new
                {
                    KutuphaneAdi = l.Name,
                    FarkliKitapSayisi = l.Books.Count
                });

            foreach (var item in result)
                Console.WriteLine($"{item.KutuphaneAdi}, {item.FarkliKitapSayisi}");
            */

            //SQL KARŞILIĞI
            /*
                select L.Name, Count(LB.BookId)
                from Libraries L left join LibraryBooks LB
                on L.Id = LB.LibraryId 
                group by L.Name
             */
            #endregion

            #region GEMINI SORU 21: Basit Join ve Filtreleme (Kolay)
            //QUESTION
            /*
                Ankara'da bulunan kütüphanelerde hangi kitapların bulunduğunu 
                görmek istiyorsunuz. Görev: ADRESLER ve KUTUPHANE tablolarını 
                kullanarak, adresi Şehir='Ankara' olan tüm kütüphanelerin ID'lerini 
                listeleyin. (Kitap listelemeye gerek yok, sadece kütüphane ID'leri yeterli).
             */

            //METHOD SYNTAX
            //Birinci Yöntem
            /*
            var result1 = context.Addresses
                .Where(a => a.City == "Ankara")
                .Join(context.Libraries, a => a.ID, l => l.AddressId, (address, library) => new
                {
                    libraryId = library.Id
                });
            
            //İkinci Yöntem
            var result2 = context.Libraries
                .Where(a => a.Address.City == "Tokat");

            foreach (var item in result1)
                Console.WriteLine($"{item.libraryId}");
            */

            //SQL KARŞILIĞI
            /* select L.Id from Libraries L join Addresses A on L.AddressId = A.ID where A.City = 'tokat' */
            #endregion

            #region GEMINI SORU 22: Count ile Basit Gruplama (Kolay/Orta)
            //QUESTION
            /*
                EMANET tablosunu kullanarak, kitapların ödünç verildiği yıl ve
                ay bazında gruplama yapın ve her gruptaki toplam emanet sayısını 
                listeleyin. Sonuçları emanet sayısına göre azalan sırada sıralayın.
            */

            //METHOD SYNTAX ANSWER
            /*
            var result = context.Deposits
                .GroupBy(d => new { d.DepositDate.Year, d.DepositDate.Month })
                .Select(g => new
                {
                    Yıl = g.Key.Year,
                    Ay = g.Key.Month,
                    Sayı = g.Count()
                })
                .OrderByDescending(a => a.Sayı);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Yıl}   ---   {item.Ay}   ---   {item.Sayı}");
            }
            */

            //SQL KARŞILIĞI
            /*
                select count(*) KITAPSAYISI, DatePart(YEAR,DepositDate) AS YIL,
                DatePart(MONTH,DepositDate) AS AY 
                from Deposits 
                group by DatePart(YEAR,DepositDate), DatePart(MONTH,DepositDate)
            */
            #endregion
        }
    }
}