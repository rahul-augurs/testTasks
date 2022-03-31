using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test_Task_Domain;
using Test_Task_DTO.UserMaster;

namespace Test_Task_Service
{
    public class APICall
    {
       
        public static List<UserMasterViewModel> Get()
        {

            List<UserMasterViewModel> users = new List<UserMasterViewModel>();
            
            var client = new HttpClient();
            var task = client.GetAsync("https://gorest.co.in/public/v2/users")
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  users = JsonConvert.DeserializeObject<List<UserMasterViewModel>>(jsonString.Result);

              });
            task.Wait();
            return users;
        }

    }
}
