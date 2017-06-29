
using ContosoUniversity.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any courses.
            if (context.PCourses.Any())
            {
                return;   // DB has been seeded
            }





            //** ------------students------------ **//
            var students = new Student[]
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();



            //** ------------propedeuse------------ **//
            var pcourses = new PropedeuseCourse[]
            {
                new PropedeuseCourse{
                    ID =1,
                    code = "IPMEDT1",
                    title ="Project Mediatechnologie intro",
                    credits =6
                },
                new PropedeuseCourse{
                    ID =2,
                    code = "IMTHB",
                    title ="Mediatechnologie HTML Basics",
                    credits =3
                },
                new PropedeuseCourse{
                    ID =3,
                    code = "IOPR1",
                    title ="ObjectgeoriÃ«nteerd programmeren 1",
                    credits =4
                },
                new PropedeuseCourse{
                    ID =4,
                    code = "IPBIT1",
                    title ="Project Business IT intro",
                    credits =5
                },
                new PropedeuseCourse{
                    ID =5,
                    code = "ISMI",
                    title ="Inleiding Business IT",
                    credits =3
                },
                new PropedeuseCourse{
                    ID =6,
                    code = "IBPM",
                    title ="Inleiding informatiemanagement / BPM",
                    credits =3
                },
                new PropedeuseCourse{
                    ID =7,
                    code = "IOPR2",
                    title ="ObjectgeoriÃ«nteerd programmeren 2",
                    credits =4
                },
                new PropedeuseCourse{
                    ID =8,
                    code = "IPSEN",
                    title ="MProject Software Engineering intro",
                    credits =5
                },
                new PropedeuseCourse{
                    ID =9,
                    code = "IMUML",
                    title ="Modelleren in Unified Modelling Language",
                    credits =3
                },
                new PropedeuseCourse{
                    ID =10,
                    code = "IRDB",
                    title ="Relationele Databases",
                    credits =3
                },
                new PropedeuseCourse{
                    ID =11,
                    code = "ITIM",
                    title ="Toekomst, Innovatie & Media",
                    credits =3
                },
                new PropedeuseCourse{
                    ID =12,
                    code = "ICOMNL",
                    title ="Inleiding communicatievaardigheden",
                    credits =3
                },
                new PropedeuseCourse{
                    ID =13,
                    code = "IPFIT1",
                    title ="Project forensische ICT intro",
                    credits =5
                },
                new PropedeuseCourse{
                    ID =14,
                    code = "IFIT",
                    title ="Inleiding Forensische ICT",
                    credits =3
                },
                new PropedeuseCourse{
                    ID =15,
                    code = "IWEB",
                    title ="Webtechnologie",
                    credits =3
                },
                new PropedeuseCourse{
                    ID =16,
                    code = "INST",
                    title ="IT netwerkstructuren",
                    credits =3
                },
                new PropedeuseCourse{
                    ID =17,
                    code = "ISL01",
                    title ="Studieloopbaan begeleiding",
                    credits =1
                }

            };
            foreach (PropedeuseCourse c in pcourses)
            {
                context.PCourses.Add(c);
            }
            context.SaveChanges();


            var keuzeVak = new KeuzevVak[]
            {
                new KeuzevVak{
                    ID =1,
                    code = "IPMEDT1",
                    title ="Project Mediatechnologie intro",
                    credits =6
                },
                new KeuzevVak{
                    ID =2,
                    code = "IMTHB",
                    title ="Mediatechnologie HTML Basics",
                    credits =3
                },
                new KeuzevVak{
                    ID =3,
                    code = "IOPR1",
                    title ="ObjectgeoriÃ«nteerd programmeren 1",
                    credits =4
                },
                new KeuzevVak{
                    ID =4,
                    code = "IPBIT1",
                    title ="Project Business IT intro",
                    credits =5
                },
                new KeuzevVak{
                    ID =5,
                    code = "ISMI",
                    title ="Inleiding Business IT",
                    credits =3
                },
                new KeuzevVak{
                    ID =6,
                    code = "IBPM",
                    title ="Inleiding informatiemanagement / BPM",
                    credits =3
                },
                new KeuzevVak{
                    ID =7,
                    code = "IOPR2",
                    title ="ObjectgeoriÃ«nteerd programmeren 2",
                    credits =4
                },
                new KeuzevVak{
                    ID =8,
                    code = "IPSEN",
                    title ="MProject Software Engineering intro",
                    credits =5
                },
                new KeuzevVak{
                    ID =9,
                    code = "IMUML",
                    title ="Modelleren in Unified Modelling Language",
                    credits =3
                },
                new KeuzevVak{
                    ID =10,
                    code = "IRDB",
                    title ="Relationele Databases",
                    credits =3
                },
                new KeuzevVak{
                    ID =11,
                    code = "ITIM",
                    title ="Toekomst, Innovatie & Media",
                    credits =3
                },
                new KeuzevVak{
                    ID =12,
                    code = "ICOMNL",
                    title ="Inleiding communicatievaardigheden",
                    credits =3
                },
                new KeuzevVak{
                    ID =13,
                    code = "IPFIT1",
                    title ="Project forensische ICT intro",
                    credits =5
                },
                new KeuzevVak{
                    ID =14,
                    code = "IFIT",
                    title ="Inleiding Forensische ICT",
                    credits =3
                },
                new KeuzevVak{
                    ID =15,
                    code = "IWEB",
                    title ="Webtechnologie",
                    credits =3
                },
                new KeuzevVak{
                    ID =16,
                    code = "INST",
                    title ="IT netwerkstructuren",
                    credits =3
                },
                new KeuzevVak{
                    ID =17,
                    code = "ISL01",
                    title ="Studieloopbaan begeleiding",
                    credits =1
                }

            };
            foreach (PropedeuseCourse c in pcourses)
            {
                context.PCourses.Add(c);
            }
            context.SaveChanges();





            //** ------------mtCourses------------ **//
            var mtCourses = new MTCourse[]
            {
                new MTCourse{
                    ID =1,
                    code = "IRDBMS",
                    title ="Relationele Databasemanagementsystemen",
                    credits =3
                },
                new MTCourse{
                    ID =2,
                    code = "IPMEDT2",
                    title ="Project Mediatechnologie 2",
                    credits =6
                },
                new MTCourse{
                    ID =3,
                    code = "IMTD1",
                    title ="Mediatechnologie Design 1",
                    credits =3
                },
                new MTCourse{
                    ID =4,
                    code = "IQUA",
                    title ="Kwaliteit in de IT",
                    credits =3
                },
                new MTCourse{
                    ID =5,
                    code = "IPMEDT3",
                    title ="Project Mediatechnologie 3",
                    credits =6
                },
                new MTCourse{
                    ID =6,
                    code = "ITORG",
                    title ="Inleiding Organisatiekunde",
                    credits =3
                },
                new MTCourse{
                    ID =7,
                    code = "IPMEDT4",
                    title ="Project Mediatechnologie 4",
                    credits =6
                },
                new MTCourse{
                    ID =8,
                    code = "IMTPMD",
                    title ="Programming for Mobile Devices",
                    credits =3
                },
                new MTCourse{
                    ID =9,
                    code = "ISEC",
                    title ="IT Security",
                    credits =3
                },
                new MTCourse{
                    ID =10,
                    code = "IPMEDT5",
                    title ="Project Mediatechnologie 5",
                    credits =6
                },
                new MTCourse{
                    ID =11,
                    code = "IMTHE1",
                    title ="Mediatechnologie Hardware Engineering 1",
                    credits =3
                },
                new MTCourse{
                    ID =12,
                    code = "IFP2",
                    title ="Projectmanagement volgens Prince 2",
                    credits =3
                },
                new MTCourse{
                    ID =13,
                    code = "IETH",
                    title ="Ethiek",
                    credits =3
                },
                new MTCourse{
                    ID =14,
                    code = "IPMEDTH",
                    title ="Project Mediatechnologie hoofdfase",
                    credits =9
                },
                new MTCourse{
                    ID =15,
                    code = "IMTCM",
                    title ="Mediatechnologie Creative Marketing",
                    credits =3
                },
                new MTCourse{
                    ID =16,
                    code = "IMTMC",
                    title ="Mediatechnologie Marketing en Communicatie",
                    credits =3
                },
                new MTCourse{
                    ID =17,
                    code = "ICOMH",
                    title ="Communicatie hoofdfase",
                    credits =3
                },
                new MTCourse{
                    ID =18,
                    code = "ISLH1",
                    title ="Studieloopbaanbegeleiding 2",
                    credits =3
                },
                new MTCourse{
                    ID =19,
                    code = "ISLH2",
                    title ="Studieloopbaanbegeleiding 3",
                    credits =1
                },
                new MTCourse{
                    ID =20,
                    code = "ISLH3",
                    title ="Studieloopbaanbegeleiding 4",
                    credits =1
                },
                new MTCourse{
                    ID =21,
                    code = "IMTHMI",
                    title ="Human-Machine-interaction",
                    credits =3
                },
                new MTCourse{
                    ID =22,
                    code = "Minor",
                    title ="Minor",
                    credits =30
                },
                new MTCourse{
                    ID =23,
                    code = "IWLS",
                    title ="Stage",
                    credits =30
                },
                new MTCourse{
                    ID =24,
                    code = "IWLA",
                    title ="Afstuderen",
                    credits =30
                }

            };

            foreach (MTCourse c in mtCourses)
            {
                context.MtCourses.Add(c);
            }
            context.SaveChanges();







            //** ------------enrollment------------ **//
            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();

        }
    }
}