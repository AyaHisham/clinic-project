﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MahmoudClinic.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MahmoudClinicDBEntities : DbContext
    {
        public MahmoudClinicDBEntities()
            : base("name=MahmoudClinicDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<ContactUsPhone> ContactUsPhone { get; set; }
        public virtual DbSet<Gallery> Gallery { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsPicture> NewsPicture { get; set; }
        public virtual DbSet<Offers> Offers { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<VisitCause> VisitCause { get; set; }

        public System.Data.Entity.DbSet<MahmoudClinic.ViewModels.NewsPictureViewModel> NewsPictureViewModels { get; set; }

        public System.Data.Entity.DbSet<MahmoudClinic.ViewModels.MissionVisionViewModel> MissionVisionViewModels { get; set; }

        public System.Data.Entity.DbSet<MahmoudClinic.ViewModels.PorfolioViewModel> PorfolioViewModels { get; set; }
    }
}