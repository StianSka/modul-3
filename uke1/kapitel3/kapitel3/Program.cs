namespace kapitel3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            giveMeValues(nums);
            Array.Resize(ref nums, nums.Length +1 );
            nums[nums.Length-1] = 4;
            giveMeValues(nums);
        }
        static void giveMeValues(int[] arg)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                Console.WriteLine(arg[i]);
            }
            Console.WriteLine("lengde er: " + arg.Length);
        }
    }
}