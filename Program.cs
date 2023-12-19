
// int[] nums = new int[10];
// for (int i = 0; i < nums.Length; i++)
// {
//     nums[i] = new Random().Next(1, 101);
//     Console.Write(nums[i] + "|");
// }
// int count = 0;
// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i] >= 20 && nums[i] <= 90)
//     {
//         count++;
//     }

// }
// Console.WriteLine();
// Console.WriteLine(count++);

// -----------------------------------------------------------------

// int[] nums = new int[10];
// for (int i = 0; i < nums.Length; i++)
// {
//     nums[i] = new Random().Next(1, 41);
//     Console.Write(nums[i]+ ", ");
// }
// int count = 0;
// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i] % 2 == 0)
//     {
//         count++;
//     }

// }
// Console.WriteLine();
// Console.WriteLine(+count);

// -----------------------------------------------------------------

double[] array = new double[6];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    string result = string.Format("{0:0.00}", array[i]);
    Console.Write(result + " | ");
}

double maxElement = array[0];
double minElement = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxElement)
    {
        maxElement = array[i];
    }
    if (array[i] < minElement)
    {
        minElement = array[i];
    }
}
double razn = maxElement - minElement;
string result_2 = string.Format("{0:0.00}" , razn );
Console.WriteLine();
Console.WriteLine("Разность " + result_2);





