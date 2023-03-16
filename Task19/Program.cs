Console.Write ("Введите  5-ое число> ");
int n = Convert.ToInt32(Console.ReadLine());

if (n<10000 || n>99999)
    Console.WriteLine ("Некорретное число");
else if (n/10000==n%10 && (n/1000)%10==(n/10)%10)
    Console.WriteLine ("Палиндром!");
else 
    Console.WriteLine ("Не палиндром!");