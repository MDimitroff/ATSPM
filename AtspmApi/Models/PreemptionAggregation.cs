﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CsvHelper.Configuration;

namespace AtspmApi.Models
{
    public class PreemptionAggregation : Aggregation
    {
        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [Required]
        [Column(Order = 0)]
        public override DateTime BinStartTime { get; set; }

        [Key]
        [Required]
        [StringLength(10)]
        [Column(Order = 1)]
        public string SignalId { get; set; }

        [Key]
        //[ForeignKey("Signal")]
        [Column(Order = 2)]
        public int VersionId { get; set; }

        //public virtual Signal Signal { get; set; }

        [Required]
        [Column(Order = 3)]
        public int PreemptNumber { get; set; }

        [Required]
        [Column(Order = 4)]
        public int PreemptRequests { get; set; }

        [Required]
        [Column(Order = 5)]
        public int PreemptServices { get; set; }
        
        public sealed class PreemptionAggregationClassMap : ClassMap<PreemptionAggregation>
        {
            public PreemptionAggregationClassMap()
            {
                //Map(m => m.Signal).Ignore();
                Map(m => m.Id).Name("Record Number");
                Map(m => m.BinStartTime).Name("Bin Start Time");
                Map(m => m.VersionId).Name("Version ID");
                Map(m => m.PreemptNumber).Name("Preempt Number");
                Map(m => m.PreemptRequests).Name("Preempt Requests");
                Map(m => m.PreemptServices).Name("Preempt Services");
                Map(m => m.SignalId).Name("Signal Id");
            }
        }
    }
}