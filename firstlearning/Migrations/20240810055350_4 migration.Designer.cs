﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using firstlearning.Data;

#nullable disable

namespace firstlearning.Migrations
{
    [DbContext(typeof(MenuContext))]
    [Migration("20240810055350_4 migration")]
    partial class _4migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("firstlearning.Models.Dish", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            ImageUrl = "data:image/jpeg;base64,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",
                            Name = "Braised Sea Brass",
                            Price = 7.5
                        });
                });

            modelBuilder.Entity("firstlearning.Models.DishIngredient", b =>
                {
                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientID")
                        .HasColumnType("int");

                    b.HasKey("DishId", "IngredientID");

                    b.ToTable("DishIngredients");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            IngredientID = 1
                        },
                        new
                        {
                            DishId = 1,
                            IngredientID = 2
                        });
                });

            modelBuilder.Entity("firstlearning.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Soy Sauce"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sea Brass"
                        });
                });

            modelBuilder.Entity("firstlearning.Models.DishIngredient", b =>
                {
                    b.HasOne("firstlearning.Models.Ingredient", "ingredient")
                        .WithMany("DishIngredients")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("firstlearning.Models.Dish", "Dish")
                        .WithMany("DishIngredients")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("ingredient");
                });

            modelBuilder.Entity("firstlearning.Models.Dish", b =>
                {
                    b.Navigation("DishIngredients");
                });

            modelBuilder.Entity("firstlearning.Models.Ingredient", b =>
                {
                    b.Navigation("DishIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
