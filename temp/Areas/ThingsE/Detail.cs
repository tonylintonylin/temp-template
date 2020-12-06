﻿using temp.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace temp.Areas.ThingsE
{
    public class Detail : BaseModel
    {
        #region Data

        public int Id { get; set; }
        public string Name { get; set; }

        public int? ThingAId { get; set; }
        public string ThingAName { get; set; }
        public int? ThingDId { get; set; }
        public string ThingDName { get; set; }

        public string Text { get; set; }
        public string Lookup { get; set; }
        public string Money { get; set; }
        public string DateTime { get; set; }
        public string Status { get; set; }
        public int? Integer { get; set; }
        public bool? Boolean { get; set; }
        public string LongText { get; set; }

        public int? OwnerId { get; set; }
        public string OwnerAlias { get; set; }
        public string OwnerName { get; set; }

        #endregion

        #region Handlers

        public override async Task<IActionResult> GetAsync()
        {
            var thingE = await _db.ThingE.SingleOrDefaultAsync(c => c.Id == Id);
            _mapper.Map(thingE, this);
            
            await _viewedService.Log(Id, "ThingE", thingE.Name);

            return View(this);
        }

        #endregion

        #region Mapping

        public class MapperProfile : BaseProfile
        {
            public MapperProfile()
            {
                CreateMap<ThingE, Detail>()
                  .Map(dest => dest.Money, opt => opt.MapFrom(src => src.Money.ToCurrency()))
                  .Map(dest => dest.DateTime, opt => opt.MapFrom(src => src.DateTime.ToDate()))
                  .Map(dest => dest.OwnerName, opt => opt.MapFrom(src => _cache.Users[src.OwnerId].Name));
            }
        }

        #endregion
    }
}
