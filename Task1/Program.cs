/*
1. Создать массив на 5 элементов
2. Заполнить его целыми числами
3. Вывести эдементы на экран
*/

int[] array = new int[5];
array[0] = 5;
array[1] = 7;
array[2] = 5;
array[3] = 4;
array[4] = 3;

System.Console.WriteLine(array[0]);
System.Console.WriteLine(array[1]);
System.Console.WriteLine(array[2]);
System.Console.WriteLine(array[3]);
System.Console.WriteLine(array[4]);
System.Console.WriteLine(array[5]);

// Присвоение значений при создании массива

int[] array2 = new int[5] { 5, 7, 5, 4, 3 };

// Если массив не большой - упрощенный способ

int[] array3 = { 5, 7, 5, 4, 3 };