using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using temp.Domain;

namespace temp.Controllers.Users
{
    public class List
    {
        public class Query : IRequest<List<User>> { }

        public class Handler : IRequestHandler<Query, List<User>>
        {
            private readonly tempContext _context;
            public Handler(tempContext context)
            {
                _context = context;
            }

            public async Task<List<User>> Handle(Query request,
                CancellationToken cancellationToken)
            {
                var user = await _context.User.ToListAsync();

                return user;
            }
        }
    }
}