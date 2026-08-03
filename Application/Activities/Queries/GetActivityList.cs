using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;

namespace Application.Activities.Queries
{
    public class GetActivityList
    {
        public class Query : IRequest<List<Activity>> { }

        public class Handler(AppDbContext context) : IRequestHandler<Query, List<Activity>>
        {
           
            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                
                return await context.Activities.ToListAsync(cancellationToken);
            }
        }
    }
}