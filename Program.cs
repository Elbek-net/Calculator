//Calculator
Console.WriteLine("Birinchi raqamni kriting: ");
int firstnumber=int.Parse(Console.ReadLine());
Console.WriteLine("Ikkinchi raqamni kriting: ");
int secondnumber=int.Parse(Console.ReadLine());

if (firstnumber > secondnumber)
{
    Console.WriteLine("Firstnumber is bigger  than Secondnumber.");
}
else if(firstnumber == secondnumber)
{
     Console.WriteLine("They are equal."); 
}
else
Console.WriteLine("Firstnumber is smaller than Secondnumber.");
