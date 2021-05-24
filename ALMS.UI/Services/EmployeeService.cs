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
    public class EmployeeService
    {
        public List<MsemployeeDetail> GetEmployee()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType); //setting content type
                HttpResponseMessage response = client.GetAsync("api/Employee/GetAllEmployee").Result;
                List<MsemployeeDetail> list = JsonConvert.DeserializeObject<List<MsemployeeDetail>>(response.Content.ReadAsStringAsync().Result);
                return list;
            }
        }
        public MsemployeeDetail GetByEmployeeId(long EmployeeId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType); //setting content type
                HttpResponseMessage response = client.GetAsync("api/Employee/GetByEmployeeId/" + EmployeeId).Result;
                MsemployeeDetail msEmployeeDetail = JsonConvert.DeserializeObject<MsemployeeDetail>(response.Content.ReadAsStringAsync().Result);
                return msEmployeeDetail;
            }
        }
        public void AddEmployee(MsemployeeDetail msEmployeeDetail)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                var jsonData = new StringContent(JsonConvert.SerializeObject(msEmployeeDetail),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("api/Employee/AddEmployee", jsonData).Result;
                //return response.Content.ReadAsStringAsync().Result;
            }
        }

       

        public void DeleteEmployee(MsemployeeDetail msemployeeDetail)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                HttpResponseMessage response = client.DeleteAsync("api/Employee/DeleteEmployee/"+ msemployeeDetail.EmployeeId).Result;
                //return response.Content.ReadAsStringAsync().Result;
            }
        }
        public void UpdateEmployee(MsemployeeDetail msEmployeeDetail)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                //convert Product data into Json
                var jsonData = new StringContent(JsonConvert.SerializeObject(msEmployeeDetail),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync("api/Employee/UpdateEmployee", jsonData).Result;
                //return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
