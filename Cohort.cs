using System;
using System.Collections.Generic;

namespace StudentExercises
{
   public class Cohort
    {
        public string CohortName {get;}

        public List<Student> StudentList = new List<Student>();
        public List<Instructor> Instructors = new List<Instructor>();

        public Cohort (string name)
        {
            CohortName = name;
        }

    }
}