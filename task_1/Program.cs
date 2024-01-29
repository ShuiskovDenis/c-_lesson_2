// task_01

// Напишем программу, которая на вход
// пронимает два целых числа и проверяет,
// является ли первое число корнем второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да 
// a = -3, b = 9 => нет 

/*
int firstNumber = 25; 
int secondNumber = 5;

if (secondNumber * secondNumber == firstNumber)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/
//////////////////////////////////////////////////

// task_02
// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

/*
int N = 4;
int negativeN = -N;

while (negativeN <= N)
{
    Console.Write(negativeN + " ");
    negativeN++;
}
*/
//////////////////////////////////////////////////

// task_03
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// int number = 435;
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int res = firstDigit + thirdDigit;
// Console.WriteLine("Результат -> " + res);
//////////////////////////////////////////////////

// task_04v.01
// На входе имеетcя три числа, найти максимальное из них.

// int a = 7;
// int b = 2;
// int c = 3;
// int max = 0;
// char numberNameMax = 'a';

// if (max < a){
//     max = a;
//     numberNameMax = 'a';
// };

// if (max < b){
//     max = b;
//     numberNameMax = 'b';
// };

// if (max < c){
//     max = c;
//     numberNameMax = 'c';
// }

// Console.WriteLine("Максимальное число -> "+ numberNameMax + " = " + max);

// task_04_v.02

// int a = 5;
// int b = 6;
// int c = 7; 

// if (a > b && a > c){
//     Console.WriteLine(a);
// }
// else if (b > a && b > c){
//     Console.WriteLine(b);
// }
// else if (c > a && c > b){
//     Console.WriteLine(c);
// }

////////////////////////////////////////////////////////////////////////////

// task_05
// На входе имеется число(number), а на выходе выводит все 
// четные числа от 1 до number (включительно), после каждого 
// числа должен быть знак пробела.

// int number = 6;
// int i = 1;

// while (number > i){
//     if (i % 2 == 0){
//         Console.Write(i + " ");
//     }
//     i++;
// }