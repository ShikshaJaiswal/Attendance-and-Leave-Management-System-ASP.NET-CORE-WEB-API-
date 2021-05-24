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
    public class ProjectAllocationService
    {
        public List<TrprojectAllocation> GetProjectAllocationDetails()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType); //setting content type
                HttpResponseMessage response = client.GetAsync("api/ProjectAllocation/GetProjectAllocationDetails").Result;
                List<TrprojectAllocation> list = JsonConvert.DeserializeObject<List<TrprojectAllocation>>(response.Content.ReadAsStringAsync().Result);
                return list;
            }
        }
        public TrprojectAllocation GetProjectAllocationDetailsById(int AllocationId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType); //setting content type
                HttpResponseMessage response = client.GetAsync("api/ProjectAllocation/GetProjectAllocationDetailsById/" + AllocationId).Result;
                TrprojectAllocation trprojectAllocation = JsonConvert.DeserializeObject<TrprojectAllocation>(response.Content.ReadAsStringAsync().Result);
                return trprojectAllocation;
            }
        }
        //public List<TrprojectAllocation> EmployeeMenu(long EmployeeId)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("https://localhost:44338/");
        //        MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
        //        client.DefaultRequestHeaders.Accept.Add(contentType); //setting content type
        //        HttpResponseMessage response = client.GetAsync("api/ProjectAllocation/EmployeeMenu/" + EmployeeId).Result;
        //        List<TrprojectAllocation> list = JsonConvert.DeserializeObject<List<TrprojectAllocation>>(response.Content.ReadAsStringAsync().Result);
        //        return list;
        //    }
        //}
        public void AddAllocateProjectAllocation(TrprojectAllocation trProjectAllocation)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                var jsonData = new StringContent(JsonConvert.SerializeObject(trProjectAllocation),
                System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("api/ProjectAllocation/AllocateProjectAllocation", jsonData).Result;
            }
        }

        public void EditProjectAllocationDetails(TrprojectAllocation trprojectAllocation)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                var jsonData = new StringContent(JsonConvert.SerializeObject(trprojectAllocation),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync("api/ProjectAllocation/UpdateProjectAllocation", jsonData).Result;
            }
        }
        public void DeleteProjectAllocationDetails(int AllocationId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                HttpResponseMessage response = client.DeleteAsync("api/ProjectAllocation/DeleteProjectAllocation/" + AllocationId).Result;

            }
        }
    }
}
