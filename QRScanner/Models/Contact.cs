namespace QRScanner.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        //public string Bio { get; set; }
        public string ImageUrl { get; set; }
        public string SmallImageUrl { get; set; }
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public string BioDescription { get; set; }
        public virtual ICollection<ContactDetails> ContactDetails { get; set; }
    }
    public class ContactDetails
    {
        public Guid Id { get; set; }
        public string LinkedInUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string TiktokUrl { get; set; }
        public string SnapChatUrl { get; set; }
        public string TwitchUrl { get; set; }
        public string PinterestUrl { get; set; }
        public string VimeoUrl { get; set; }
        public string YouTubeUrl { get; set; }
        public string SpotifyUrl { get; set; }
        public string SoundCloudUrl { get; set; }
        public string AppleMusicUrl { get; set; }
        public string ITunesUrl { get; set; }
        public string YouTubeMusicUrl { get; set; }
        public string AmazonMusicUrl { get; set; }
        public string CalendlyUrl { get; set; }
        public string NotionUrl { get; set; }
        public string GoogleDriveUrl { get; set; }
        public string DribbleUrl { get; set; }
        public string GitHubUrl { get; set; }
        public string BehanceUrl { get; set; }
        public string EtsyUrl { get; set; }
        public string CashAppUrl { get; set; }
        public string VenmoUrl { get; set; }
        public string PaypalUrl { get; set; }
        public string WhatsappUrl { get; set; }
        public string DiscordUrl { get; set; }
        public string WechatUrl { get; set; }
        public string TelegramUrl { get; set; }
        public string SignalUrl { get; set; }
    }
}
