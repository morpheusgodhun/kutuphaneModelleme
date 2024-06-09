namespace kutuphaneModelleme;
public class Authors {
    public int AuthorsId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateofBirth { get; set; }

    List<Authors> authorsList = new List<Authors>
      {
                new Authors { AuthorsId = 1, Name = "Reşat Nuri", Surname = "Güntekin", DateofBirth = new DateTime(1980, 6, 15) },
                new Authors { AuthorsId = 2, Name = "Ömer", Surname = "Seyfettin", DateofBirth = new DateTime(1975, 8, 20) }
            };
}