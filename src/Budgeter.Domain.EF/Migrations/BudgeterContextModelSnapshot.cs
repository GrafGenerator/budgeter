﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Budgeter.Domain.EF.Migrations
{
    [DbContext(typeof(BudgeterContext))]
    internal class BudgeterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Budgeter.Domain.ResourceEntry", b =>
            {
                b.Property<long>("Id");

                b.Property<decimal>("Amount");

                b.Property<long>("CategoryId");

                b.Property<string>("Description")
                    .HasMaxLength(1000);

                b.HasKey("Id");

                b.HasIndex("CategoryId");

                b.ToTable("ResourceEntry");
            });

            modelBuilder.Entity("Budgeter.Domain.ResourceEntryCategory", b =>
            {
                b.Property<long>("Id");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<long?>("ParentCategoryId");

                b.HasKey("Id");

                b.HasIndex("ParentCategoryId");

                b.ToTable("ResourceEntryCategory");
            });

            modelBuilder.Entity("Budgeter.Domain.ResourceEntry", b =>
            {
                b.HasOne("Budgeter.Domain.ResourceEntryCategory", "Category")
                    .WithMany()
                    .HasForeignKey("CategoryId")
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity("Budgeter.Domain.ResourceEntryCategory", b =>
            {
                b.HasOne("Budgeter.Domain.ResourceEntryCategory", "ParentCategory")
                    .WithMany()
                    .HasForeignKey("ParentCategoryId")
                    .OnDelete(DeleteBehavior.Restrict);
            });
#pragma warning restore 612, 618
        }
    }
}