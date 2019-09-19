﻿// <auto-generated />
using EventCatalogAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventCatalogAPI.Migrations
{
    [DbContext(typeof(EventCatalogContext))]
    partial class EventCatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.event_catalog_hilo", "'event_catalog_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.event_category_hilo", "'event_category_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.event_type_hilo", "'event_type_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventCatalogAPI.Domain.EventCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_category_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("EventCategories");
                });

            modelBuilder.Entity("EventCatalogAPI.Domain.EventItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_catalog_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(300);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("EventCategoryId");

                    b.Property<string>("EventDescription")
                        .IsRequired()
                        .HasMaxLength(10000);

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("EventTypeId");

                    b.Property<string>("OrganizerName")
                        .HasMaxLength(100);

                    b.Property<string>("PictureUrl");

                    b.Property<decimal>("Price");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.Property<string>("VenueName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.HasKey("Id");

                    b.HasIndex("EventCategoryId");

                    b.HasIndex("EventTypeId");

                    b.ToTable("EventCatalog");
                });

            modelBuilder.Entity("EventCatalogAPI.Domain.EventType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_type_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("EventTypes");
                });

            modelBuilder.Entity("EventCatalogAPI.Domain.EventItem", b =>
                {
                    b.HasOne("EventCatalogAPI.Domain.EventCategory", "EventCategory")
                        .WithMany()
                        .HasForeignKey("EventCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventCatalogAPI.Domain.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
