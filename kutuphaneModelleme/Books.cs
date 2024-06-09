namespace kutuphaneModelleme;
public class Books {
    public int BookID { get; set; }
    public string BookTitle { get; set; }
    public string Writer { get; set; }
    public DateTime RelaseDate { get; set; }
    public string Type { get; set; }
    public int PageNumber { get; set; }

    List<Books> booksList = new List<Books>
       {
                new Books { BookID = 1, BookTitle = " Halikarnas Balıkçısı", Writer = "Cevat Şakir Kabaağaçlı", RelaseDate = new DateTime(2020, 5, 1), Type = "Roman", PageNumber = 500 },
                new Books { BookID = 2, BookTitle = "Çalıkuşu", Writer = "Reşat Nuri Güntekin", RelaseDate = new DateTime(2019, 3, 15), Type = "Roman", PageNumber = 350 }
            };
}