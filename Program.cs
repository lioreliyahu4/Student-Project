using System;
using System.Collections.Generic;

namespace Targil
{
    class Program
    {
        static void Main(string[] args)
        {
            GraduationCertificatesManager studentsManager = new GraduationCertificatesManager();
            Grade[] pupil1Grades = new Grade[] {
                new Grade("linear", 80),
                new Grade("bdida", 100),
                new Grade("infi", 70),

            };
            Student pupil1 = new DataScienteceStudant("ori" , "2", pupil1Grades);

            Grade[] pupil2Grades = new Grade[] {
                new Grade("linear", 80),
                new Grade("bdida", 90),
                new Grade("infi", 100),

            };
            Student pupil2 = new DataScienteceStudant("lior" , "3", pupil2Grades);

            Grade[] pupil3Grades = new Grade[] {
                new Grade("linear", 85),
                new Grade("bdida", 90),
                new Grade("infi", 100),

            };
            Student pupil3 = new DataScienteceStudant("nehoray" , "3", pupil3Grades);
            

            Grade[] pupil4Grades = new Grade[] {
                new Grade("guitar", 85),
                new Grade("darbuka", 90),

            };
            Student pupil4 = new MusicStudent("shira" , "7", pupil4Grades);

            Grade[] pupil5Grades = new Grade[] {
                new Grade("guitar", 98),
                new Grade("darbuka", 90),
            };
            Student pupil5 = new MusicStudent("Dad" , "5", pupil5Grades);

            Grade[] pupil6Grades = new Grade[] {
                new Grade("guitar", 100),
                new Grade("darbuka", 90),
            };
            Student pupil6 = new MusicStudent("Mom" , "6", pupil6Grades);


            Grade[] pupil7Grades = new Grade[] {
                new Grade("linear", 54),
                new Grade("bdida", 100),
                new Grade("infi", 100),

            };

            Student pupil7 = new DataScienteceStudant("amiram" , "1", pupil7Grades);


            Grade[] pupil8Grades = new Grade[] {
                new Grade("electric", 80),
                new Grade("project", 100),
                new Grade("c languege", 100),

            };
            Student pupil8 = new ElectronicStudent("talya" , "8", pupil8Grades);

            Grade[] pupil9Grades = new Grade[] {
                new Grade("electric", 80),
                new Grade("project", 100),
                new Grade("c languege", 100),

            };
            Student pupil9 = new ElectronicStudent("adi" , "9", pupil9Grades);

            
            Grade[] pupil10Grades = new Grade[] {
                new Grade("linear", 100),
                new Grade("bdida", 100),
                new Grade("infi", 100),

            };

            Student pupil10 = new DataScienteceStudant("stav" , "10", pupil10Grades);

            Student pupil11 = new DataScienteceStudant("Jimmy" , "11");

            studentsManager.addStudent(pupil1);
            studentsManager.addStudent(pupil2);
            studentsManager.addStudent(pupil3);
            studentsManager.addStudent(pupil4);
            studentsManager.addStudent(pupil5);
            studentsManager.addStudent(pupil6);
            studentsManager.addStudent(pupil7);
            studentsManager.addStudent(pupil8);
            studentsManager.addStudent(pupil9);
            studentsManager.addStudent(pupil10);
            studentsManager.addStudent(pupil11);

            Student bestStudent = studentsManager.getBestStudent();
            Student worstStudent = studentsManager.getWorstStudent();
            System.Console.WriteLine("best: " + bestStudent); 
            System.Console.WriteLine("worst: " + worstStudent); 


        }
    }
}

    