using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_Api.Models;

namespace Web_Api.Controllers
{
    public class TasksController : ApiController
    {
        Task[] tasks = new Task[] 
        { 
            new Task { Id = 1, UserId = 1, CompanyId = 1, PickupAddress = "Moddin" }, 
            new Task { Id = 2, UserId = 1, CompanyId = 1, PickupAddress = "Tel Aviv" }, 
            new Task { Id = 3, UserId = 1, CompanyId = 1, PickupAddress = "Jerusalem" } 
        };

        public IEnumerable<Task> GetAllTasks()
        {
            return tasks;
        }

        public Task GetTaskById(int id)
        {
            var task = tasks.FirstOrDefault((p) => p.Id == id);
            if (task == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return task;
        }

        public IEnumerable<Task> GetTasksByUser(int userId)
        {
            return tasks.Where( (p) => int.Equals(p.UserId, userId));
        }


        //for test
        public IEnumerable<Task> GetTasksByAddress(string address)
        {
            return tasks.Where((p) => string.Equals(p.PickupAddress, address, StringComparison.OrdinalIgnoreCase));
        }
    }
}
