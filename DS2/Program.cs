//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int N,sum,num,temp;
string userEnter;

Console.Write ("Введите число N: ");
userEnter = Console.ReadLine()!;
N = int.Parse(userEnter);
temp=N;
sum=0;
while (temp>0)
{
    num=temp%10;
    sum=sum+num;
    temp=temp/10;
}
{
Console.Write($"сумма цифр {sum}");
}