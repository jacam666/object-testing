using System;
using object_testing.People;


namespace object_testing
{

    class Program
    {     
        static void Main(string[] args)
        {
            Person person = new();

            person.Name = "ja cam";
            person.age = 42;
            person.HasPet = false;

            person.Greeting();
        }












        //    static void Main(string[] args)
        //    {

        //        ChestWorkout workOutPlan = new ChestWorkout();
        //        Exercises workOutExercises = new Exercises();
        //        workOutPlan.numberOfSets = 20;
        //        workOutPlan.numberOfRepsPerSets = 10;
        //        workOutPlan.restBetweenSets = 60;
        //        workOutExercises.FlatBench = firstExercise;

        //        Console.WriteLine();
        //    }
        //}
        //public class ChestWorkout
        //{
        //    public int numberOfSets;
        //    public int numberOfRepsPerSets;
        //    public int restBetweenSets;
        //    public Exercises workoutExercises = new Exercises();

        //}
        //public class Exercises
        //{
        //    public string FlatBench;
        //    public string InclineBench;
        //    public string CableFlyes;
        //    public string InclineDumbbellPress;
        //    public string PecDec;
        //}







    }

}



