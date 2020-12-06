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
                var project = await _context.Project.ToListAsync();

                return project;
            }
        }
    }
}

// testing////////////////////

// using System.Collections.Generic;
// using System.Linq;
// using System.Threading;
// using System.Threading.Tasks;
// using MediatR;
// using Microsoft.EntityFrameworkCore;
// using temp.Domain;

// namespace temp.Controllers
// {
//     public class List : PagedModel<temp.Areas.ThingsA.Detail>
//     {
//         // Input

//         public class Query : IRequest<Result>
//         {
//             // Filters - query parameters
//             public string Name { get; set; }
//             public int? ThingBId { get; set; }
//             public int? ThingCId { get; set; }
//             public int? OwnerId { get; set; }
//         }

//         // Output
//         public class Result
//         {
//             // Filters - query parameters
//             public string Name { get; set; }
//             public int? ThingBId { get; set; }
//             public int? ThingCId { get; set; }
//             public int? OwnerId { get; set; }

//             public List<ThingA> ThingAs { get; set; } = new List<ThingA>();

//             public class ThingA
//             {
//                 public int Id { get; set; }
//                 public string Name { get; set; }

//                 public int? ThingBId { get; set; }
//                 public string ThingBName { get; set; }

//                 public int? ThingCId { get; set; }
//                 public string ThingCName { get; set; }

//                 public int OwnerId { get; set; }
//                 public string OwnerAlias { get; set; }
//             }
//         }

//         public class Handler : IRequestHandler<Query, Result>
//         {
//             private readonly tempContext _context;
//             private readonly ICache _cache;

//             public Handler(tempContext context, ICache cache)
//             {
//                 _context = context;
//                 _cache = cache;
//             }

//             public async Task<List<ThingA>> Handle(Query request,
//                 CancellationToken cancellationToken)
//             {
//                                                 // Filters - query parameters
//                 var result = new Result { Name = request.Name, 
//                 ThingBId = request.ThingBId,
//                 ThingCId = request.ThingCId,
//                 OwnerId = request.OwnerId };
//                 // Filters - query parameters
//                 var thingAs = _context.ThingA.AsQueryable();
//                 // Filters
//                 // 1.Sample Advanced filter through search
//                  if (PagedModel.AdvancedFilter)
//                  {
//                     // Filters - query parameters
//                     if (request.Name != null)
//                     {
//                         thingAs = thingAs.Where(b => b.Name == request.Name);
//                     }
//                     // Filters - query parameters
//                     if (request.ThingBId != null)
//                     {
//                         thingAs = thingAs.Where(c => c.ThingBId == request.ThingBId);
//                     }

//                     if (request.ThingCId != null)
//                     {
//                         thingAs = thingAs.Where(c => c.ThingCId == request.ThingCId);
//                     }

//                     if (request.OwnerId != null)
//                     {
//                         thingAs = thingAs.Where(c => c.OwnerId == request.OwnerId.Value);
//                     }
//                  }
//                //  Normal filter through dropdown for AllThingsA, recentlyviewed, allMyThingsA
//                 else
//                 {
//                     switch (PagedModel.Filter)
//                     {
//                         case 1: request = request.Where(c => _viewedService.GetIds("ThingA").Contains(c.Id)); break;
//                         case 2: request = request.Where(c => c.OwnerId == _currentUser.Id); break;
//                     }
//                 }

//                 foreach (var thingA in thingAs)
//                 {
//                     var thingsB = _cache.ThingsB[thingA.ThingBId];
//                     var thingsC = _cache.ThingsC[thingA.ThingCId];

//                     // ** Data Mapping pattern

//                     result.ThingA.Add(new Result.ThingA
//                     {
//                         Id = thingA.Id,
//                         BookingDate = thingA.BookingDate.ToString("MM/dd/yyyy"),
//                         BookingNumber = thingA.BookingNumber,
//                         TravelerId = thingA.TravelerId,
//                         Traveler = traveler.Name,
//                         FlightId = booking.FlightId,
//                         Flight = flight.FlightNumber,
//                         From = flight.From,
//                         To = flight.To,
//                         Date = flight.Departure.ToString("dd MMM yyyy"),
//                         Seat = seat.Number

//                                         public int Id { get; set; }
//                 public string Name { get; set; }

//                 public int? ThingBId { get; set; }
//                 public string ThingBName { get; set; }

//                 public int? ThingCId { get; set; }
//                 public string ThingCName { get; set; }

//                 public int OwnerId { get; set; }
//                 public string OwnerAlias { get; set; }
//             }
//                     });
//                 }

//                 return result;
//             }
//         }
//     }
// }

// testing start smaller////////////

// using System.Collections.Generic;
// using System.Linq;
// using System.Threading;
// using System.Threading.Tasks;
// using MediatR;
// using Microsoft.EntityFrameworkCore;
// using temp.Domain;

// namespace temp.Controllers
// {
//     public class List
//     {
//         // Input

//         public class Query : IRequest<Result> { 
//             // Filters - query parameters\
//             public int? Filter { get; set; }
//         }

//         // Output

//         public class Result
//         {
//             // Filters - query parameters\
//             public int? Filter { get; set; }

//             public List<ThingA> ThingAs { get; set; } = new List<ThingA>();

//             public class ThingA
//             {
//                 public int Id { get; set; }
//                // public string Name { get; set; }
//                 public int ThingBId { get; set; }
//                 public int ThingCId { get; set; }
//                 public int OwnerId { get; set; }
//             }
//         }

//         // Handler

//         public class Handler : RequestHandler<Query, Result>
//         {
//             private readonly tempContext _context;
//             private readonly ICache _cache;

//             public Handler(tempContext context, ICache cache)
//             {
//                 _context = context;
//                 _cache = cache;
//             }

//             protected override Result Handle(Query request)
//             {
//                 // Filters - query parameters
//                 var result = new Result { Filter = request.Filter };
//                 // Filters - query parameters

//                 var thingAs = _context.ThingA.AsQueryable();
//                 // Filters - query parameters
//                 if (request.Filter != null)
//                 {
//                     foreach (var thingA in thingAs)
//                     {
//                         result.ThingAs.Add(new Result.ThingA
//                         {
//                             Id = thingA.Id,
//                             ThingBId = 2,
//                             ThingCId = 5,
//                             OwnerId = 3
//                         });
//                     }
//                 }

//                 return result;
//             }
//         }
//     }
// }