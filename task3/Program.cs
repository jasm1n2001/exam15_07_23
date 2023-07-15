int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for(int i=0; i<n; i++)
{
    arr[i]=int.Parse(Console.ReadLine());
}
Array.Sort(arr);
Array.Reverse(arr);

for(int i=0; i < n; i++)
{
    System.Console.WriteLine($"{arr[i]}");
}

