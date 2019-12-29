namespace UpgradeEntityFramework
{
    public class EventSignup
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public MemberUser User { get; set; }
    }
}