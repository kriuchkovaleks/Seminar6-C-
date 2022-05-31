/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/



int AmountOfPositiveNumbers(int amount)
{
    int [] array = new int [amount];
    int summ = 0; 
    for (int i = 0; i < amount; i++)
    {
        Console.WriteLine("Введите число: ");
        array [i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
            summ = summ + 1;
        
    }
    return summ; 
}


Console.WriteLine("Какое количество цифр Вы хотите ввести");
int amountOfNumbers = Convert.ToInt32(Console.ReadLine());

int result = AmountOfPositiveNumbers(amountOfNumbers);

Console.WriteLine($"Колличество положительных чисел: {result}");
