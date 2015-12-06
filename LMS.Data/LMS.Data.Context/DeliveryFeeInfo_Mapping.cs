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
    
    
    internal partial class DeliveryFeeInfo_Mapping : EntityTypeConfiguration<DeliveryFeeInfo>
    {
        public DeliveryFeeInfo_Mapping()
        {                        
              this.HasKey(t => t.DeliveryFeeInfoID);        
              this.ToTable("DeliveryFeeInfos");
              this.Property(t => t.DeliveryFeeInfoID).HasColumnName("DeliveryFeeInfoID");
              this.Property(t => t.DeliveryFeeID).HasColumnName("DeliveryFeeID");
              this.Property(t => t.MoneyChangeTypeID).HasColumnName("MoneyChangeTypeID");
              this.Property(t => t.FeeTypeID).HasColumnName("FeeTypeID");
              this.Property(t => t.Amount).HasColumnName("Amount");
              this.Property(t => t.OperationType).HasColumnName("OperationType");
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
              this.Property(t => t.Remark).HasColumnName("Remark").HasMaxLength(500);
              this.HasOptional(t => t.DeliveryFee).WithMany(t => t.DeliveryFeeInfos).HasForeignKey(d => d.DeliveryFeeID);
              this.HasRequired(t => t.FeeType).WithMany(t => t.DeliveryFeeInfos).HasForeignKey(d => d.FeeTypeID);
              this.HasRequired(t => t.MoneyChangeTypeInfo).WithMany(t => t.DeliveryFeeInfos).HasForeignKey(d => d.MoneyChangeTypeID);
         }
    }
}