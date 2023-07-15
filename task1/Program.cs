int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int minn = 0;
var resalt = FindMinn(a,b,c,d);
System.Console.WriteLine($"{resalt}");

int FindMinn(int a, int b, int c, int d)
{
    int minn = 0;
    if(a < b && a < c && a < d)minn = a;
    if(b < a && b < c && b < d) minn =  b;
    if(c < a && c < b && c < d)minn = c;
    if(d < a && d < b && d < c) minn =  d;
    return minn; 
}
