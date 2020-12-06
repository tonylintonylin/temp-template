﻿using temp.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace temp.Areas.ThingsB
{
    public class Edit : BaseModel
    {
        #region Data

        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string Text { get; set; }
        public string Lookup { get; set; }
        public decimal? Money { get; set; }
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
            if (Id == 0)
            {
                OwnerId = _currentUser.Id;
                OwnerName = _currentUser.Name;
            }
            else
            {
                _mapper.Map(await _db.ThingB.SingleOrDefaultAsync(c => c.Id == Id), this);
            }

            return View(this);
        }

        public override async Task<IActionResult> PostAsync()
        {
            if (!ModelState.IsValid) return View(this);

            if (Id == 0) // new item
            {
                var thingB = _mapper.Map<ThingB>(this);

                _db.ThingB.Add(thingB);
                await _db.SaveChangesAsync();

                await SettleInsertAsync(thingB);
            }
            else
            {
                var thingB = await _db.ThingB.SingleOrDefaultAsync(c => c.Id == Id); ;
                var originalThingB = new OriginalThingB(thingB);

                _mapper.Map(this, thingB);

                _db.ThingB.Update(thingB);
                await _db.SaveChangesAsync();

                await SettleUpdateAsync(originalThingB, thingB);
            }

            return LocalRedirect(Referer ?? "/thingbs");
        }

        #endregion

        #region Helpers

        private async Task SettleInsertAsync(ThingB thingB)
        {
            _cache.MergeThingB(thingB);

            await _rollup.RollupUserAsync(thingB.OwnerId);
        }

        private async Task SettleUpdateAsync(OriginalThingB original, ThingB thingB)
        {
            _cache.MergeThingB(thingB);


            if (original.OwnerId != thingB.OwnerId)
            {
                await _rollup.RollupUserAsync(original.OwnerId);
                await _rollup.RollupUserAsync(thingB.OwnerId);
            }
        }

        private class OriginalThingB
        {
            // Used to temporarily hold a copy of the relevant fields

            public int OwnerId { get; set; }

            public OriginalThingB(ThingB thingB)
            {
                OwnerId = thingB.OwnerId;
            }
        }

        #endregion

        #region Mapping

        public class MapperProfile : BaseProfile
        {
            public MapperProfile()
            {
                CreateMap<ThingB, Edit>()
                   .Map(dest => dest.DateTime, opt => opt.MapFrom(src => src.DateTime.ToDate()))
                   .Map(dest => dest.OwnerName, opt => opt.MapFrom(src => src.OwnerId == 0 ? "" : _cache.Users[src.OwnerId].Name));

                CreateMap<Edit, ThingB>()
                   .Map(dest => dest.DateTime, opt => opt.MapFrom(src => src.DateTime.TransformToDate()))
                   .Map(dest => dest.OwnerAlias, opt => opt.MapFrom(src => _cache.Users[src.OwnerId.Value].Alias));
            }
        }

        #endregion
    }
}
