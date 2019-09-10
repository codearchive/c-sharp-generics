namespace module_07
{
    public class MathProblem
    {
        // Add this part to Main()
       


        private static double SampledAverage(double[] numbers)
        {
            var count = 0;
            var sum = 0.0;
            for (int i = 0; i < numbers.Length; i += 2)
            {
                sum += numbers[i];
                count += 1;
            }
            return sum / count;
        }
    }
 
}
