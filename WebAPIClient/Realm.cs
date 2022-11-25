using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardGameData
{
    internal class Realm
    {
        public bool is_tournament { get; set; }
        public TimeZoneInfo timezone { get; set; }
        public RealmName name { get; set; }
        public int id { get; set; }
        public Region region { get; set; }
        public Category category { get; set; }
        public string locale { get; set; }
        public Type type { get; set; }
        public string slug { get; set; }
    }

    internal class RealmName
    {
        public string it_IT {  get; set; }
        public string ru_RU { get; set; }
        public string en_GB { get; set; }
        public string zh_TW { get; set; }
        public string ko_KR { get; set; }
        public string en_US { get; set; }
        public string es_MX { get; set; }
        public string pt_BR { get; set; }
        public string es_ES { get; set; }
        public string zh_CN { get; set; }
        public string fr_FR { get; set; }
        public string de_DE { get; set; }
    }
}