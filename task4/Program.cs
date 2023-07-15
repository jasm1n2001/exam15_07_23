int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int cnt=0;
for(int i=0; i<n; i++)
{
    arr[i]=int.Parse(Console.ReadLine());
}
Array.Sort(arr);

for(int i=0; i < n; i++)
{
   if(arr[i] > arr[i+1]) cnt++;
}
System.Console.WriteLine($"{cnt}");


