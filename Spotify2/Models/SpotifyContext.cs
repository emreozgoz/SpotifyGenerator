using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Spotify2.Models
{
    public partial class SpotifyContext : DbContext
    {
        public SpotifyContext()
        {
        }

        public SpotifyContext(DbContextOptions<SpotifyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<List> Lists { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-979DLA4M;Database=Spotify;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<List>(entity =>
            {
                entity.ToTable("List");

                entity.Property(e => e.Acousticness)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("acousticness");

                entity.Property(e => e.ArtistName)
                    .HasMaxLength(200)
                    .HasColumnName("artist_name");

                entity.Property(e => e.Danceability)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("danceability");

                entity.Property(e => e.DurationMs)
                    .HasMaxLength(200)
                    .HasColumnName("duration_ms");

                entity.Property(e => e.Energy)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("energy");

                entity.Property(e => e.Instrumentalness)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("instrumentalness");

                entity.Property(e => e.Keyy)
                    .HasMaxLength(200)
                    .HasColumnName("keyy");

                entity.Property(e => e.Liveness)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("liveness");

                entity.Property(e => e.Loudness)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("loudness");

                entity.Property(e => e.Mode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("mode");

                entity.Property(e => e.Popularity)
                    .HasMaxLength(200)
                    .HasColumnName("popularity");

                entity.Property(e => e.Speechiness)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("speechiness");

                entity.Property(e => e.Tempo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tempo");

                entity.Property(e => e.TimeSignature)
                    .HasMaxLength(200)
                    .HasColumnName("time_signature");

                entity.Property(e => e.TrackId)
                    .HasMaxLength(200)
                    .HasColumnName("track_id");

                entity.Property(e => e.TrackName)
                    .HasMaxLength(200)
                    .HasColumnName("track_name");

                entity.Property(e => e.Valence)
                    .HasMaxLength(200)
                    .HasColumnName("valence");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
