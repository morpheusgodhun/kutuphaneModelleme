namespace kutuphaneModelleme;
    public class Members {
    public int MemberId { get; set; }
    public string MemberName { get; set; }
    public string MemberSurname { get; set; }
    public int MemberNumber { get; set; }

    List<Members> membersList = new List<Members>
      {
                new Members { MemberId = 1, MemberName = "Dilan", MemberSurname = "Sağın", MemberNumber = 101 },
                new Members { MemberId = 2, MemberName = "Orhun", MemberSurname = "Babaoglu", MemberNumber = 102 }
            };
}