//Part 1: The Name

//Initializing strings defined inside the while loops.
string fullName = "";
string badgeName = "";
string confirmation = "";

#nullable disable //Because I anathematize all these presumptuous little sallow and jaundiced underscrawls and their null warnings.
while (true) //Here, I employ a while loop to confirm that the student entered their name correctly.
{
    System.Console.WriteLine("Please provide your full name:");
    fullName = Console.ReadLine();
    fullName = fullName.Trim();

    badgeName = fullName.ToUpper(); //From here on out, I use badgeName, which serves as the primary result of Part 1, rather than
                                    //fullName, which is only used to catch the input.

    while (true) //A (y/n) input handles the confirmation.
    {
        System.Console.WriteLine($"\n{badgeName}");
        System.Console.WriteLine("Is this correct? (y/n)");
        confirmation = Console.ReadLine();
        confirmation = confirmation.ToLower();

        if (confirmation == "y" || confirmation == "n") //This catches inputs besides (y/n).
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

//Alternatively, I could use two variables (firstName and lastName).
string firstName = badgeName.Substring(0, spacePosition);
string lastName = badgeName.Substring(spacePosition + 1);

username = firstName[0] + lastName;
username = username.ToLower();

System.Console.WriteLine($"Username: {username}");

char firstInitial = badgeName[0];
char lastInitial = badgeName[spacePosition + 1];
string initials = $"{firstInitial}.{lastInitial}.";

System.Console.WriteLine($"Initials: {initials}");

//badgeName[spacePosition + 1] achieves the same thing that lastName[0] does.
lastInitial = lastName[0];
initials = $"{firstInitial}.{lastInitial}.";

System.Console.WriteLine($"Initials: {initials}");

int surnameLength = lastName.Length;

System.Console.WriteLine($"Length of surname: {surnameLength}");

//Part 2: The Numbers

Random rng = new Random();

int studentID = rng.Next(100000, 1000000);
int checkDigit = studentID % 9;
string badgeID = studentID.ToString() + "-" + checkDigit.ToString();

System.Console.WriteLine($"\nStudent ID: {studentID}");

string lockerNumber = Convert.ToString(rng.Next(1, 501));

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
double walkMinutes = walkSeconds / 60;
TimeSpan walkTimeSpan = TimeSpan.FromMinutes(walkMinutes);

System.Console.WriteLine("\nWalking time from your dormitory to your classroom (mm:ss): " + walkTimeSpan.ToString(@"mm\:ss"));

//Equivalently, walking time can simply be displayed in plain English.
walkSeconds = Math.Round(walkSeconds, 0);
string intWalkMinutes = Convert.ToString((int)walkSeconds / 60);
string intWalkSeconds = Convert.ToString((int)walkSeconds % 60);

System.Console.WriteLine($"\nWalking time from your dormitory to your classroom: {intWalkMinutes} min {intWalkSeconds} sec");

//Part 4: The Badge

string badgeBar = new string('=', 34);
System.Console.WriteLine(badgeBar);
System.Console.WriteLine(new string("ETSU STUDENT BADGE").PadLeft(26));
System.Console.WriteLine(badgeBar);
System.Console.WriteLine(new string("NAME").PadRight(10) + badgeName);
System.Console.WriteLine(new string("USERNAME").PadRight(10) + username);
System.Console.WriteLine(new string("ID").PadRight(10) + badgeID);
System.Console.WriteLine(new string("LOCKER").PadRight(10) + lockerNumber);
System.Console.WriteLine(new string("WALK").PadRight(10) + intWalkMinutes + " min " + intWalkSeconds + " sec"); //Plain english makes more sense for a badge than TimeSpan format.
System.Console.WriteLine(badgeBar);