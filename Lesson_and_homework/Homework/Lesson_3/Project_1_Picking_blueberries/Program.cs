﻿/**
*!В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке,
*!причем кусты высажены только по окружности. Таким образом, у каждого куста есть ровно два соседних. 
*!Всего на грядке растет N кустов.

*!Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число 
*!ягод – на i-ом кусте выросло ai ягод.

*!В этом фермерском хозяйстве внедрена система автоматического сбора черники. 
*!Эта система состоит из управляющего модуля и нескольких собирающих модулей. Собирающий модуль за один заход,
*!находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним.

*!Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход 
*!собирающий модуль, находясь перед некоторым кустом заданной во входном файле грядки.
*/
Console.Clear();
int a = new Random().Next(3, 11);
int[] array = new int[a];
Console.WriteLine(a);
int max = 0;
int sum = 0;
for (int i = 0; i < a; i++)
    array[i] = new Random().Next(1, 10);
for (int j = 1; j < (a - 1); j++)
{
    sum = array[j] + array[j - 1] + array[j + 1];
    if (sum > max)
        max = sum;
}
int last = array[0] + array[^1] + array[^2];
int preLast = array[0] + array[1] + array[^1];
if (last > max)
    max = last;
if (preLast > max)
    max = preLast;
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(max);
