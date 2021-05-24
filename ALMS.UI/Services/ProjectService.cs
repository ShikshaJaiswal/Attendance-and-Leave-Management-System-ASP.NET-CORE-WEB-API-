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
    public class ProjectService
    {
        public List<MsprojectDetail> GetProject()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType); //setting content type
                HttpResponseMessage response = client.GetAsync("api/Project/GetAllProject").Result;
                List<MsprojectDetail> list = JsonConvert.DeserializeObject<List<MsprojectDetail>>(response.Content.ReadAsStringAsync().Result);
                return list;
            }
        }
        public MsprojectDetail GetByProjectId(int ProjectId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType); //setting content type
                HttpResponseMessage response = client.GetAsync("api/Project/GetByProjectId/" + ProjectId).Result;
                MsprojectDetail project = JsonConvert.DeserializeObject<MsprojectDetail>(response.Content.ReadAsStringAsync().Result);
                return project;
            }
        }
        public void AddProject(MsprojectDetail project)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                var jsonData = new StringContent(JsonConvert.SerializeObject(project),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("api/Project/AddProject", jsonData).Result;
                //return response.Content.ReadAsStringAsync().Result;
            }
        }
        public void DeleteProject(int Projectid)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                HttpResponseMessage response = client.DeleteAsync("api/Project/DeleteProject/" + Projectid).Result;
                //return response.Content.ReadAsStringAsync().Result;
            }
        }
        public void UpdateProject(MsprojectDetail project)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44308/");
                //convert Product data into Json
                var jsonData = new StringContent(JsonConvert.SerializeObject(project),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync("api/Project/UpdateProject", jsonData).Result;
                //return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
