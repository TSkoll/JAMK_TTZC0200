using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;

namespace Harjoitus24.IO
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
