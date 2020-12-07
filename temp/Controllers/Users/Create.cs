// using System;
// using System.Collections.Generic;
// using System.Threading;
// using System.Threading.Tasks;
// using MediatR;
// using temp.Domain;

// namespace temp.Controllers.Users
// {
//     public class Create
//     {
//         public class Command : IRequest
//         {
//             public int Id { get; set; }
//             public string FirstName { get; set; }
//             public string LastName { get; set; }
//             public string Email { get; set; }
//             public string Alias { get; set; }
//             public string City { get; set; }
//             public string Country { get; set; }
//             public string EmployeeNumber { get; set; }
//             public string Department { get; set; }
//             public DateTime? LastLoginDate { get; set; }
//             public int TotalThingsA { get; set; }
//             public int TotalThingsB { get; set; }
//             public int TotalThingsC { get; set; }
//             public int TotalThingsD { get; set; }
//             public int TotalThingsE { get; set; }

//             public string Role { get; set; }
//             public string IdentityId { get; set; }
//             public string IdentityName { get; set; }
//             public DateTime CreatedDate { get; set; }
//             public string ActivationCode { get; set; }
//             public DateTime? ActivationDate { get; set; }
//             public string ResetCode { get; set; }
//             public DateTime? ResetDate { get; set; }
//             public string AppKey { get; set; }
//             public string AppSecret { get; set; }
//             public DateTime CreatedOn { get; set; }
//             public int? CreatedBy { get; set; }
//             public DateTime ChangedOn { get; set; }
//             public int? ChangedBy { get; set; }
//             public DateTime? DeletedOn { get; set; }
//             public int? DeletedBy { get; set; }
//             public bool IsDeleted { get; set; }

//             public virtual ICollection<Error> Error { get; set; }
//             public virtual ICollection<Login> Login { get; set; }
//             public virtual ICollection<ThingA> ThingA { get; set; }
//             public virtual ICollection<ThingB> ThingB { get; set; }
//             public virtual ICollection<ThingC> ThingC { get; set; }
//             public virtual ICollection<ThingD> ThingD { get; set; }
//             public virtual ICollection<ThingE> ThingE { get; set; }
//             public virtual ICollection<Viewed> Viewed { get; set; }
//         }

//         public class Handler : IRequestHandler<Command>
//         {
//             private readonly tempContext _context;
//             public Handler(tempContext context)
//             {
//                 _context = context;
//             }

//             public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
//             {
//                 var user = new User
//                 {
//                     Id = request.Id,
//                     FirstName = request.FirstName,
//                     LastName = request.LastName,
//                     Email = request.Email,
//                     Alias = request.Alias,
//                     City = request.City,
//                     Country = request.Country,
//                     EmployeeNumber = request.EmployeeNumber,
//                     Department = request.Department,
//                     LastLoginDate = request.LastLoginDate,
//                     TotalThingsA = request.TotalThingsA,
//                     TotalThingsB = request.TotalThingsB,
//                     TotalThingsC = request.TotalThingsC,
//                     TotalThingsD = request.TotalThingsD,
//                     TotalThingsE = request.TotalThingsE,
//                     Role = request.Role,
//                     IdentityId = request.IdentityId,
//                     IdentityName = request.IdentityName,
//                     CreatedDate = request.CreatedDate,
//                     ActivationCode = request.ActivationCode,
//                     ActivationDate = request.ActivationDate,
//                     ResetCode = request.ResetCode,
//                     ResetDate = request.ResetDate,
//                     AppKey = request.AppKey,
//                     AppSecret = request.AppSecret,
//                     CreatedOn = request.CreatedOn,
//                     CreatedBy = request.CreatedBy,
//                     ChangedOn = request.ChangedOn,
//                     ChangedBy = request.ChangedBy,
//                     DeletedOn = request.DeletedOn,
//                     DeletedBy = request.DeletedBy,
//                     IsDeleted = request.IsDeleted,
//                     Error = request.Error,
//                     Login = request.Login,
//                     ThingA = request.ThingA,
//                     ThingB = request.ThingB,
//                     ThingC = request.ThingC,
//                     ThingD = request.ThingD,
//                     ThingE = request.ThingE,
//                     Viewed = request.Viewed
//                 };

//                 _context.User.Add(user);
//                 var success = await _context.SaveChangesAsync() > 0;

//                 if (success) return Unit.Value;

//                 throw new Exception("Problem saving changes");
//             }
//         }
//     }
// }
