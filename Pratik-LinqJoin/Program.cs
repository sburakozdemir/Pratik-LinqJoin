using Pratik_LinqJoin;

// Yazar listesi oluşturuluyor
List<Author> authors = new List<Author>
{
    new Author (1,"Orhan Pamuk"),
    new Author (2,"Elif Şafak"),
    new Author (3,"Ahmet Ümit")
};

// Kitap listesi oluşturuluyor
List<Book> books = new List<Book>
{
    new Book (1,"Kar",1),
    new Book (2,"İstanbul",1),
    new Book (3,"10 Minutes",2),
    new Book (4,"Beyoğlu Rapsodisi",3)
};

// LINQ sorgusu: Kitapları ve yazarları birleştiriyor
var query = from author in authors
            join book in books
            on author.AuthorId equals book.AuthorId
            select new
            {
                BookTitle = book.Title,
                AuthorName = author.Name
            };

// Sorgu sonuçlarını ekrana yazdırma
foreach (var item in query)
{
    Console.WriteLine($"Kitap: {item.BookTitle}, Yazar: {item.AuthorName}");
}