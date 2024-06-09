namespace kutuphaneModelleme;
    public class Librarian {
        public int LibrarianID { get; set; }
        public string LibrarianName { get; set; }

        List<Librarian> librariansList = new List<Librarian>
            {
                new Librarian { LibrarianID = 1, LibrarianName = "Yılmaz Kurtay" },
                new Librarian { LibrarianID = 2, LibrarianName = "Akın Bedel" }
            };
    }