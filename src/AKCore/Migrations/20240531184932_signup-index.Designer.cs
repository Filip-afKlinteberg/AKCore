﻿// <auto-generated />
using System;
using AKCore.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AKCore.Migrations
{
    [DbContext(typeof(AKContext))]
    [Migration("20240531184932_signup-index")]
    partial class signupindex
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");
            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("AKCore.DataModel.AkUser", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("GivenMedal")
                        .HasColumnType("longtext");

                    b.Property<bool>("HasKey")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Instrument")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastSignedIn")
                        .HasColumnType("datetime");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime");

                    b.Property<string>("Medal")
                        .HasColumnType("longtext");

                    b.Property<string>("Nation")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("OtherInstruments")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("SlavPoster")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("AKCore.DataModel.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Released")
                        .HasColumnType("datetime");

                    b.Property<string>("Year")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("AKCore.DataModel.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("DescriptionEng")
                        .HasColumnType("longtext");

                    b.Property<string>("Fika")
                        .HasColumnType("longtext");

                    b.Property<TimeSpan>("HalanTime")
                        .HasColumnType("time");

                    b.Property<string>("InternalDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("InternalDescriptionEng")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)");

                    b.Property<string>("Place")
                        .HasColumnType("longtext");

                    b.Property<string>("PlayDuration")
                        .HasColumnType("longtext");

                    b.Property<bool>("Secret")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Stand")
                        .HasColumnType("longtext");

                    b.Property<TimeSpan>("StartsTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("ThereTime")
                        .HasColumnType("time");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("AKCore.DataModel.Hire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Archived")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Other")
                        .HasColumnType("longtext");

                    b.Property<string>("Tel")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Hires");
                });

            modelBuilder.Entity("AKCore.DataModel.LogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedById")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ModifiedById");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("AKCore.DataModel.MailBoxItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Archived")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("Message")
                        .HasColumnType("longtext");

                    b.Property<string>("Subject")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MailBoxItems");
                });

            modelBuilder.Entity("AKCore.DataModel.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Tag")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Medias");
                });

            modelBuilder.Entity("AKCore.DataModel.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Balett")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("LinkId")
                        .HasColumnType("int");

                    b.Property<bool>("LoggedIn")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)");

                    b.Property<string>("NameEng")
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)");

                    b.Property<int>("PosIndex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LinkId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("AKCore.DataModel.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("BalettOnly")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<bool>("LoggedIn")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LoggedOut")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MetaDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)");

                    b.Property<string>("WidgetsJson")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("AKCore.DataModel.Recruit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Archived")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("Instrument")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Other")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Recruits");
                });

            modelBuilder.Entity("AKCore.DataModel.Revision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("BalettOnly")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LoggedIn")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LoggedOut")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MetaDescription")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedById")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("PageId")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)");

                    b.Property<string>("WidgetsJson")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("PageId");

                    b.ToTable("Revisions");
                });

            modelBuilder.Entity("AKCore.DataModel.SignUp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Car")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext");

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<bool>("Instrument")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("InstrumentName")
                        .HasColumnType("longtext");

                    b.Property<string>("OtherInstruments")
                        .HasColumnType("longtext");

                    b.Property<string>("Person")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("PersonName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SignupTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Where")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("PersonId", "SignupTime");

                    b.ToTable("SignUps");
                });

            modelBuilder.Entity("AKCore.DataModel.SubMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("LinkId")
                        .HasColumnType("int");

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)");

                    b.Property<string>("NameEng")
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)");

                    b.Property<int>("SubPosIndex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LinkId");

                    b.HasIndex("MenuId");

                    b.ToTable("SubMenus");
                });

            modelBuilder.Entity("AKCore.DataModel.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("FileName")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AKCore.DataModel.LogItem", b =>
                {
                    b.HasOne("AKCore.DataModel.AkUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("AKCore.DataModel.Menu", b =>
                {
                    b.HasOne("AKCore.DataModel.Page", "Link")
                        .WithMany()
                        .HasForeignKey("LinkId");

                    b.Navigation("Link");
                });

            modelBuilder.Entity("AKCore.DataModel.Revision", b =>
                {
                    b.HasOne("AKCore.DataModel.AkUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("AKCore.DataModel.Page", null)
                        .WithMany("Revisions")
                        .HasForeignKey("PageId");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("AKCore.DataModel.SignUp", b =>
                {
                    b.HasOne("AKCore.DataModel.Event", null)
                        .WithMany("SignUps")
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("AKCore.DataModel.SubMenu", b =>
                {
                    b.HasOne("AKCore.DataModel.Page", "Link")
                        .WithMany()
                        .HasForeignKey("LinkId");

                    b.HasOne("AKCore.DataModel.Menu", null)
                        .WithMany("Children")
                        .HasForeignKey("MenuId");

                    b.Navigation("Link");
                });

            modelBuilder.Entity("AKCore.DataModel.Track", b =>
                {
                    b.HasOne("AKCore.DataModel.Album", null)
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AKCore.DataModel.AkUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AKCore.DataModel.AkUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AKCore.DataModel.AkUser", null)
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AKCore.DataModel.AkUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AKCore.DataModel.AkUser", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("AKCore.DataModel.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("AKCore.DataModel.Event", b =>
                {
                    b.Navigation("SignUps");
                });

            modelBuilder.Entity("AKCore.DataModel.Menu", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("AKCore.DataModel.Page", b =>
                {
                    b.Navigation("Revisions");
                });
#pragma warning restore 612, 618
        }
    }
}
