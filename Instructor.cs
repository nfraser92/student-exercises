using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string SlackHandle {get; set;}

        public string Cohort { get; set;}

        public Instructor (string fname, string lname, string slack)
        {
            FirstName = fname;
            LastName = lname;
            SlackHandle = slack;
        }

        public void AssignExercise (Student student, Exercise exercise)
        {
                student.ExerciseList.Add(exercise);
        }
    }
}