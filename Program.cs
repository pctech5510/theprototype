// See https://aka.ms/new-console-template for more information


//Build a program that will allow a user, the pilot, to enter a number.
//If the number is above 100 or less than 0, keep asking.
//Clear the screen once the program has collected a good number.
//Ask a second user, the hunter, to guess numbers.
//Indicate wether the user guessed to high, too low, or guessed it right.
//Loop until tey get it right, then end the program.

int pilot;
do
{
    Console.Write("Pilot, Please choose a number between 0 and 100: ");
    int guess = Convert.ToInt32(Console.ReadLine());
    pilot = Convert.ToInt32(guess);

}
while (pilot < 0 || pilot > 100);

Console.Clear();

int hunter;
do
{
    Console.WriteLine("Hunter, guess a number: ");
    int user2 = Convert.ToInt32(Console.ReadLine());
    if (user2 < pilot)
    {
        if (user2 > pilot)
        {
            Console.WriteLine("Number is to high. Guess again");
        }
        Console.WriteLine("Number is to low. Guess again");
    }
    else hunter = Convert.ToInt32(user2);
}
while (hunter == pilot);

 Console.WriteLine($"{hunter} was the correct guess!");

