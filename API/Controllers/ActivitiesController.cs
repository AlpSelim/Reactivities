using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController(AppDbContext context) : BaseApiController
    {
      [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
            {
              return await context.Activities.ToListAsync();    
            }
        [HttpGet("{id}")]    
        public async Task<ActionResult<Activity>> GetActivityDetail(string id)
        {
            var activity = context.Activities.FindAsync(id);
            if (activity == null)
            {
                return NotFound();
            }
            return await activity;
        }
    }
}
