using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevEdu.Data.Storages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevEdu.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        CourseStorage storage;

        public CourseController()
        {
            storage = new CourseStorage();
        }
    }
}