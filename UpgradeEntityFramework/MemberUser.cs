using System.Collections.Generic;

namespace UpgradeEntityFramework
{
    public class MemberUser
    {
        public string Id { get; set; }

        public ICollection<EventSignup> EventSignups { get; set; } = new List<EventSignup>();
    }
}