namespace MicrosoftCodingAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = SmallInt([-1, -3]);

            Console.WriteLine("Hello, World!"+ result);
        }

        static int SmallInt(int[] A)
        {
            HashSet<int> positives = new HashSet<int>();

            foreach (var num in A)
            {
                if (num>0)
                {
                    positives.Add(num);
                }
            }

            int result = 1;
            while (positives.Contains(result))
            {
                result++;
            }
            return result;

            //Array.Sort(A);

            // get next positive number that is not in the array
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] - nums[i - 1] > 1)
            //    {
            //        return nums[i - 1] + 1;
            //    }
            //    else
            //    {
            //        //return first next positive number that is not in the array
            //        return 1;
            //    }
            //}

            //return nums[nums.Length]+1;
        }
    }
}