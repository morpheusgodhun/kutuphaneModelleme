namespace kutuphaneModelleme;
    public class PublishingHouses {
        public int Id { get; set; }
        public string PublishingHouseName { get; set; }

        List<PublishingHouses> publishingHousesList = new List<PublishingHouses>
   {
                new PublishingHouses { Id = 1, PublishingHouseName = "Turkuaz" },
                new PublishingHouses { Id = 2, PublishingHouseName = "Samanyolu" }
            };
    }