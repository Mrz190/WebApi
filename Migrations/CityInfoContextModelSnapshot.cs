﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCourse6_7.Data;

#nullable disable

namespace WebApiCourse6_7.Migrations
{
    [DbContext(typeof(CityInfoContext))]
    partial class CityInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApiCourse6_7.Entities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("CityDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CityDescription = "Aute et labore do magna voluptate aute et anim. Voluptate minim id consectetur nostrud. Velit eiusmod commodo tempor voluptate aliquip aliquip sit aliquip nisi dolore aute eiusmod deserunt commodo. Exercitation Lorem sunt consectetur dolor esse eu commodo non quis eu ipsum incididunt ut labore. Magna consectetur sit cillum culpa et nostrud dolor excepteur veniam. Ullamco aliqua consectetur aute nisi occaecat.\r\n",
                            CityName = "Morris"
                        },
                        new
                        {
                            CityId = 2,
                            CityDescription = "Nisi non velit elit tempor minim minim qui pariatur et. Duis minim magna laborum est. Elit in commodo commodo labore laborum ullamco sunt qui laboris id eiusmod qui in. Esse est magna ad officia sint tempor fugiat dolore nostrud aute labore. Tempor dolore veniam nulla aliqua aliquip excepteur commodo voluptate proident cillum. Adipisicing ad enim aliquip ex voluptate sunt velit cupidatat.\r\n",
                            CityName = "Staci"
                        },
                        new
                        {
                            CityId = 3,
                            CityDescription = "Consectetur nostrud quis eiusmod amet sunt pariatur consectetur. Ut dolor laboris qui quis ex veniam labore nisi in consectetur. Ex elit id excepteur velit aute tempor.\r\n",
                            CityName = "Davis"
                        },
                        new
                        {
                            CityId = 4,
                            CityDescription = "Et adipisicing ut aute nostrud qui esse. Excepteur aliquip aute proident nisi. Irure ut cupidatat veniam adipisicing elit dolor mollit elit veniam non. Aute aute exercitation sit enim quis commodo sit ullamco amet ad esse tempor.\r\n",
                            CityName = "Olivia"
                        },
                        new
                        {
                            CityId = 5,
                            CityDescription = "Sint enim velit fugiat pariatur minim est voluptate ullamco cillum aute nostrud. Proident nostrud quis est voluptate esse. Tempor mollit amet adipisicing adipisicing ex minim quis commodo ex excepteur fugiat cupidatat cupidatat. Eiusmod laborum aute consectetur pariatur. Nostrud non ea amet voluptate. Ex elit sit nisi irure laboris laboris est cupidatat in consectetur exercitation tempor.\r\n",
                            CityName = "Klein"
                        },
                        new
                        {
                            CityId = 6,
                            CityDescription = "Dolor elit proident consectetur ullamco cillum dolore exercitation cupidatat consectetur consectetur ex incididunt ullamco consectetur. Ut tempor minim irure elit non eiusmod eu magna sint nisi nisi excepteur cillum nisi. Irure cupidatat nisi elit eiusmod laboris consectetur incididunt excepteur qui enim fugiat.\r\n",
                            CityName = "Young"
                        },
                        new
                        {
                            CityId = 7,
                            CityDescription = "Culpa quis deserunt culpa excepteur ea ullamco id nisi irure. Consectetur veniam ullamco quis eu ullamco eiusmod. Ipsum aute fugiat nulla exercitation id eu reprehenderit ut incididunt dolor in pariatur. Tempor elit in cillum dolor labore consectetur in velit exercitation reprehenderit.\r\n",
                            CityName = "Roach"
                        },
                        new
                        {
                            CityId = 8,
                            CityDescription = "Aliqua cupidatat anim irure nostrud nostrud sint reprehenderit anim nisi ullamco labore amet. Amet eiusmod quis pariatur incididunt incididunt reprehenderit et tempor qui consequat laboris labore. Eu aute ipsum in minim exercitation sint. Culpa laborum tempor labore mollit pariatur tempor sint. Qui deserunt aliqua duis adipisicing esse commodo excepteur exercitation dolor excepteur commodo. Et culpa pariatur irure aliquip sunt qui tempor mollit magna commodo laborum in commodo.\r\n",
                            CityName = "Paula"
                        },
                        new
                        {
                            CityId = 9,
                            CityDescription = "Dolor id id enim minim pariatur sunt exercitation. Ut esse officia quis consequat pariatur commodo mollit. In aliquip reprehenderit incididunt ex esse eiusmod est anim veniam fugiat laboris officia. Amet ex dolore in voluptate excepteur. Voluptate sint ipsum ut consectetur cillum. In reprehenderit magna officia ipsum elit adipisicing enim exercitation adipisicing.\r\n",
                            CityName = "Sherrie"
                        },
                        new
                        {
                            CityId = 10,
                            CityDescription = "Velit aliquip eiusmod ex fugiat et excepteur sit voluptate laboris aute officia. Aliqua proident reprehenderit aliqua mollit aliqua consequat anim. Cupidatat irure pariatur reprehenderit nisi veniam.\r\n",
                            CityName = "Blair"
                        });
                });

            modelBuilder.Entity("WebApiCourse6_7.Entities.PointOfInterest", b =>
                {
                    b.Property<int>("PointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PointId"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("PointDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PointName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PointId");

                    b.HasIndex("CityId");

                    b.ToTable("PointOfInterests");

                    b.HasData(
                        new
                        {
                            PointId = 1,
                            CityId = 1,
                            PointDescription = "Ex qui aliquip aliqua velit eiusmod. Lorem consequat proident cupidatat duis consequat. Tempor eiusmod magna minim aliqua Lorem magna incididunt voluptate in consectetur enim ex. Cillum duis qui occaecat consectetur non proident consequat proident laborum ex incididunt quis. Irure exercitation sunt minim tempor laborum.\r\n",
                            PointName = "Fleming"
                        },
                        new
                        {
                            PointId = 2,
                            CityId = 1,
                            PointDescription = "Veniam velit eiusmod sit aute non. Ullamco officia in consectetur Lorem tempor ipsum ullamco laboris voluptate minim proident. Cupidatat id dolore deserunt magna cupidatat non incididunt. Eu commodo cillum laborum laborum in duis incididunt duis laboris. Deserunt enim reprehenderit exercitation occaecat aute cillum voluptate nisi ad ex sint irure do. Reprehenderit labore eu id proident ad occaecat aute sunt.\r\n",
                            PointName = "Ortiz"
                        },
                        new
                        {
                            PointId = 3,
                            CityId = 10,
                            PointDescription = "Anim laboris minim elit consectetur. Proident duis ut dolor amet sunt veniam pariatur laborum esse exercitation adipisicing sunt adipisicing. Exercitation veniam tempor labore veniam consequat anim laboris labore qui mollit do cillum duis.\r\n",
                            PointName = "Ashlee"
                        },
                        new
                        {
                            PointId = 4,
                            CityId = 10,
                            PointDescription = "Ad cillum occaecat consectetur id do. Irure deserunt aute anim magna proident duis reprehenderit enim aliqua aliquip do labore. Esse commodo elit deserunt laborum sit.\r\n",
                            PointName = "Carey"
                        },
                        new
                        {
                            PointId = 5,
                            CityId = 10,
                            PointDescription = "Elit amet labore aute aliqua pariatur proident fugiat dolore non ut pariatur ut. Esse Lorem veniam dolor dolor ea. Enim et sunt nisi ut culpa aute ea et pariatur irure labore ad. Occaecat labore ea in adipisicing cupidatat. Adipisicing Lorem consectetur eu laborum sit cupidatat ullamco eiusmod.\r\n",
                            PointName = "Hattie"
                        });
                });

            modelBuilder.Entity("WebApiCourse6_7.Entities.PointOfInterest", b =>
                {
                    b.HasOne("WebApiCourse6_7.Entities.City", "City")
                        .WithMany("PointsOfInterest")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("WebApiCourse6_7.Entities.City", b =>
                {
                    b.Navigation("PointsOfInterest");
                });
#pragma warning restore 612, 618
        }
    }
}
