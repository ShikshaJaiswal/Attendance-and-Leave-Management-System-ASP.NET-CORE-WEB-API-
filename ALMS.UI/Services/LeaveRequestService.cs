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
    public class LeaveRequestService
    {
        public List<TrleaveRequestDetail> GetLeaveRequestDetails()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType); //setting content type
                HttpResponseMessage response = client.GetAsync("api/LeaveRequest/GetAllLeave").Result;
                List<TrleaveRequestDetail> list = JsonConvert.DeserializeObject<List<TrleaveRequestDetail>>(response.Content.ReadAsStringAsync().Result);
                return list;
            }
        }
        public TrleaveRequestDetail GetByLeaveId(int LeaveRequestId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType); //setting content type
                HttpResponseMessage response = client.GetAsync("api/LeaveRequest/GetByLeaveId/" + LeaveRequestId).Result;
                TrleaveRequestDetail trLeaveRequestDetail = JsonConvert.DeserializeObject<TrleaveRequestDetail>(response.Content.ReadAsStringAsync().Result);
                return trLeaveRequestDetail;
            }
        }
        public void AddLeaveRequest(TrleaveRequestDetail trLeaveRequestDetail)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                var jsonData = new StringContent(JsonConvert.SerializeObject(trLeaveRequestDetail),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("api/LeaveRequest/AddLeaveRequest", jsonData).Result;
                //return response.Content.ReadAsStringAsync().Result;
            }
        }
        public void DeleteLeaveRequest(int LeaveRequestId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                HttpResponseMessage response = client.DeleteAsync("api/LeaveRequest/DeleteLeaveRequest/" + LeaveRequestId).Result;
                //return response.Content.ReadAsStringAsync().Result;
            }
        }
        public void UpdateLeaveRequest(TrleaveRequestDetail trLeaveRequestDetail)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                //convert Product data into Json
                var jsonData = new StringContent(JsonConvert.SerializeObject(trLeaveRequestDetail),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync("api/LeaveRequest/UpdateLeaveRequest", jsonData).Result;
                //return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
