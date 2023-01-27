// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int num = new Random().Next();
int temp = num;
int reverseNum = 0;

    while(temp > 0)
        {
            reverseNum = (reverseNum * 10) + (temp % 10);
            temp = temp / 10;
        }
    
    if(reverseNum == num)
        {
            System.Console.WriteLine($"{num} -> yes");
        }
    
    else
        {
            System.Console.WriteLine($"{num} -> no");
        }       