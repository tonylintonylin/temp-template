using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using temp.Domain;

namespace temp.Controllers.Projects
{
    public class Create
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly tempContext _context;
            public Handler(tempContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var project = new Project
                {
                    Id = request.Id,
                    Title = request.Title,
                    Description = request.Description,
                };

                _context.Projects.Add(project);
                var success = await _context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new Exception("Problem saving changes");
            }
        }
    }
}