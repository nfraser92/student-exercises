using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string SlackHandle {get; set;}

        public Cohort Cohort { get; set;}

        public Instructor (string fname, string lname, string slack, Cohort cohort)
        {
            FirstName = fname;
            LastName = lname;
            SlackHandle = slack;
            Cohort = cohort;
        }

        public void AssignExercise (Student student, Exercise exercise)
        {
                student.ExerciseList.Add(exercise);
        }
    }
}