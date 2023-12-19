
int[] nums = new int[10];
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(1, 101);
    Console.Write(nums[i] + " ");
}
int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] >= 20 && nums[i] <= 90);
    {
        count++;
    }

}
Console.WriteLine();
Console.WriteLine(count);


