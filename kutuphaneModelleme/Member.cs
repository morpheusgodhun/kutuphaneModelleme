namespace kutuphaneModelleme;
    public class Member {
    public int MemberId { get; set; }
    public string MemberName { get; set; }
    public string MemberSurname { get; set; }
    public int MemberNumber { get; set; }
    public List<Book> BorrowedBooks { get; set; }
}