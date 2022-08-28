using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DevIndoAPI.Models;
using DevIndoAPI.Services;
using Microsoft.AspNetCore.Cors;

namespace DevIndoAPI.Controllers
{
    public class ActivityController : Controller
    {
        [HttpGet("GetActivity")]
        public List<Activity> GetActivity()
        {
            Response.Headers.Add("Access-Control-Allow-Headers", "*");
            return ActivityServices.GetAllActivity();
        }

        [HttpGet("GetVoting")]
        public List<ActiveRural> GetVotings()
        {
            Response.Headers.Add("Access-Control-Allow-Headers", "*");
            return ActivityServices.GetActiveRurals();
        }

        [HttpGet("GetRurals")]
        public List<ActiveRural> GetRurals()
        {
            return ActivityServices.GetActiveRurals();
        }

        [HttpPost("AddActivity")]
        public List<Activity> AddActivity(Activity _activity)
        {
            Response.Headers.Add("Access-Control-Allow-Headers", "*");
            ActivityServices.AddActivity(_activity);
            return ActivityServices.GetAllActivity();
        }

    }
}
