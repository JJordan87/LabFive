//hopw to let user search by user name - can use if string input.all 

string[] studentNames = { "Justin", "Lucas", "Aaliyah", "Jon", "Tarik", "Alex", "Josh" };
string[] studentFavFoods = { "Baja Blast", "Sushi", "Chicken Wings", "Bacon", "Tacos", "Spaghetti", "Nalesniki" };
string[] studentHometown = { "Wyoming", "Louisville", "Manchester", "Toledo", "Queens NY", "Ferndale", "Cali" };
bool continueProgram = true;


while (continueProgram)
{
    Console.WriteLine("Enter a number (1 through 7) to select a student to learn more about. Or enter [10] to see a list of available students");
    int userStudentSelection = int.Parse(Console.ReadLine());

    //search by name?

    if (userStudentSelection == 10)
    {
        foreach (string studentName in studentNames)
        {
            Console.WriteLine(studentName);
        }
    }
    else if (userStudentSelection -1 < 0 || userStudentSelection -1 > studentNames.Length -1)
    {
        Console.WriteLine("This is not a valid number. Please select a number from 1 to 7. Or enter [10] to see a list of available students");
    }
    else
    {
        string studentSelected = studentNames[userStudentSelection-1];
        Console.WriteLine("You have selected " + studentNames[userStudentSelection-1]);
        while (true)
        {

            Console.WriteLine($"To find out {studentSelected}'s hometown enter [hometown] or enter [favorite food] if you would like to learn what their favorite food is.");
            string user2ndChoice = Console.ReadLine().ToLower().Trim();

            if (user2ndChoice == "hometown")
            {
                Console.WriteLine($"{studentSelected}'s hometown is {studentHometown[userStudentSelection-1]}");
                break;
            }
            else if (user2ndChoice == "favorite food")
            {
                Console.WriteLine($"{studentSelected}'s favorite food is {studentFavFoods[userStudentSelection-1]}");
                break;
            }
            else
            {
                Console.WriteLine("The text entered is incorrect. Please try again. Your options are [favorite food] or [hometown]");
                continueProgram = true;
            }

        }
    }
    while (true)
    {
        Console.WriteLine("Would you like to learn about another student? Enter [y] or [n]");
        string userChoice = Console.ReadLine().ToLower().Trim();
        if (userChoice == "y")
        {
            continueProgram = true;
            break;
        }
        else if (userChoice == "n")
        {
            continueProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("That was not a valid input.");
            continueProgram = true;
        }
    }
}

//methods
//user2ndChoice


