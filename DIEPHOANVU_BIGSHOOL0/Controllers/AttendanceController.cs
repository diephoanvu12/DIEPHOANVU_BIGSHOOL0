using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DIEPHOANVU_BIGSHOOL0.Models;
using Microsoft.AspNet.Identity;

namespace DIEPHOANVU_BIGSHOOL0.Controllers
{   
    [Authorize]
    public class AttendanceController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendanceController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend([FromBody] int courseId)
        {
            var attendance = new Attendance
            {
                CourseId = courseId,
                AttendeeId = User.Identity.GetUserId()
            };
            return Ok();
        }
    }
}
