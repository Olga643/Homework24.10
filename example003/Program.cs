// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// пример из 5 элементов:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();

Console.WriteLine("Введите элементы массива");
string phrase = Console.ReadLine()??"";
string[] nums = phrase.Split (',');
int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i] = int.Parse(nums[i]);

}
Console.WriteLine( string.Join("\n", array));