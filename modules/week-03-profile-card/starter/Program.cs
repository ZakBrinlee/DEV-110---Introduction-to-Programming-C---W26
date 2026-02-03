/*
 * Rin Peralez  Intro to C# DEV110 Week 3 Assignment
 * 02/02/2026
 * Profile Card
 * This program is a profile card that allows the user to input their information and displays it in a formatted card.
 */


namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
    Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Please enter your full name: ");
        string fullName = Console.ReadLine();
        Console.WriteLine("Please enter your hometown: (city, state)");
        string hometown = Console.ReadLine();
        Console.WriteLine("Please enter your favorite color: ");
        string favoriteColor = Console.ReadLine();
        Console.WriteLine("Please enter your dream job: ");
        string dreamJob = Console.ReadLine();


        Console.WriteLine("Please enter your major: ");
        string major = Console.ReadLine();
        Console.WriteLine("Please enter your GPA: ");
        double gpa = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your graduation year: ");
        int graduationYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter if you are a full-time student: (yes/no)");
        string isFullInput = Console.ReadLine();
        bool isFullTime = isFullInput.ToLower() == "yes";


        Console.WriteLine("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your height in inches: ");
        double heightInches = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());


        int birthYear = 2026 - age;
        int yearsToGrad = graduationYear - 2026;
        int feet = (int)(heightInches / 12);
        double inches = heightInches % 12;
        bool isHonorStudent = gpa >= 3.5;
        int ageInMonths = age * 12;
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║            STUDENT PROFILE CARD            ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        Console.WriteLine("   °❀⋆.ೃ࿔*   PERSONAL INFORMATION   ⋆°.☾⋆.ೃ࿔*:⋆");
        Console.WriteLine("═══════════════════════════════════════════════");
        Console.WriteLine($" ⋆ Name:           {fullName}");
        Console.WriteLine($" ⋆ Age:            {age}");
        Console.WriteLine($" ⋆ Hometown:       {hometown}");
        Console.WriteLine($" ⋆ Favorite Color: {favoriteColor}");
        Console.WriteLine($" ⋆ Dream Job:      {dreamJob}");
        Console.WriteLine($" ⋆ Height:         {feet}' {inches}\"");

        Console.WriteLine();

        Console.WriteLine("   °❀⋆.ೃ࿔*    ACADEMIC DETAILS   ⋆°.☾⋆.ೃ࿔*:⋆");
        Console.WriteLine("═══════════════════════════════════════════════");
        Console.WriteLine($" ⋆ Major:          {major}");
        Console.WriteLine($" ⋆ GPA:            {gpa:F2}");
        Console.WriteLine($" ⋆ Honor Student:  {(isHonorStudent ? "Yes" : "No")}");
        Console.WriteLine($" ⋆ Grad Year:      {graduationYear}");
        Console.WriteLine($" ⋆ Status:         {(isFullTime ? "Full-Time" : "Part-Time")}");
        Console.WriteLine();


        Console.WriteLine("   °❀⋆.ೃ࿔*  CALCULATED STATISTICS  ⋆°.☾⋆.ೃ࿔*:⋆");
        Console.WriteLine("═══════════════════════════════════════════════");
        Console.WriteLine($" ⋆ Birth Year:     {birthYear}");
        Console.WriteLine($" ⋆ Age in Months:  {ageInMonths} months)");
        Console.WriteLine($" ⋆ Favorite #:     {favoriteNumber}");
        Console.WriteLine($" ⋆ Years to Grad:  {yearsToGrad}");
        Console.WriteLine();

        Console.WriteLine("      °⋆.ೃ࿔*:･ 𓆝 𓆟 𓆞 ·｡ °‧ 𓆝 𓆟 𓆞 °⋆.ೃ࿔*:･");
        Console.WriteLine("\n══════════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
