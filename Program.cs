using System;
class UserInput
{
public static void Main(string[] args)
{ 
int? studentAge;
double? studentCGPA;
bool? isRegitered;
    Console.Write("Enter user Name: ");
      string? studentName =Console.ReadLine();
   Console.WriteLine("welcome vr mode "+ studentName);

Console.Write("Enter Your Age: ");
studentAge=Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Age: "+ studentAge +" Years Old");

Console.Write("Enter student CGPA: ");
studentCGPA=Convert.ToDouble(Console.ReadLine());
Console.WriteLine( "CGPA: "+ studentCGPA);


Console.Write("Have You aleready Registered: ");
isRegitered=Convert.ToBoolean(Console.ReadLine());
Console.Write( "Student's Registration: "+ isRegitered +" is registered");


}

}