using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using temp.Domain;

namespace temp.Controllers.Projects
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            //change title later
            public string Name { get; set; }
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
                var project = await _context.Projects.FindAsync(request.Id);    

                if (project == null)
                    throw new Exception("Could not find proj");

                project.Name = request.Name ?? project.Name;            
                project.Description = request.Description ?? project.Description;                     

                var success = await _context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new Exception("Problem saving changes");
            }
        }
    }
}