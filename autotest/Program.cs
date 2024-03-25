// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};

// int num = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= 10 && array[i] <= 90)
//     {
//         num = array[i];
//         Console.Write(num + ", ");
//     }
// }



// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};

// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         count = count + 1;
       
//     }   
// }
// Console.WriteLine(count);   




double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
       max = array[i];
    }
    else if (array[i] < min)
    {
       min = array[i];
    }
}
double sum = max + min;
Console.WriteLine(sum);