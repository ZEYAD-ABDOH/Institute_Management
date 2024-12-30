using Client.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class StudentController : Controller
    {


       public async Task<IActionResult> Index()
        {
            List<Student> students = new List<Student>();
            using (var httpClient = new HttpClient())
            {
                using (var res=await httpClient.GetAsync("https://localhost:7034/api/Students"))
                {
                    if (res.IsSuccessStatusCode)
                    {
                        var datatrans = await res.Content.ReadAsStringAsync();
                        students = JsonConvert.DeserializeObject<List<Student>>(datatrans);
                    }
                }
                return View(students);
            }

        }


        public IActionResult Create()
        {
            return View();
        }
    }


   
}
