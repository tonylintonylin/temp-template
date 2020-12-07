using System.Collections.Generic;
using System.Linq;
using MediatR;
using Microsoft.EntityFrameworkCore;
using temp.Domain;

namespace temp.Controllers.ThingsA
{
    public class List
    {
        // Input
        public class Query : IRequest<Result> { 
            // input query filter params
            public string Name { get; set; }
            public string Sort { get; set; }
            public int Filter { get; set; }
            public bool AdvancedFilter { get; set; }
            public int? ThingBId { get; set; }
            public int? ThingCId { get; set; }
            public int? OwnerId { get; set; }
        }

        // protected IQueryable<ThingA> FilterQuery(int? Filter, IQueryable<ThingA> queryable) { 
        //     switch (Filter)
        //     {
        //         case 1: queryable = queryable.Where(c => _viewedService.GetIds("ThingA").Contains(c.Id)); break;
        //         case 2: queryable = queryable.Where(c => c.OwnerId == _currentUser.Id); break;
        //     }
        //     return queryable;
        // }
        
        // need to clean this part up later and refactor to using another class
        // Output
        public class Result : PagedModel<Areas.ThingsA.Detail>
        {
            // query filter params?
            public string Name { get; set; }
            // public int? Filter { get; set; }
            // public bool AdvancedFilter { get; set; }
            public int? ThingBId { get; set; }
            public int? ThingCId { get; set; }
            public int? OwnerId { get; set; }

            // list of the thingAs
            public List<ThingA> ThingAs { get; set; } = new List<ThingA>();
            
            // a single ThingA
            public class ThingA
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string ThingBName { get; set; }
                public string ThingCName { get; set; }
                public string Text { get; set; }
                public string Lookup { get; set; }
                public string OwnerAlias { get; set; }
                // public bool Filter { get; set; }
                // public bool AdvancedFilter { get; set; }
                public int? ThingBId { get; set; }
                public int? ThingCId { get; set; }
                public int? OwnerId { get; set; }
            }

            //temp.Domain.ThingA and result.thingA is confusing right now
            public IQueryable<temp.Domain.ThingA> FilterQuery(int? Filter, IQueryable<temp.Domain.ThingA> queryable) { 
                switch (Filter)
                {
                    //case 1 working
                    case 1: queryable = queryable.Where(c => _viewedService.GetIds("ThingA").Contains(c.Id)); break;
                    //case 2 working, id 30 is not danderson
                    case 2: queryable = queryable.Where(c => c.OwnerId == _currentUser.Id); break;
                    //case 3 working
                    case 3: queryable = queryable.OrderByDescending(c => c.Id); break;
                }
                return queryable;
            }

            public IQueryable<temp.Domain.ThingA> SortQuery(IQueryable<temp.Domain.ThingA> queryable)
            {
                queryable = Sort switch
                {
                    "Id" => queryable.OrderBy(c => c.Id),
                    "-Id" => queryable.OrderByDescending(c => c.Id),
                    "Name" => queryable.OrderBy(c => c.Name),
                    "-Name" => queryable.OrderByDescending(c => c.Name),
                    "ThingBName" => queryable.OrderBy(c => c.ThingBName),
                    "-ThingBName" => queryable.OrderByDescending(c => c.ThingBName),
                    "ThingCName" => queryable.OrderBy(c => c.ThingCName),
                    "-ThingCName" => queryable.OrderByDescending(c => c.ThingCName),
                    "Text" => queryable.OrderBy(c => c.Text),
                    "-Text" => queryable.OrderByDescending(c => c.Text),
                    "Lookup" => queryable.OrderBy(c => c.Lookup),
                    "-Lookup" => queryable.OrderByDescending(c => c.Lookup),
                    "TotalThingsE" => queryable.OrderBy(c => c.TotalThingsE),
                    "-TotalThingsE" => queryable.OrderByDescending(c => c.TotalThingsE),
                    "OwnerAlias" => queryable.OrderBy(c => c.OwnerAlias),
                    "-OwnerAlias" => queryable.OrderByDescending(c => c.OwnerAlias),
                    _ => queryable.OrderByDescending(c => c.Id),
                };

                return queryable;
            }
        }

        // spliting up handler to advance filter,filter,sort,page
        public class Handler : RequestHandler<Query, Result>
        {
            private readonly tempContext _context;

            public Handler(tempContext context)
            {
                _context = context;
            }

            protected override Result Handle(Query request)
            {
                // bring in query params
                var result = new Result { 
                    Filter = request.Filter,
                    Sort = string.IsNullOrEmpty(request.Sort) ? "-" : request.Sort,
                    AdvancedFilter = request.AdvancedFilter, 
                    Name = request.Name,
                    ThingBId = request.ThingBId,
                    ThingCId = request.ThingCId,
                    OwnerId = request.OwnerId,
                };

                // get all ThingAs
                var queryable = _context.ThingA.AsQueryable();

                // check advancedfilter query param first
                if (request.AdvancedFilter)
                {
                    if (request.Name != null)
                    {
                        //search, not filter
                        queryable = queryable.Where(c => c.Name.Contains(request.Name));
                    }

                    if (request.ThingBId != null)
                    {
                        //filter, not search
                        queryable = queryable.Where(c => c.ThingBId == request.ThingBId);
                    }

                    if (request.ThingCId != null)
                    {
                        queryable = queryable.Where(c => c.ThingCId == request.ThingCId);
                    }

                    if (request.OwnerId != null)
                    {
                        queryable = queryable.Where(c => c.OwnerId == request.OwnerId.Value);
                    }
                }
                // else
                // {
                // switch (Filter)
                // {
                //     case 1: queryable = queryable.Where(c => _viewedService.GetIds("ThingA").Contains(c.Id)); break;
                //     case 2: queryable = queryable.Where(c => c.OwnerId == _currentUser.Id); break;
                // }
                // }

                // queryable = FilterQuery(request.Filter, queryable);
                else {
                    queryable = result.FilterQuery(request.Filter, queryable);
                } 
                if(!string.IsNullOrEmpty(request.Sort))
                {
                    queryable = result.SortQuery(queryable);
                }

                foreach (var query in queryable)
                {
                    // var flight = _cache.Flights[booking.FlightId];
                    // var traveler = _cache.Travelers[booking.TravelerId];
                    // var seat = _cache.Seats[booking.SeatId];

                    // ** Data Mapping pattern

                    // Add all the ThingAs still left in queryable after filters
                    result.ThingAs.Add(new Result.ThingA
                    {
                        Id = query.Id,
                        Name = query.Name,
                        ThingBName = query.ThingBName,
                        ThingCName = query.ThingCName,
                        Text = query.Text,
                        Lookup = query.Lookup,
                        ThingBId = query.ThingBId,
                        ThingCId = query.ThingCId,
                        OwnerId = query.OwnerId,
                        OwnerAlias = query.OwnerAlias,
                    });
                }

                //pagination happens at the end

                // var thingA = await queryable
                //     .Skip(1)
                //     .Take(5).ToListAsync();

                return result;
            }
        }
    }
}