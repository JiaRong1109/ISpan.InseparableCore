﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ISpan.InseparableCore.Models.DAL
{
    public partial class TProductCategories
    {
        public TProductCategories()
        {
            TProducts = new HashSet<TProducts>();
        }

        public int FProductCategoryId { get; set; }
        public string FProductCategoryName { get; set; }

        public virtual ICollection<TProducts> TProducts { get; set; }
    }
}