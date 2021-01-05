﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NS.Data;

namespace NS.Data.Migrations
{
    [DbContext(typeof(NSDbContext))]
    partial class NSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("NS.Core.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "HR"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Development"
                        },
                        new
                        {
                            Id = 3,
                            Name = "DevOps"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Management"
                        });
                });

            modelBuilder.Entity("NS.Core.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("NS.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            FirstName = "Marilyn",
                            LastName = "Monroe",
                            PasswordHash = new byte[] { 97, 127, 134, 9, 60, 192, 236, 120, 228, 127, 140, 151, 18, 101, 11, 46, 225, 9, 109, 124, 40, 88, 98, 221, 110, 199, 80, 12, 209, 52, 143, 102, 164, 224, 61, 172, 140, 86, 109, 116, 235, 165, 95, 111, 227, 173, 37, 120, 3, 231, 55, 102, 95, 193, 38, 81, 114, 135, 58, 109, 44, 162, 68, 42 },
                            PasswordSalt = new byte[] { 243, 202, 23, 184, 232, 158, 110, 116, 229, 20, 131, 107, 58, 134, 149, 185, 191, 250, 126, 159, 1, 205, 57, 215, 11, 103, 164, 36, 172, 99, 180, 47, 5, 101, 117, 84, 124, 209, 199, 88, 21, 204, 51, 42, 239, 242, 69, 66, 73, 20, 228, 252, 119, 192, 213, 244, 11, 162, 34, 17, 36, 178, 137, 60, 9, 239, 45, 22, 169, 25, 141, 55, 215, 41, 166, 122, 108, 129, 100, 95, 126, 160, 38, 230, 228, 163, 125, 12, 118, 179, 1, 10, 168, 108, 59, 162, 19, 57, 109, 115, 183, 210, 133, 68, 77, 161, 174, 104, 75, 240, 71, 166, 213, 213, 68, 18, 74, 110, 192, 51, 190, 134, 68, 247, 197, 130, 17, 159 },
                            Username = "marilyn"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 1,
                            FirstName = "Abraham",
                            LastName = "Lincoln",
                            PasswordHash = new byte[] { 97, 127, 134, 9, 60, 192, 236, 120, 228, 127, 140, 151, 18, 101, 11, 46, 225, 9, 109, 124, 40, 88, 98, 221, 110, 199, 80, 12, 209, 52, 143, 102, 164, 224, 61, 172, 140, 86, 109, 116, 235, 165, 95, 111, 227, 173, 37, 120, 3, 231, 55, 102, 95, 193, 38, 81, 114, 135, 58, 109, 44, 162, 68, 42 },
                            PasswordSalt = new byte[] { 243, 202, 23, 184, 232, 158, 110, 116, 229, 20, 131, 107, 58, 134, 149, 185, 191, 250, 126, 159, 1, 205, 57, 215, 11, 103, 164, 36, 172, 99, 180, 47, 5, 101, 117, 84, 124, 209, 199, 88, 21, 204, 51, 42, 239, 242, 69, 66, 73, 20, 228, 252, 119, 192, 213, 244, 11, 162, 34, 17, 36, 178, 137, 60, 9, 239, 45, 22, 169, 25, 141, 55, 215, 41, 166, 122, 108, 129, 100, 95, 126, 160, 38, 230, 228, 163, 125, 12, 118, 179, 1, 10, 168, 108, 59, 162, 19, 57, 109, 115, 183, 210, 133, 68, 77, 161, 174, 104, 75, 240, 71, 166, 213, 213, 68, 18, 74, 110, 192, 51, 190, 134, 68, 247, 197, 130, 17, 159 },
                            Username = "abraham"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 2,
                            FirstName = "Nelson",
                            LastName = "Mandela",
                            PasswordHash = new byte[] { 97, 127, 134, 9, 60, 192, 236, 120, 228, 127, 140, 151, 18, 101, 11, 46, 225, 9, 109, 124, 40, 88, 98, 221, 110, 199, 80, 12, 209, 52, 143, 102, 164, 224, 61, 172, 140, 86, 109, 116, 235, 165, 95, 111, 227, 173, 37, 120, 3, 231, 55, 102, 95, 193, 38, 81, 114, 135, 58, 109, 44, 162, 68, 42 },
                            PasswordSalt = new byte[] { 243, 202, 23, 184, 232, 158, 110, 116, 229, 20, 131, 107, 58, 134, 149, 185, 191, 250, 126, 159, 1, 205, 57, 215, 11, 103, 164, 36, 172, 99, 180, 47, 5, 101, 117, 84, 124, 209, 199, 88, 21, 204, 51, 42, 239, 242, 69, 66, 73, 20, 228, 252, 119, 192, 213, 244, 11, 162, 34, 17, 36, 178, 137, 60, 9, 239, 45, 22, 169, 25, 141, 55, 215, 41, 166, 122, 108, 129, 100, 95, 126, 160, 38, 230, 228, 163, 125, 12, 118, 179, 1, 10, 168, 108, 59, 162, 19, 57, 109, 115, 183, 210, 133, 68, 77, 161, 174, 104, 75, 240, 71, 166, 213, 213, 68, 18, 74, 110, 192, 51, 190, 134, 68, 247, 197, 130, 17, 159 },
                            Username = "nelson"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 2,
                            FirstName = "John",
                            LastName = "Kennedy",
                            PasswordHash = new byte[] { 97, 127, 134, 9, 60, 192, 236, 120, 228, 127, 140, 151, 18, 101, 11, 46, 225, 9, 109, 124, 40, 88, 98, 221, 110, 199, 80, 12, 209, 52, 143, 102, 164, 224, 61, 172, 140, 86, 109, 116, 235, 165, 95, 111, 227, 173, 37, 120, 3, 231, 55, 102, 95, 193, 38, 81, 114, 135, 58, 109, 44, 162, 68, 42 },
                            PasswordSalt = new byte[] { 243, 202, 23, 184, 232, 158, 110, 116, 229, 20, 131, 107, 58, 134, 149, 185, 191, 250, 126, 159, 1, 205, 57, 215, 11, 103, 164, 36, 172, 99, 180, 47, 5, 101, 117, 84, 124, 209, 199, 88, 21, 204, 51, 42, 239, 242, 69, 66, 73, 20, 228, 252, 119, 192, 213, 244, 11, 162, 34, 17, 36, 178, 137, 60, 9, 239, 45, 22, 169, 25, 141, 55, 215, 41, 166, 122, 108, 129, 100, 95, 126, 160, 38, 230, 228, 163, 125, 12, 118, 179, 1, 10, 168, 108, 59, 162, 19, 57, 109, 115, 183, 210, 133, 68, 77, 161, 174, 104, 75, 240, 71, 166, 213, 213, 68, 18, 74, 110, 192, 51, 190, 134, 68, 247, 197, 130, 17, 159 },
                            Username = "john"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 2,
                            FirstName = "Martin",
                            LastName = "Luther King",
                            PasswordHash = new byte[] { 97, 127, 134, 9, 60, 192, 236, 120, 228, 127, 140, 151, 18, 101, 11, 46, 225, 9, 109, 124, 40, 88, 98, 221, 110, 199, 80, 12, 209, 52, 143, 102, 164, 224, 61, 172, 140, 86, 109, 116, 235, 165, 95, 111, 227, 173, 37, 120, 3, 231, 55, 102, 95, 193, 38, 81, 114, 135, 58, 109, 44, 162, 68, 42 },
                            PasswordSalt = new byte[] { 243, 202, 23, 184, 232, 158, 110, 116, 229, 20, 131, 107, 58, 134, 149, 185, 191, 250, 126, 159, 1, 205, 57, 215, 11, 103, 164, 36, 172, 99, 180, 47, 5, 101, 117, 84, 124, 209, 199, 88, 21, 204, 51, 42, 239, 242, 69, 66, 73, 20, 228, 252, 119, 192, 213, 244, 11, 162, 34, 17, 36, 178, 137, 60, 9, 239, 45, 22, 169, 25, 141, 55, 215, 41, 166, 122, 108, 129, 100, 95, 126, 160, 38, 230, 228, 163, 125, 12, 118, 179, 1, 10, 168, 108, 59, 162, 19, 57, 109, 115, 183, 210, 133, 68, 77, 161, 174, 104, 75, 240, 71, 166, 213, 213, 68, 18, 74, 110, 192, 51, 190, 134, 68, 247, 197, 130, 17, 159 },
                            Username = "martin"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 2,
                            FirstName = "Queen",
                            LastName = "Elizabeth",
                            PasswordHash = new byte[] { 97, 127, 134, 9, 60, 192, 236, 120, 228, 127, 140, 151, 18, 101, 11, 46, 225, 9, 109, 124, 40, 88, 98, 221, 110, 199, 80, 12, 209, 52, 143, 102, 164, 224, 61, 172, 140, 86, 109, 116, 235, 165, 95, 111, 227, 173, 37, 120, 3, 231, 55, 102, 95, 193, 38, 81, 114, 135, 58, 109, 44, 162, 68, 42 },
                            PasswordSalt = new byte[] { 243, 202, 23, 184, 232, 158, 110, 116, 229, 20, 131, 107, 58, 134, 149, 185, 191, 250, 126, 159, 1, 205, 57, 215, 11, 103, 164, 36, 172, 99, 180, 47, 5, 101, 117, 84, 124, 209, 199, 88, 21, 204, 51, 42, 239, 242, 69, 66, 73, 20, 228, 252, 119, 192, 213, 244, 11, 162, 34, 17, 36, 178, 137, 60, 9, 239, 45, 22, 169, 25, 141, 55, 215, 41, 166, 122, 108, 129, 100, 95, 126, 160, 38, 230, 228, 163, 125, 12, 118, 179, 1, 10, 168, 108, 59, 162, 19, 57, 109, 115, 183, 210, 133, 68, 77, 161, 174, 104, 75, 240, 71, 166, 213, 213, 68, 18, 74, 110, 192, 51, 190, 134, 68, 247, 197, 130, 17, 159 },
                            Username = "queen"
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 2,
                            FirstName = "Winston",
                            LastName = "Churchill",
                            PasswordHash = new byte[] { 97, 127, 134, 9, 60, 192, 236, 120, 228, 127, 140, 151, 18, 101, 11, 46, 225, 9, 109, 124, 40, 88, 98, 221, 110, 199, 80, 12, 209, 52, 143, 102, 164, 224, 61, 172, 140, 86, 109, 116, 235, 165, 95, 111, 227, 173, 37, 120, 3, 231, 55, 102, 95, 193, 38, 81, 114, 135, 58, 109, 44, 162, 68, 42 },
                            PasswordSalt = new byte[] { 243, 202, 23, 184, 232, 158, 110, 116, 229, 20, 131, 107, 58, 134, 149, 185, 191, 250, 126, 159, 1, 205, 57, 215, 11, 103, 164, 36, 172, 99, 180, 47, 5, 101, 117, 84, 124, 209, 199, 88, 21, 204, 51, 42, 239, 242, 69, 66, 73, 20, 228, 252, 119, 192, 213, 244, 11, 162, 34, 17, 36, 178, 137, 60, 9, 239, 45, 22, 169, 25, 141, 55, 215, 41, 166, 122, 108, 129, 100, 95, 126, 160, 38, 230, 228, 163, 125, 12, 118, 179, 1, 10, 168, 108, 59, 162, 19, 57, 109, 115, 183, 210, 133, 68, 77, 161, 174, 104, 75, 240, 71, 166, 213, 213, 68, 18, 74, 110, 192, 51, 190, 134, 68, 247, 197, 130, 17, 159 },
                            Username = "winston"
                        },
                        new
                        {
                            Id = 8,
                            DepartmentId = 3,
                            FirstName = "Donald",
                            LastName = "Trump",
                            PasswordHash = new byte[] { 97, 127, 134, 9, 60, 192, 236, 120, 228, 127, 140, 151, 18, 101, 11, 46, 225, 9, 109, 124, 40, 88, 98, 221, 110, 199, 80, 12, 209, 52, 143, 102, 164, 224, 61, 172, 140, 86, 109, 116, 235, 165, 95, 111, 227, 173, 37, 120, 3, 231, 55, 102, 95, 193, 38, 81, 114, 135, 58, 109, 44, 162, 68, 42 },
                            PasswordSalt = new byte[] { 243, 202, 23, 184, 232, 158, 110, 116, 229, 20, 131, 107, 58, 134, 149, 185, 191, 250, 126, 159, 1, 205, 57, 215, 11, 103, 164, 36, 172, 99, 180, 47, 5, 101, 117, 84, 124, 209, 199, 88, 21, 204, 51, 42, 239, 242, 69, 66, 73, 20, 228, 252, 119, 192, 213, 244, 11, 162, 34, 17, 36, 178, 137, 60, 9, 239, 45, 22, 169, 25, 141, 55, 215, 41, 166, 122, 108, 129, 100, 95, 126, 160, 38, 230, 228, 163, 125, 12, 118, 179, 1, 10, 168, 108, 59, 162, 19, 57, 109, 115, 183, 210, 133, 68, 77, 161, 174, 104, 75, 240, 71, 166, 213, 213, 68, 18, 74, 110, 192, 51, 190, 134, 68, 247, 197, 130, 17, 159 },
                            Username = "donald"
                        },
                        new
                        {
                            Id = 9,
                            DepartmentId = 3,
                            FirstName = "Muhammad",
                            LastName = "Ali",
                            PasswordHash = new byte[] { 97, 127, 134, 9, 60, 192, 236, 120, 228, 127, 140, 151, 18, 101, 11, 46, 225, 9, 109, 124, 40, 88, 98, 221, 110, 199, 80, 12, 209, 52, 143, 102, 164, 224, 61, 172, 140, 86, 109, 116, 235, 165, 95, 111, 227, 173, 37, 120, 3, 231, 55, 102, 95, 193, 38, 81, 114, 135, 58, 109, 44, 162, 68, 42 },
                            PasswordSalt = new byte[] { 243, 202, 23, 184, 232, 158, 110, 116, 229, 20, 131, 107, 58, 134, 149, 185, 191, 250, 126, 159, 1, 205, 57, 215, 11, 103, 164, 36, 172, 99, 180, 47, 5, 101, 117, 84, 124, 209, 199, 88, 21, 204, 51, 42, 239, 242, 69, 66, 73, 20, 228, 252, 119, 192, 213, 244, 11, 162, 34, 17, 36, 178, 137, 60, 9, 239, 45, 22, 169, 25, 141, 55, 215, 41, 166, 122, 108, 129, 100, 95, 126, 160, 38, 230, 228, 163, 125, 12, 118, 179, 1, 10, 168, 108, 59, 162, 19, 57, 109, 115, 183, 210, 133, 68, 77, 161, 174, 104, 75, 240, 71, 166, 213, 213, 68, 18, 74, 110, 192, 51, 190, 134, 68, 247, 197, 130, 17, 159 },
                            Username = "muhammad"
                        },
                        new
                        {
                            Id = 10,
                            DepartmentId = 5,
                            FirstName = "Elon",
                            LastName = "Musk",
                            PasswordHash = new byte[] { 97, 127, 134, 9, 60, 192, 236, 120, 228, 127, 140, 151, 18, 101, 11, 46, 225, 9, 109, 124, 40, 88, 98, 221, 110, 199, 80, 12, 209, 52, 143, 102, 164, 224, 61, 172, 140, 86, 109, 116, 235, 165, 95, 111, 227, 173, 37, 120, 3, 231, 55, 102, 95, 193, 38, 81, 114, 135, 58, 109, 44, 162, 68, 42 },
                            PasswordSalt = new byte[] { 243, 202, 23, 184, 232, 158, 110, 116, 229, 20, 131, 107, 58, 134, 149, 185, 191, 250, 126, 159, 1, 205, 57, 215, 11, 103, 164, 36, 172, 99, 180, 47, 5, 101, 117, 84, 124, 209, 199, 88, 21, 204, 51, 42, 239, 242, 69, 66, 73, 20, 228, 252, 119, 192, 213, 244, 11, 162, 34, 17, 36, 178, 137, 60, 9, 239, 45, 22, 169, 25, 141, 55, 215, 41, 166, 122, 108, 129, 100, 95, 126, 160, 38, 230, 228, 163, 125, 12, 118, 179, 1, 10, 168, 108, 59, 162, 19, 57, 109, 115, 183, 210, 133, 68, 77, 161, 174, 104, 75, 240, 71, 166, 213, 213, 68, 18, 74, 110, 192, 51, 190, 134, 68, 247, 197, 130, 17, 159 },
                            Username = "elon"
                        },
                        new
                        {
                            Id = 11,
                            DepartmentId = 5,
                            FirstName = "Jeff",
                            LastName = "Bezos",
                            PasswordHash = new byte[] { 97, 127, 134, 9, 60, 192, 236, 120, 228, 127, 140, 151, 18, 101, 11, 46, 225, 9, 109, 124, 40, 88, 98, 221, 110, 199, 80, 12, 209, 52, 143, 102, 164, 224, 61, 172, 140, 86, 109, 116, 235, 165, 95, 111, 227, 173, 37, 120, 3, 231, 55, 102, 95, 193, 38, 81, 114, 135, 58, 109, 44, 162, 68, 42 },
                            PasswordSalt = new byte[] { 243, 202, 23, 184, 232, 158, 110, 116, 229, 20, 131, 107, 58, 134, 149, 185, 191, 250, 126, 159, 1, 205, 57, 215, 11, 103, 164, 36, 172, 99, 180, 47, 5, 101, 117, 84, 124, 209, 199, 88, 21, 204, 51, 42, 239, 242, 69, 66, 73, 20, 228, 252, 119, 192, 213, 244, 11, 162, 34, 17, 36, 178, 137, 60, 9, 239, 45, 22, 169, 25, 141, 55, 215, 41, 166, 122, 108, 129, 100, 95, 126, 160, 38, 230, 228, 163, 125, 12, 118, 179, 1, 10, 168, 108, 59, 162, 19, 57, 109, 115, 183, 210, 133, 68, 77, 161, 174, 104, 75, 240, 71, 166, 213, 213, 68, 18, 74, 110, 192, 51, 190, 134, 68, 247, 197, 130, 17, 159 },
                            Username = "jeff"
                        },
                        new
                        {
                            Id = 12,
                            DepartmentId = 5,
                            FirstName = "Bill",
                            LastName = "Gates",
                            PasswordHash = new byte[] { 97, 127, 134, 9, 60, 192, 236, 120, 228, 127, 140, 151, 18, 101, 11, 46, 225, 9, 109, 124, 40, 88, 98, 221, 110, 199, 80, 12, 209, 52, 143, 102, 164, 224, 61, 172, 140, 86, 109, 116, 235, 165, 95, 111, 227, 173, 37, 120, 3, 231, 55, 102, 95, 193, 38, 81, 114, 135, 58, 109, 44, 162, 68, 42 },
                            PasswordSalt = new byte[] { 243, 202, 23, 184, 232, 158, 110, 116, 229, 20, 131, 107, 58, 134, 149, 185, 191, 250, 126, 159, 1, 205, 57, 215, 11, 103, 164, 36, 172, 99, 180, 47, 5, 101, 117, 84, 124, 209, 199, 88, 21, 204, 51, 42, 239, 242, 69, 66, 73, 20, 228, 252, 119, 192, 213, 244, 11, 162, 34, 17, 36, 178, 137, 60, 9, 239, 45, 22, 169, 25, 141, 55, 215, 41, 166, 122, 108, 129, 100, 95, 126, 160, 38, 230, 228, 163, 125, 12, 118, 179, 1, 10, 168, 108, 59, 162, 19, 57, 109, 115, 183, 210, 133, 68, 77, 161, 174, 104, 75, 240, 71, 166, 213, 213, 68, 18, 74, 110, 192, 51, 190, 134, 68, 247, 197, 130, 17, 159 },
                            Username = "bill"
                        });
                });

            modelBuilder.Entity("NS.Core.Entities.UserNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("NotificationId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("WasRead")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NotificationId");

                    b.HasIndex("UserId");

                    b.ToTable("UserNotifications");
                });

            modelBuilder.Entity("NS.Core.Entities.UserSettings", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("DisabledDepartments")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("NS.Core.Entities.Notification", b =>
                {
                    b.HasOne("NS.Core.Entities.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NS.Core.Entities.User", b =>
                {
                    b.HasOne("NS.Core.Entities.Department", "Department")
                        .WithMany("Users")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("NS.Core.Entities.UserNotification", b =>
                {
                    b.HasOne("NS.Core.Entities.Notification", "Notification")
                        .WithMany("UserNotifications")
                        .HasForeignKey("NotificationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NS.Core.Entities.User", "User")
                        .WithMany("UserNotifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Notification");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NS.Core.Entities.UserSettings", b =>
                {
                    b.HasOne("NS.Core.Entities.User", "User")
                        .WithOne("UserSettings")
                        .HasForeignKey("NS.Core.Entities.UserSettings", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NS.Core.Entities.Department", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("NS.Core.Entities.Notification", b =>
                {
                    b.Navigation("UserNotifications");
                });

            modelBuilder.Entity("NS.Core.Entities.User", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("UserNotifications");

                    b.Navigation("UserSettings");
                });
#pragma warning restore 612, 618
        }
    }
}
