using System;
using System.Collections.Generic;
using System.Linq;

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

            Instructor Billy = new Instructor("Billy", "Bob", "billyslack", Cohort28);
            Instructor John = new Instructor("John", "Bob", "johnslack", Cohort29);
            Instructor Paul = new Instructor("Paul", "Bob", "paulslack", Cohort30);
            Instructor Alan = new Instructor("Alan", "Bob", "alanslack", Cohort30);

            Student Niall = new Student("Niall", "Fraser", "niallf92", Cohort28);
            Student Wyatt = new Student("Wyatt", "Fraser", "wyattf", Cohort29);
            Student Brittany = new Student("Brittany", "Cookson", "bcooks", Cohort30);
            Student Muzz = new Student("Muzza", "Sinclair", "muzzsinc", Cohort30);
            Student Rory = new Student("Rory", "Sinclair", "rorysinc", Cohort29);

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
            Paul.AssignExercise(Niall, celtic);


            Cohort28.StudentList.Add(Brittany);
            Cohort30.StudentList.Add(Niall);
            Cohort29.StudentList.Add(Muzz);
            Cohort30.StudentList.Add(Wyatt);

            List<Student> StudentList = new List<Student>();
            StudentList.Add(Brittany);
            StudentList.Add(Niall);
            StudentList.Add(Muzz);
            StudentList.Add(Wyatt);
            StudentList.Add(Rory);

            List<Exercise> ExerciseList = new List<Exercise>() {
                goldenrod,
                ross,
                celtic,
                alness
            };

            // ExerciseList.ForEach(e => Console.WriteLine($"{e.ExerciseName}"));


            List<Cohort> AllCohorts = new List<Cohort>() {
                Cohort28,
                Cohort29,
                Cohort30
            };

            // AllCohorts.ForEach(c => Console.WriteLine($"{c.CohortName}"));

            List<Instructor> AllInstructors = new List<Instructor>() {
                John,
                Billy,
                Paul,
                Alan
            };

            //            foreach (Student student in StudentList)
            //             {
            //                 Console.WriteLine($@"
            // {student.FirstName} {student.LastName}
            // Exercises:");
            //                 foreach (Exercise exercise in student.ExerciseList)
            //                 {
            //                     Console.WriteLine($"{exercise.ExerciseName} which is an exercise in {exercise.ExerciseLanguage}");
            //                 }
            //             }

            // List exercises for the JavaScript language by using the Where() LINQ method.
            IEnumerable<Exercise> JavascriptExercises = from Exercise in ExerciseList
                                                        where Exercise.ExerciseLanguage == "Javascript"
                                                        select Exercise;

            // IEnumerable<Exercise> JavascriptExercises = ExerciseList.Where(e => e.ExerciseLanguage =="Javascript");

            foreach (Exercise e in JavascriptExercises)
            {
                // Console.WriteLine($"{e.ExerciseName}: {e.ExerciseLanguage}");
            }

            // List students in a particular cohort by using the Where() LINQ method.

            // IEnumerable<Student> CohortStudentList = from Student in StudentList
            //                                          where Student.Cohort == Cohort30
            //                                          select Student;

            IEnumerable<Student> CohortStudentList = StudentList.Where(s => s.Cohort == Cohort30);

             foreach (Student student in CohortStudentList)
             {
                //  Console.WriteLine($"{student.FirstName} {student.LastName}");
             }

            //  List instructors in a particular cohort by using the Where() LINQ method.
            // IEnumerable<Instructor> CohortTeachingTeam = from Instructor in AllInstructors
            //                                              where Instructor.Cohort == Cohort28
            //                                              select Instructor;

            IEnumerable<Instructor> CohortTeachingTeam = AllInstructors.Where(i => i.Cohort == Cohort29);

            foreach (Instructor instructor in CohortTeachingTeam)
             {
                //  Console.WriteLine($"{instructor.FirstName} {instructor.LastName}");
             }

            //  Sort the students by their last name.
            IEnumerable<Student> SortedStudents = StudentList.OrderByDescending(s => s.LastName);

            foreach (Student student in SortedStudents)
             {
                //  Console.WriteLine($"{student.LastName}");
             }

            //  Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            IEnumerable<Student> NotWorkingOnExercise = StudentList.Where(s => s.ExerciseList.Count == 0);

            foreach (Student s in NotWorkingOnExercise)
            {
                // Console.WriteLine($"{s.FirstName} {s.LastName}");
            }
            // Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            Student StudentExerciseList = StudentList.OrderByDescending(s => s.ExerciseList.Count).First();

            Console.WriteLine($"{StudentExerciseList.FirstName} is working on {Niall.ExerciseList.Count} exercises.");
            // How many students in each cohort?
            foreach (Cohort cohort in AllCohorts)
            {
                IEnumerable<Student> StudentsInCohort = StudentList.Where(s => s.Cohort == cohort);

                if (StudentsInCohort.Count() == 1)
                {
                    Console.WriteLine($"There is 1 student in {cohort.CohortName}");
                } else
                {
                    Console.WriteLine($"In {cohort.CohortName} there are {StudentsInCohort.Count()} students.");
                }
            }







        }
    }
}
