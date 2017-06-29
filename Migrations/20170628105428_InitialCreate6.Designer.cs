using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ContosoUniversity.Data;

namespace CourseApi.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20170628105428_InitialCreate6")]
    partial class InitialCreate6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContosoUniversity.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseID");

                    b.Property<int?>("Grade");

                    b.Property<int?>("PCourseID");

                    b.Property<int>("StudentID");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("PCourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("ContosoUniversity.Models.MainCourses", b =>
                {
                    b.Property<int>("ID");

                    b.Property<string>("code");

                    b.Property<int>("credits");

                    b.Property<string>("title");

                    b.HasKey("ID");

                    b.ToTable("MainCourse");
                });

            modelBuilder.Entity("ContosoUniversity.Models.PropedeuseCourse", b =>
                {
                    b.Property<int>("ID");

                    b.Property<string>("code");

                    b.Property<int>("credits");

                    b.Property<string>("title");

                    b.HasKey("ID");

                    b.ToTable("PCourse");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EnrollmentDate");

                    b.Property<string>("FirstMidName");

                    b.Property<string>("LastName");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Enrollment", b =>
                {
                    b.HasOne("ContosoUniversity.Models.PropedeuseCourse", "PCourse")
                        .WithMany()
                        .HasForeignKey("PCourseID");

                    b.HasOne("ContosoUniversity.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
