 int n = int.Parse(Console.ReadLine());
string[] arr = new string[n];

for(int i=0; i<n; i++)
{
    arr[i]=Console.ReadLine();
}

for(int i=0; i<n; i++)
{
    System.Console.WriteLine($"{arr[i]}");
}

