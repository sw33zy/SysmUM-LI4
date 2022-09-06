using System.Net.Http;
using System.Net.Http.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Threading.Tasks;
using SysmumDataAccessLibrary.Models;

namespace SysmUM.Services
{
    public class SeismService
    {
        static string baseAddress = "http://localhost:5001/";
        private readonly HttpClient Http = new HttpClient() { BaseAddress = new Uri(baseAddress) };
        public async Task<List<SeismModel>> GetSeisms()
        {
            SeismsData data;
            data = await Http.GetFromJsonAsync<SeismsData>("https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_month.geojson");
            List<SeismModel> Seisms = new List<SeismModel>();
            foreach (var s in data.features)
            {
                SeismModel sis = new SeismModel();
                sis.id = s.id;
                sis.latitude = s.geometry.coordinates[1];
                sis.longitude = s.geometry.coordinates[0];
                sis.radius = s.properties.dmin;
                sis.magnitude = s.properties.mag;
                sis.place = s.properties.place;
                sis.significance = s.properties.sig;
                sis.time = s.properties.time;
                sis.dateSeism = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(double.Parse(sis.time.ToString()));
                Seisms.Add(sis);
            }
            return Seisms;
        }

        public async Task<List<SeismModel>> GetSeismsLastHour()
        {
            SeismsData data;
            data = await Http.GetFromJsonAsync<SeismsData>("https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_hour.geojson");
            List<SeismModel> Seisms = new List<SeismModel>();
            foreach (var s in data.features)
            {
                SeismModel sis = new SeismModel();
                sis.id = s.id;
                sis.latitude = s.geometry.coordinates[1];
                sis.longitude = s.geometry.coordinates[0];
                sis.radius = s.properties.dmin;
                sis.magnitude = s.properties.mag;
                sis.place = s.properties.place;
                sis.significance = s.properties.sig;
                sis.time = s.properties.time;
                sis.dateSeism = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(double.Parse(sis.time.ToString()));
                Seisms.Add(sis);
            }
            return Seisms;
        }

        public async Task<List<SeismModel>> GetSeismsLastDay()
        {
            SeismsData data;
            data = await Http.GetFromJsonAsync<SeismsData>("https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson");
            List<SeismModel> Seisms = new List<SeismModel>();
            foreach (var s in data.features)
            {
                SeismModel sis = new SeismModel();
                sis.id = s.id;
                sis.latitude = s.geometry.coordinates[1];
                sis.longitude = s.geometry.coordinates[0];
                sis.radius = s.properties.dmin;
                sis.magnitude = s.properties.mag;
                sis.place = s.properties.place;
                sis.significance = s.properties.sig;
                sis.time = s.properties.time;
                sis.dateSeism = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(double.Parse(sis.time.ToString()));
                Seisms.Add(sis);
            }
            return Seisms;
        }

        public async Task<List<SeismModel>> GetSeismsLastWeek()
        {
            SeismsData data;
            data = await Http.GetFromJsonAsync<SeismsData>("https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_week.geojson");
            List<SeismModel> Seisms = new List<SeismModel>();
            foreach (var s in data.features)
            {
                SeismModel sis = new SeismModel();
                sis.id = s.id;
                sis.latitude = s.geometry.coordinates[1];
                sis.longitude = s.geometry.coordinates[0];
                sis.radius = s.properties.dmin;
                sis.magnitude = s.properties.mag;
                sis.place = s.properties.place;
                sis.significance = s.properties.sig;
                sis.time = s.properties.time;
                sis.dateSeism = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(double.Parse(sis.time.ToString()));
                Seisms.Add(sis);
            }
            return Seisms;
        }
    }
    public class SeismProperties
    {
        public float? mag { get; set; } = 0;
        public string place { get; set; } = "";
        public long time { get; set; } = 0;
        public int sig { get; set; } = 0;
        public float? dmin { get; set; } = 0;
    }

    public class SeismGeometry
    {
        [JsonProperty("coordinates")]
        public float[] coordinates { get; set; } = { 0, 0, 0 };
    }

    public class SeismHttpData
    {
        [JsonProperty("properties")]
        public SeismProperties properties { get; set; }
        [JsonProperty("geometry")]
        public SeismGeometry geometry { get; set; }
        [JsonProperty("id")]
        public string id { get; set; } = "";
    }

    public class SeismsData
    {
        public string type { get; set; } = "";
        [JsonProperty("features")]
        public SeismHttpData[] features { get; set; }
    }
}
