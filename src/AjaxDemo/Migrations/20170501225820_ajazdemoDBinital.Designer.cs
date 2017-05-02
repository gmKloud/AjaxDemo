﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AjaxDemo.Models;

namespace AjaxDemo.Migrations
{
    [DbContext(typeof(AjaxDemoContext))]
    [Migration("20170501225820_ajazdemoDBinital")]
    partial class ajazdemoDBinital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AjaxDemo.Models.Destination", b =>
                {
                    b.Property<string>("Country");

                    b.Property<string>("City");

                    b.Property<int>("Id");

                    b.HasKey("Country");

                    b.ToTable("Destinations");
                });
        }
    }
}
