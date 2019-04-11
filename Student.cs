using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string SlackHandle {get; set;}

        public string Cohort {get; set;}
        public List<Exercise> ExerciseList = new List<Exercise>();
        public Student (string fname, string lname, string slack)
        {
            FirstName = fname;
            LastName = lname;
            SlackHandle = slack;
        }
    }
}