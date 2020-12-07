using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using temp.Domain;

namespace temp.Controllers.Issues
{
    public class List
    {
        public class Query : IRequest<List<Issue>> { }

        public class Handler : IRequestHandler<Query, List<Issue>>
        {
            private readonly tempContext _context;
            public Handler(tempContext context)
            {
                _context = context;
            }

            public async Task<List<Issue>> Handle(Query request,
                CancellationToken cancellationToken)
            {
                var issue = await _context.Issues.ToListAsync();

                return issue;
            }
        }
    }
}