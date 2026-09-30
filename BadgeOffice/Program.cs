

//Part 1: The Name

//Initializing strings defined inside the while loops.
string fullName = "";
string badgeName = "";
string confirmation = "";

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

