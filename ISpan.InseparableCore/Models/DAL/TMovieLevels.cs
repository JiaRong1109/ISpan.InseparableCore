﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ISpan.InseparableCore.Models.DAL
{
    public partial class TMovieLevels
    {
        public TMovieLevels()
        {
            TMovies = new HashSet<TMovies>();
        }

        public int FLevelId { get; set; }
        public string FLevelName { get; set; }

        public virtual ICollection<TMovies> TMovies { get; set; }
    }
}