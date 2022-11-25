using Newtonsoft.Json;

namespace BlizzardGameData
{
    class Engine
    {
        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("Realms.US.json"))
            {
                string json = r.ReadToEnd();
                dynamic jsonResult = JsonConvert.DeserializeObject<dynamic>(json);
                var realms = JsonConvert.DeserializeObject<dynamic>(jsonResult.results.ToString());
                Console.WriteLine(realms[0]); 
            }
        }
    }

    internal class RealmRoot
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public int maxPageSize { get; set; }
        public int pageCount { get; set; }
        Result results { get; set; }
    }

    internal class Result
    {
        public List<Results> results { get; set; }
    }

    internal class Results
    {
        public Key key { get; set; }
        public Realm data { get; set; }
    }

    internal class Key
    {
        public string href { get; set; }
    }
}