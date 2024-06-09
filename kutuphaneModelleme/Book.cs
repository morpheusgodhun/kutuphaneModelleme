namespace kutuphaneModelleme;
public class Book {
    public int BookID { get; set; }
    public string BookTitle { get; set; }
    public List<Author> Authors { get; set; }
    public string Publisher { get; set; }
    public List<string> Categories { get; set; }
    public string ISBN { get; set; }
    public int CopiesCount { get; set; }
    public DateTime RelaseDate { get; set; }
    public int PageNumber { get; set; }

}