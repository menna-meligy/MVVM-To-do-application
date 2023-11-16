using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TodoXaml.Models;

namespace TodoXaml.Services
{
    public class TodoService : TodoServiceApi
    {
        public TodoService()
        : base("https://bmetodo.azurewebsites.net/", new HttpClient())
        {
        }
    }
}
