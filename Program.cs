string[] arr = new  string[5];
arr[0] = ":-)";
arr[1] = "Denmark";
arr[2]="world";
arr[3]="22";
arr[4]="1232";
string[] array = ThreeSimvols(arr);

if(array.Length==0)
{
    Console.Write("[]");
}
else
{
    for(int i =0;i<array.Length;i++)
    {
        if(i==0)
        {
                Console.Write("[");
        }
       
            Console.Write(array[i]+" ");
       if(i==array.Length-1)
        {
                Console.Write("]");
                break;
        } 
    }
}



string[] ThreeSimvols(string[] array)
{
    int count =0;
    for(int i =0;i<array.Length;i++)
    {
        if(array[i].Count()<=3)
        {
            count++;
        }
    }
    string[] arrayLast = new string[count];
    int j=0;
        for(int i =0;i<array.Length;i++)
    {
        if(array[i].Count()<=3)
        {
            arrayLast[j] = array[i];
            j++;
        }
    }
    return arrayLast;
} 