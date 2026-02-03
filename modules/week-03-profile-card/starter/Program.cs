namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");


        Console.Write("Full name: ");
        string fullName = Console.ReadLine();

        Console.Write("Hometown (city, state): ");
        string hometown = Console.ReadLine();

        Console.Write("Favorite color: ");
        string favoriteColor = Console.ReadLine();

        Console.Write("Dream job: ");
        string dreamJob = Console.ReadLine();



        Console.Write("Major/field of study: ");
        string major = Console.ReadLine();

        Console.Write("Current GPA (0.0 - 4.0): ");
        double gpa = double.Parse(Console.ReadLine());

        Console.Write("Graduation year: ");
        int graduationYear = int.Parse(Console.ReadLine());

        Console.Write("Are you a full-time student? (yes/no): ");
        bool isFullTimeStudent = Console.ReadLine().Trim().ToLower() == "yes";


        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Height in inches: ");
        double heightInches = double.Parse(Console.ReadLine());
        Console.Write("Favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());


        const int CURRENT_YEAR = 2026;
        int birthYear = CURRENT_YEAR - age;
        int yearsToGraduation = graduationYear - CURRENT_YEAR;

        int heightFeet = (int)(heightInches / 12);
        double remainingInches = heightInches % 12;

        bool isHonorStudent = gpa >= 3.5;
        int ageInMonths = age * 12;



        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("PERSONAL INFORMATION");
        Console.WriteLine($"Name: {fullName}");
        Console.WriteLine($"Hometown: {hometown}");
        Console.WriteLine($"Favorite Color: {favoriteColor}");
        Console.WriteLine($"Dream Job: {dreamJob}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {heightFeet} ft {remainingInches:F2} in");
        Console.WriteLine($"Favorite Number: {favoriteNumber}");

        Console.WriteLine("\nACADEMIC DETAILS");
        Console.WriteLine($"Major: {major}");
        Console.WriteLine($"GPA: {gpa:F2}");
        Console.WriteLine($"Graduation Year: {graduationYear}");
        Console.WriteLine($"Full-Time Student: {(isFullTimeStudent ? "Yes" : "No")}");

        Console.WriteLine("\nCALCULATED STATISTICS");
        Console.WriteLine($"Birth Year: {birthYear}");
        Console.WriteLine($"Years Until Graduation: {yearsToGraduation}");
        Console.WriteLine($"Honor Student: {(isHonorStudent ? "Yes" : "No")}");
        Console.WriteLine($"Age in Months: {ageInMonths}");
        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
