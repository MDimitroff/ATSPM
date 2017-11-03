﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MOE.Common.Models
{
    public class PreemptionAggregation
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public DateTime BinStartTime { get; set; }

        [Required]
        [StringLength(10)]
        public string SignalId { get; set; }

        [ForeignKey("Signal")]
        public int VersionId { get; set; }
        public virtual Signal Signal { get; set; }

        [Required]
        public int PreemptNumber { get; set; }

        [Required]
        public int PreemptRequests { get; set; }

        [Required]
        public int PreemptServices { get; set; }
    }
}