// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebsiteAssignmentMain.Models;

namespace WebsiteAssignmentMain.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210406135701_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebsiteAssignmentMain.Models.Movie", b =>
                {
                    b.Property<int>("Movie_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Movie_Genre")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Movie_Gross")
                        .HasColumnType("decimal(25,3)");

                    b.Property<decimal>("Movie_Imdb")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Movie_MetaScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Movie_Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Movie_Time")
                        .HasColumnType("int");

                    b.Property<int>("Movie_Votes")
                        .HasColumnType("int");

                    b.Property<int>("Movie_Year")
                        .HasColumnType("int");

                    b.HasKey("Movie_Id");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
