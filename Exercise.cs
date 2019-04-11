using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Exercise
    {
        public string ExerciseName {get; set;}

        public string ExerciseLanguage {get; set;}

        public Exercise (string name, string lang)
        {
            ExerciseName = name;
            ExerciseLanguage = lang;
        }
    }
}