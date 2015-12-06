//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Context
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    using LMS.Data.Entity;
    
    
    internal partial class ReturnGoods_Mapping : EntityTypeConfiguration<ReturnGoods>
    {
        public ReturnGoods_Mapping()
        {                        
              this.HasKey(t => t.ReGoodsId);        
              this.ToTable("ReturnGoods");
              this.Property(t => t.ReGoodsId).HasColumnName("ReGoodsId").IsRequired().HasMaxLength(20);
              this.Property(t => t.WayBillNumber).HasColumnName("WayBillNumber").IsRequired().HasMaxLength(20);
              this.Property(t => t.Weight).HasColumnName("Weight");
              this.Property(t => t.Type).HasColumnName("Type");
              this.Property(t => t.Reason).HasColumnName("Reason").IsRequired().HasMaxLength(50);
              this.Property(t => t.ReasonRemark).HasColumnName("ReasonRemark");
              this.Property(t => t.IsReturnShipping).HasColumnName("IsReturnShipping");
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").IsRequired().HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").IsRequired().HasMaxLength(50);
              this.Property(t => t.ShippingFee).HasColumnName("ShippingFee");
              this.Property(t => t.Status).HasColumnName("Status");
              this.Property(t => t.Auditor).HasColumnName("Auditor").HasMaxLength(50);
              this.Property(t => t.AuditorDate).HasColumnName("AuditorDate");
              this.Property(t => t.ReturnSource).HasColumnName("ReturnSource");
              this.HasRequired(t => t.WayBillInfo).WithMany(t => t.ReturnGoods).HasForeignKey(d => d.WayBillNumber);
         }
    }
}