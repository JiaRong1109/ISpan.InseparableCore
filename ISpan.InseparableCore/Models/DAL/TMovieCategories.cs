﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ISpan.InseparableCore.Models.DAL
{
    public partial class TMovieCategories
    {
        public TMovieCategories()
        {
            TArticles = new HashSet<TArticles>();
            TMemberFavoriteMovieCategories = new HashSet<TMemberFavoriteMovieCategories>();
            TMovieCategoryDetails = new HashSet<TMovieCategoryDetails>();
        }

        public int FMovieCategoryId { get; set; }
        public string FMovieCategoryName { get; set; }

        public virtual ICollection<TArticles> TArticles { get; set; }
        public virtual ICollection<TMemberFavoriteMovieCategories> TMemberFavoriteMovieCategories { get; set; }
        public virtual ICollection<TMovieCategoryDetails> TMovieCategoryDetails { get; set; }
    }
}