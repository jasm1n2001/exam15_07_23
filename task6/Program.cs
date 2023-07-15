int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int i = 0; i<=n; i++)
{
    sum += 2 ^ i;
}
System.Console.WriteLine($"{sum}");

