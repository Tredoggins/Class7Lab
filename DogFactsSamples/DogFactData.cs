using System;
using System.Collections.Generic;

namespace DogFactsSamples
{
    public class DogFactData
    {
        public DogFactData()
        {
        }
        public static IEnumerable<DogFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string Image { get; set; }
        static DogFactData()
        {
            List<DogFactData> all = new List<DogFactData>();
            all.Add(new DogFactData() { TheFact = "I have 9 toes", ShortFact = "9 toes", Image="toes.jpg"});
            all.Add(new DogFactData() { TheFact = "I can play guitar fairly well", ShortFact = "Guitar Player", Image = "guitar.jpg" });
            all.Add(new DogFactData() { TheFact = "I am fairly tall at 6 feet 1 inch", ShortFact = "6' 1\"", Image = "ruler.jpg" });
            all.Add(new DogFactData() { TheFact = "I have blonde hair and blue eyes", ShortFact = "Aryan", Image = "blondeblue.jpg" });
            all.Add(new DogFactData() { TheFact = "I like anime, and watch about 15 at a time depending on the season", ShortFact = "Anime Lover", Image = "anime.jpg" });
            All = all;

        }
    }
}