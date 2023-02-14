//LAB 4
//start main
int input=0;
while(input!=3)
{
    System.Console.WriteLine("Would you like to generate full(1) or partial(2) triangles? (3 to exit): ");
    input = int.Parse(Console.ReadLine());
    if(input == 1)
        GetFull();
    if(input == 2)
        GetPartial();
    if(input!=1 && input!=2 && input!=3)
    {
        System.Console.WriteLine("Input not recognized");
        continue;
    }
}
//end main
static void GetFull()
{
    System.Console.WriteLine("\n");
    int rowNumber=0, totalRows;
    Random rnd = new Random();
    totalRows = rnd.Next(7);
    totalRows+=3;
    for(rowNumber=0; rowNumber<totalRows ;rowNumber++)//generates each line of triangle
    {
        for(int x = 0; x<=rowNumber; x++)
        {
            System.Console.Write("0");
        }
        System.Console.Write("\n");
    }
    System.Console.WriteLine("\nGenerated a triangle with " + totalRows + " rows");
}
static void GetPartial()
{
    System.Console.WriteLine("\n");
    int rowNumber=0, totalRows;
    Random rnd = new Random();
    totalRows = rnd.Next(7);
    totalRows+=3;
    Random rnd2 = new Random();
    for(rowNumber=0; rowNumber<totalRows ;rowNumber++)
    {
        for(int x = 0; x<=rowNumber; x++)//generates each line of triangle
        {
            int empty = rnd2.Next(2);//randomizes whether space is empty
            if(empty == 0)
                System.Console.Write("0");
            if(empty == 1)
                System.Console.Write(" ");
        }
        System.Console.Write("\n");
    }
    System.Console.WriteLine("\nGenerated a triangle with " + totalRows + " rows");
}