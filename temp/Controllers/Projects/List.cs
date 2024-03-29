using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using temp.Domain;

namespace temp.Controllers.Projects
{
    public class List
    {
        public class Query : IRequest<List<Project>> { }

        public class Handler : IRequestHandler<Query, List<Project>>
        {
            private readonly tempContext _context;
            public Handler(tempContext context)
            {
                _context = context;
            }

            public async Task<List<Project>> Handle(Query request,
                CancellationToken cancellationToken)
            {
                var project = await _context.Projects.ToListAsync();

                return project;
            }
        }
    }
}