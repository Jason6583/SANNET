﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SANNET.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SANNETContext : DbContext
    {
        public SANNETContext()
            : base("name=SANNETContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Prediction> Predictions { get; set; }
    
        public virtual int GetCommodityChannelIndex(Nullable<int> companyId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> cciPeriod)
        {
            var companyIdParameter = companyId.HasValue ?
                new ObjectParameter("companyId", companyId) :
                new ObjectParameter("companyId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("startDate", startDate) :
                new ObjectParameter("startDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("endDate", endDate) :
                new ObjectParameter("endDate", typeof(System.DateTime));
    
            var cciPeriodParameter = cciPeriod.HasValue ?
                new ObjectParameter("cciPeriod", cciPeriod) :
                new ObjectParameter("cciPeriod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetCommodityChannelIndex", companyIdParameter, startDateParameter, endDateParameter, cciPeriodParameter);
        }
    
        public virtual ObjectResult<GetCommodityChannelIndexCrosses_Result> GetCommodityChannelIndexCrosses(Nullable<int> companyId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> cciPeriodShort, Nullable<int> cciPeriodLong)
        {
            var companyIdParameter = companyId.HasValue ?
                new ObjectParameter("companyId", companyId) :
                new ObjectParameter("companyId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("startDate", startDate) :
                new ObjectParameter("startDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("endDate", endDate) :
                new ObjectParameter("endDate", typeof(System.DateTime));
    
            var cciPeriodShortParameter = cciPeriodShort.HasValue ?
                new ObjectParameter("cciPeriodShort", cciPeriodShort) :
                new ObjectParameter("cciPeriodShort", typeof(int));
    
            var cciPeriodLongParameter = cciPeriodLong.HasValue ?
                new ObjectParameter("cciPeriodLong", cciPeriodLong) :
                new ObjectParameter("cciPeriodLong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCommodityChannelIndexCrosses_Result>("GetCommodityChannelIndexCrosses", companyIdParameter, startDateParameter, endDateParameter, cciPeriodShortParameter, cciPeriodLongParameter);
        }
    
        public virtual ObjectResult<GetFutureFiveDayPerformance_Result> GetFutureFiveDayPerformance(Nullable<int> companyId, Nullable<System.DateTime> date, Nullable<decimal> riseMultiplierTrigger, Nullable<decimal> fallMultiplierTrigger)
        {
            var companyIdParameter = companyId.HasValue ?
                new ObjectParameter("companyId", companyId) :
                new ObjectParameter("companyId", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var riseMultiplierTriggerParameter = riseMultiplierTrigger.HasValue ?
                new ObjectParameter("riseMultiplierTrigger", riseMultiplierTrigger) :
                new ObjectParameter("riseMultiplierTrigger", typeof(decimal));
    
            var fallMultiplierTriggerParameter = fallMultiplierTrigger.HasValue ?
                new ObjectParameter("fallMultiplierTrigger", fallMultiplierTrigger) :
                new ObjectParameter("fallMultiplierTrigger", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetFutureFiveDayPerformance_Result>("GetFutureFiveDayPerformance", companyIdParameter, dateParameter, riseMultiplierTriggerParameter, fallMultiplierTriggerParameter);
        }
    
        public virtual int GetRelativeStrengthIndex(Nullable<int> companyId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> rsiPeriod)
        {
            var companyIdParameter = companyId.HasValue ?
                new ObjectParameter("companyId", companyId) :
                new ObjectParameter("companyId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("startDate", startDate) :
                new ObjectParameter("startDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("endDate", endDate) :
                new ObjectParameter("endDate", typeof(System.DateTime));
    
            var rsiPeriodParameter = rsiPeriod.HasValue ?
                new ObjectParameter("rsiPeriod", rsiPeriod) :
                new ObjectParameter("rsiPeriod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetRelativeStrengthIndex", companyIdParameter, startDateParameter, endDateParameter, rsiPeriodParameter);
        }
    
        public virtual ObjectResult<GetRelativeStrengthIndexCrosses_Result> GetRelativeStrengthIndexCrosses(Nullable<int> companyId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> rsiPeriodShort, Nullable<int> rsiPeriodLong)
        {
            var companyIdParameter = companyId.HasValue ?
                new ObjectParameter("companyId", companyId) :
                new ObjectParameter("companyId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("startDate", startDate) :
                new ObjectParameter("startDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("endDate", endDate) :
                new ObjectParameter("endDate", typeof(System.DateTime));
    
            var rsiPeriodShortParameter = rsiPeriodShort.HasValue ?
                new ObjectParameter("rsiPeriodShort", rsiPeriodShort) :
                new ObjectParameter("rsiPeriodShort", typeof(int));
    
            var rsiPeriodLongParameter = rsiPeriodLong.HasValue ?
                new ObjectParameter("rsiPeriodLong", rsiPeriodLong) :
                new ObjectParameter("rsiPeriodLong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetRelativeStrengthIndexCrosses_Result>("GetRelativeStrengthIndexCrosses", companyIdParameter, startDateParameter, endDateParameter, rsiPeriodShortParameter, rsiPeriodLongParameter);
        }
    
        public virtual int GetSimpleMovingAverage(Nullable<int> companyId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> smaPeriod)
        {
            var companyIdParameter = companyId.HasValue ?
                new ObjectParameter("companyId", companyId) :
                new ObjectParameter("companyId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("startDate", startDate) :
                new ObjectParameter("startDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("endDate", endDate) :
                new ObjectParameter("endDate", typeof(System.DateTime));
    
            var smaPeriodParameter = smaPeriod.HasValue ?
                new ObjectParameter("smaPeriod", smaPeriod) :
                new ObjectParameter("smaPeriod", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetSimpleMovingAverage", companyIdParameter, startDateParameter, endDateParameter, smaPeriodParameter);
        }
    
        public virtual ObjectResult<GetSimpleMovingAverageCrosses_Result> GetSimpleMovingAverageCrosses(Nullable<int> companyId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> smaPeriodShort, Nullable<int> smaPeriodLong)
        {
            var companyIdParameter = companyId.HasValue ?
                new ObjectParameter("companyId", companyId) :
                new ObjectParameter("companyId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("startDate", startDate) :
                new ObjectParameter("startDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("endDate", endDate) :
                new ObjectParameter("endDate", typeof(System.DateTime));
    
            var smaPeriodShortParameter = smaPeriodShort.HasValue ?
                new ObjectParameter("smaPeriodShort", smaPeriodShort) :
                new ObjectParameter("smaPeriodShort", typeof(int));
    
            var smaPeriodLongParameter = smaPeriodLong.HasValue ?
                new ObjectParameter("smaPeriodLong", smaPeriodLong) :
                new ObjectParameter("smaPeriodLong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSimpleMovingAverageCrosses_Result>("GetSimpleMovingAverageCrosses", companyIdParameter, startDateParameter, endDateParameter, smaPeriodShortParameter, smaPeriodLongParameter);
        }
    }
}
