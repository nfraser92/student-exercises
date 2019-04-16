using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string SlackHandle {get; set;}

        public Cohort Cohort {get; set;}
        public List<Exercise> ExerciseList = new List<Exercise>();
        public Student (string fname, string lname, string slack, Cohort cohort)
        {
            FirstName = fname;
            LastName = lname;
            SlackHandle = slack;
            Cohort = cohort;
        }
    }
}