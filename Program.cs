using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating instances of cohorts, instructors, students and excercises
            Cohort Cohort28 = new Cohort("Cohort 28");
            Cohort Cohort29 = new Cohort("Cohort 29");
            Cohort Cohort30 = new Cohort("Cohort 30");

            Instructor Billy = new Instructor("Billy", "Bob", "billyslack");
            Instructor John = new Instructor("John", "Bob", "johnslack");
            Instructor Paul = new Instructor("Paul", "Bob", "paulslack");
            Instructor Alan = new Instructor("Alan", "Bob", "alanslack");

            Student Niall = new Student("Niall", "Fraser", "niallf92");
            Student Wyatt = new Student("Wyatt", "Fraser", "wyattf");
            Student Brittany = new Student("Brittany", "Cookson", "bcooks");
            Student Muzz = new Student("Muzza", "Sinclair", "muzzsinc");

            Exercise goldenrod = new Exercise("Goldenrod", "Javascript");
            Exercise celtic = new Exercise("celtic", "C#");
            Exercise ross = new Exercise("Ross County", "HTML");
            Exercise alness = new Exercise("Alness", "Javascript");

            // add methods
            Cohort30.StudentList.Add(Niall);
            Cohort30.StudentList.Add(Muzz);

            Cohort29.StudentList.Add(Wyatt);

            Cohort28.StudentList.Add(Brittany);

            Cohort30.Instructors.Add(Billy);
            Cohort28.Instructors.Add(John);
            Cohort29.Instructors.Add(Paul);
            Cohort30.Instructors.Add(Alan);

            Billy.AssignExercise(Muzz, goldenrod);
            Billy.AssignExercise(Muzz, celtic);

            John.AssignExercise(Brittany, celtic);
            John.AssignExercise(Brittany, goldenrod);

            Paul.AssignExercise(Wyatt, celtic);
            Paul.AssignExercise(Wyatt, ross);

            Alan.AssignExercise(Niall, goldenrod);
            Alan.AssignExercise(Niall, alness);


            Cohort28.StudentList.Add(Brittany);
            Cohort30.StudentList.Add(Niall);
            Cohort29.StudentList.Add(Muzz);
            Cohort30.StudentList.Add(Wyatt);

            List<Student> StudentList = new List<Student>();
            StudentList.Add(Brittany);
            StudentList.Add(Niall);
            StudentList.Add(Muzz);
            StudentList.Add(Wyatt);

            List<Exercise> ExerciseList = new List<Exercise>();
            ExerciseList.Add(goldenrod);
            ExerciseList.Add(celtic);
            ExerciseList.Add(ross);
            ExerciseList.Add(alness);



            foreach (Student student in StudentList)
            {
                Console.WriteLine($@"
{student.FirstName} {student.LastName}
Exercises:");
                foreach (Exercise exercise in student.ExerciseList)
                {
                    Console.WriteLine($"{exercise.ExerciseName}");
                }
            }
        }
    }
}
