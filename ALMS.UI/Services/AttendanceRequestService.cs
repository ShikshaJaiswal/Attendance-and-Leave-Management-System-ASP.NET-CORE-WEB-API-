using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.UI.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ALMS.UI.Services
{
    public class AttendanceRequestService
    {
        public List<TrattendanceDetail> GetTrAttendanceDetails()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType); //setting content type
                HttpResponseMessage response = client.GetAsync("api/AttendanceRequest/GetAllAttendance").Result;
                List<TrattendanceDetail> list = JsonConvert.DeserializeObject<List<TrattendanceDetail>>(response.Content.ReadAsStringAsync().Result);
                return list;
            }
        }

        public TrattendanceDetail GetByAttendanceId(int AttendanceId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("api/AttendanceRequest/GetByAttendanceId/" + AttendanceId).Result;
                TrattendanceDetail trAttendanceDetail = JsonConvert.DeserializeObject<TrattendanceDetail>(response.Content.ReadAsStringAsync().Result);
                return trAttendanceDetail;
            }
        }

        public void AddAttendanceDetail(TrattendanceDetail trAttendanceDetail)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                var jsonData = new StringContent(JsonConvert.SerializeObject(trAttendanceDetail),
                System.Text.Encoding.UTF8, "Application/json");
                HttpResponseMessage response = client.PostAsync("api/AttendanceRequest/AddAttendanceRequest", jsonData).Result;

            }
        }

        public void UpdateAttendanceDetail(TrattendanceDetail trAttendanceDetail)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                var jsonData = new StringContent(JsonConvert.SerializeObject(trAttendanceDetail),
                System.Text.Encoding.UTF8, "Application/json");
                HttpResponseMessage response = client.PutAsync("api/AttendanceRequest/UpdateAttendanceRequest", jsonData).Result;

            }
        }

        public void DeleteAttendanceDetail(int AttendanceId)
        {
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://localhost:44308/");

                HttpResponseMessage response = client.GetAsync("api/AttendanceRequest/GetByAttendanceId/" + AttendanceId).Result;
                TrattendanceDetail trAttendanceDetail = JsonConvert.DeserializeObject<TrattendanceDetail>(response.Content.ReadAsStringAsync().Result);

            }
        }
    }
}
