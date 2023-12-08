namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string ourCat = "Sushi";
            int numberOfKids = 4;
            char numberOfDogs = '2';
            bool havePets = true;
            double gradePointAverage = 97.5;
            decimal costPerSemester = 72255.00m;

            Console.WriteLine($"The Sedlacek family is a big, busy family with {numberOfKids} kids. " +
                $"Three of the kids are in college right now at a cost of ${costPerSemester:N2} per semester,OUCH! " +
                $"At least they are all good students and their combined gpa's are {gradePointAverage}!  " +
                $"\n We also have four legged \"family\"; a cat named {ourCat} and {numberOfDogs} dogs, Dazzle " +
                $"and Venice.  \n It's {havePets.ToString().ToLower()} that most days can be a little chaotic, but there is lots " +
                $"and lots of LOVE that fills our home.");



            
        }
    }
}
