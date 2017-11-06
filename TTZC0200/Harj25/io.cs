using Newtonsoft.Json;
using System;
using System.IO;

namespace Harj25.IO
{
    public static class TiedostonHallinta
    {
        public static void TallennaTiedot(Tiedot[] tiedot)
        {
            string json = JsonConvert.SerializeObject(tiedot);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "tiedot.json"), json);
        }

        public static Tiedot[] LataaTiedot()
        {
            return JsonConvert.DeserializeObject<Tiedot[]>(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "tiedot.json")));
        }
    }
}
