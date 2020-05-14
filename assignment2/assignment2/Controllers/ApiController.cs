using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment2.Data;
using assignment2.Models;
using assignment2.Services;
using Microsoft.AspNetCore.Mvc;

namespace assignment2.Controllers
{
    [Route("api/Appointments")]
    [ApiController]
    [Route("[controller]")]
    public class ApiController : Controller
    {
        //modify so that it returns from this project
        private AppointmentService _service;
        public ApiController(AutoServiceDbContext context)
        {
            _service = new AppointmentService(context);
        }

        public List<Appointment> Get()
        {
            return _service.Get().ToList();
        }
    }
}