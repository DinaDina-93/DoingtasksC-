// вводить натуральное число,определить ли четное и окончивается ли на цифру 7
Console.Clear();
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string CheckNumber(int num)

{
    if (num < 0) return "число отрицательное";
    if (number / 10 == 0) return "не вверное число!";
    if (number == 0) return "0 -> не является натуральным";
    if (number % 10 == 7) return "не четное!, оканчивается на 7!";
    if (number % 2 == 0) return " четное!, не оканчивается на 7!";
    if (number % 2 == 1) return "не четное!, не оканчивается на 7!";
    return "incorrect";
}
string resOut  = CheckNumber(number);
Console.WriteLine(resOut);

// if (number % 2 == 0)
// {
//     Console.WriteLine($"число {number } - > четное!");
// }
// else
// {
//     Console.WriteLine($"число {number } - > не четное!");
// }
// if(number % 10 == 7)
// {
//     Console.WriteLine($"число {number } - > yes 7!!");
// }
// else
// {
//     Console.WriteLine($"число {number } - > no 7!");
// }