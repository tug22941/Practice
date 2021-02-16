using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        [HttpGet]
        [HttpGet("GetCar")]
        public string Get()
        {
            return "Web API - HTTP Get executed!";
        }

        [HttpGet("FindCarByID/{carID}/{dealerID}")]
        public string GetCarByID(int carID, int dealerID)
        {
            return "Web API - HTTP Get with carID =" + carID + " dealerID = " + dealerID; 
        }
    }
}