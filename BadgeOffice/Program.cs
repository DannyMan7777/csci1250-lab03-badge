

//Part 1: The Name

//Initializing strings defined inside the while loops.
using System.Security.Cryptography.X509Certificates;

string fullName = "";
string badgeName = "";
string confirmation = "";

#nullable disable //Because I anatehmatize all these presumptuous little sallow and jaundiced underscrawls INCESSANTLY SCREAMING AT ME ABOUT POTENTIAL NULL VALUES YEAH WHAT IF I NULLIFY YOU HOW YOU LIKE THEM APPLES?
while (true) //Part 1 employs a while loop to allow confirmation that the student entered their name correctly.
{
    System.Console.WriteLine("Please provide your full name:");
    fullName = Console.ReadLine();
    fullName = fullName.Trim();

    badgeName = fullName.ToUpper();

    while (true) //A (y/n) input handles the confirmation; the if creates some robustness in the case of any unexpected
                 //(string-compliant) inputs.
    {
        System.Console.WriteLine($"\n{badgeName}");
        System.Console.WriteLine("Is this correct? (y/n)");
        confirmation = Console.ReadLine();
        confirmation = confirmation.ToLower();

        if (confirmation == "y" || confirmation == "n")
        {
            break;
        }

        else
        {
            System.Console.WriteLine("\nInvalid input recieved: expecting \"y\" or \"n\".");
        }
    }

    if (confirmation == "n")
    {
        //If the student has entered their name incorrectly, an "n" returns the program to the initial name input.
    }

    else
    {
        break;
    }

}
#nullable restore

System.Console.WriteLine($"Badge name: {badgeName}");

int spacePosition = badgeName.IndexOf(" ");
string username = badgeName.ToLower();
username = username.Remove(1, spacePosition);

System.Console.WriteLine($"Username: {username}");

string lastName = badgeName.Substring(spacePosition + 1);
char firstInitial = badgeName[0];
char lastInitial = lastName[0];
string initials = $"{firstInitial}.{lastInitial}.";

System.Console.WriteLine($"Initials: {initials}");

int surnameLength = lastName.Length;

System.Console.WriteLine($"Length of surname: {surnameLength}");

//Part 2: The Numbers

Random rng = new Random();

int studentID = rng.Next(100000, 1000000);

System.Console.WriteLine($"\nStudent ID: {studentID}");

int lockerNumber = rng.Next(1, 501);

System.Console.WriteLine($"Locker: {lockerNumber}");

//Part 3: The Walk

System.Console.WriteLine("\nPlease provide the coordinates of your residence hall (feet, non nonnumeric values).");
System.Console.Write("x = ");
double dormX = Convert.ToDouble(Console.ReadLine());
System.Console.Write("y = ");
double dormY = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("\nPlease provide the coordinates of your class hall (feet, non nonnumeric values).");
System.Console.Write("x = ");
double classX = Convert.ToDouble(Console.ReadLine());
System.Console.Write("y = ");
double classY = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("\nPlease provide your walking speed in feet per second (no nonnumeric values): ");
double walkSpeed = Convert.ToDouble(Console.ReadLine());

double displacementX = dormX - classX;
double displacementY = dormY - classY;

double displacementXSquared = Math.Pow(displacementX, 2);
double displacementYSquared = Math.Pow(displacementY, 2);

double distance = Math.Sqrt(displacementXSquared + displacementYSquared);
double distanceRounded = Math.Round(distance, 2);

System.Console.WriteLine($"\nDistance from your dormitory to your classroom: {distanceRounded}ft");

double walkSeconds = distance / walkSpeed;
double walkTime = walkSeconds / 60;
TimeSpan walkTimeSpan = TimeSpan.FromMinutes(walkTime);

System.Console.WriteLine("\nWalking time from your dormitory to your classroom (mm:ss): " + walkTimeSpan.ToString(@"mm\:ss"));

