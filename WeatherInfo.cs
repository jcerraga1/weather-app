using System.Collections.Generic;

namespace WeatherApp
{
    public class WeatherInfo
    {
        public long timezone { get; set; }
        public class root
        {
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
            public long timezone { get; set; }
        }

        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class main
        {
            public float temp { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }

        public class wind
        {
            public float speed { get; set; }
        }

        public class sys
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }
        }
    }
}

