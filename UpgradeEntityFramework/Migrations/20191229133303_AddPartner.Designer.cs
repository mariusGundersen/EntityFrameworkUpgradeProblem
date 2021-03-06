﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UpgradeEntityFramework;

namespace UpgradeEntityFramework.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20191229133303_AddPartner")]
    partial class AddPartner
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UpgradeEntityFramework.EventSignup", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PartnerEmail");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PartnerEmail");

                    b.HasIndex("UserId");

                    b.ToTable("EventSignups");
                });

            modelBuilder.Entity("UpgradeEntityFramework.MemberUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NormalizedEmail")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("MemberUsers");
                });

            modelBuilder.Entity("UpgradeEntityFramework.EventSignup", b =>
                {
                    b.HasOne("UpgradeEntityFramework.MemberUser", "Partner")
                        .WithMany()
                        .HasForeignKey("PartnerEmail")
                        .HasPrincipalKey("NormalizedEmail");

                    b.HasOne("UpgradeEntityFramework.MemberUser", "User")
                        .WithMany("EventSignups")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
