namespace kutuphaneModelleme;
public class Author {
    public int AuthorsId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateofBirth { get; set; }
    public List<Book> Books { get; set; }
}