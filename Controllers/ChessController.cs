using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChessController : ControllerBase
    {
        
        [HttpGet]
         public IActionResult GetPlayers()
         {
             return Ok("Test Subject ");
         }


         [HttpGet]
         [Route("GetStatus")]
         public  IActionResult GetStatus()
         {
             
             var result = new {
                 name="Hemanth",
                 designation="SE"
             };

             IList<Students> student = new List<Students>()
             {

                 new Students(){ID=1,Name="Raj"},
                 new Students(){ ID = 2, Name="Standard 2"},
                  new Students(){ ID = 3, Name="Standard 3"}
             };

             var StudentID = student.Where(p=>p.ID>1).Select(s=>s.Name);

             return  Ok(StudentID);
         }



    }
}