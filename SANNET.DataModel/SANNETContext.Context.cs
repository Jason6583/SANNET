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
    
        public virtual DbSet<ApplicationLog> ApplicationLogs { get; set; }
        public virtual DbSet<NetworkConfiguration> NetworkConfigurations { get; set; }
        public virtual DbSet<Prediction> Predictions { get; set; }
    
        public virtual int ApplicationLogInsert(Nullable<System.DateTime> logDate, string thread, string logLevel, string logger, string message, string exception, string location, string userId)
        {
            var logDateParameter = logDate.HasValue ?
                new ObjectParameter("logDate", logDate) :
                new ObjectParameter("logDate", typeof(System.DateTime));
    
            var threadParameter = thread != null ?
                new ObjectParameter("thread", thread) :
                new ObjectParameter("thread", typeof(string));
    
            var logLevelParameter = logLevel != null ?
                new ObjectParameter("logLevel", logLevel) :
                new ObjectParameter("logLevel", typeof(string));
    
            var loggerParameter = logger != null ?
                new ObjectParameter("logger", logger) :
                new ObjectParameter("logger", typeof(string));
    
            var messageParameter = message != null ?
                new ObjectParameter("message", message) :
                new ObjectParameter("message", typeof(string));
    
            var exceptionParameter = exception != null ?
                new ObjectParameter("exception", exception) :
                new ObjectParameter("exception", typeof(string));
    
            var locationParameter = location != null ?
                new ObjectParameter("location", location) :
                new ObjectParameter("location", typeof(string));
    
            var userIdParameter = userId != null ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ApplicationLogInsert", logDateParameter, threadParameter, logLevelParameter, loggerParameter, messageParameter, exceptionParameter, locationParameter, userIdParameter);
        }
    
        public virtual ObjectResult<ApplicationLogSelect_Result> ApplicationLogSelect()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ApplicationLogSelect_Result>("ApplicationLogSelect");
        }
    
        public virtual ObjectResult<GetTestingDataset_Result> GetTestingDataset(Nullable<int> quoteId)
        {
            var quoteIdParameter = quoteId.HasValue ?
                new ObjectParameter("quoteId", quoteId) :
                new ObjectParameter("quoteId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTestingDataset_Result>("GetTestingDataset", quoteIdParameter);
        }
    
        public virtual ObjectResult<GetTrainingDataset_Result> GetTrainingDataset(Nullable<int> quoteId)
        {
            var quoteIdParameter = quoteId.HasValue ?
                new ObjectParameter("quoteId", quoteId) :
                new ObjectParameter("quoteId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTrainingDataset_Result>("GetTrainingDataset", quoteIdParameter);
        }
    }
}
