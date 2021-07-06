using Business.Layer.DataAccess.BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataAcces
{
    public class MediathequeDbContext : DbContext
    {
        static string ConnectionString = null;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (ConnectionString == null)
                {
                    var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .Build();

                    ConnectionString = config.GetConnectionString("SqlDbContext");
                }
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
           public virtual DbSet<Adresse> Adresses { get; set; }
           public virtual DbSet<Album> Albums { get; set; }
           public virtual DbSet<Auteur> Auteurs { get; set; }
           public virtual DbSet<Client> Clients { get; set; }
           public virtual DbSet<Genre> Genres { get; set; }
            public virtual DbSet<Livre> Livres { get; set; }
           public virtual DbSet<Media> Media { get; set; }
           public virtual DbSet<Piste> Pistes { get; set; }
           public virtual DbSet<Reservation> Reservations { get; set; }
           public virtual DbSet<Video> Videos { get; set; }









        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
