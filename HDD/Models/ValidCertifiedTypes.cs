﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HDD.Models
{
    public partial class ValidCertifiedTypes
    {
        public ValidCertifiedTypes()
        {
            RetrofitCertification = new HashSet<RetrofitCertification>();
        }

        public string CertifiedType { get; set; }
        public string Description { get; set; }
        public short? Sequence { get; set; }

        public virtual ICollection<RetrofitCertification> RetrofitCertification { get; set; }
    }
}