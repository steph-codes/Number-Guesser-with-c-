namespace NumberGuesser
{
    //Main class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); //Run Appinfo to get app details

            GreetUser(); // Ask for users name and greet

            while (true) {

                //Init Correct Number
                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();

                //Init Correct Number
                int correctNumber = random.Next(1,10);

                //Init guess var
                int guess = 0;

                //Ask User for number
                Console.WriteLine("Guess a number between 1 and 10");

                // Loop while guess is not correct 
                while(guess != correctNumber) {
                    // Get users input
                    string input = Console.ReadLine();
                    
                    // Make sure its a number 
                    if(!int.TryParse(input, out guess)) {
                        // Print error / color message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        //Keep Going
                        continue;
                    }  
                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber) {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number, Please Try Again");
                    }
                }
                //Output Success message and change text color
              
                PrintColorMessage(ConsoleColor.Yellow, "You Are CORRECT, You gussed it");

                // Ask to Play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get Answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y") {
                    continue;
                }
                else if(answer =="N"){
                    Console.WriteLine("Thanks for Playing, Bye");
                    return;
                }
                else{
                    return;
                }
            }
        }

        // fxn gets and display App infos
        static void GetAppInfo(){
            //set App vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "tunde Ogundele";

            //Change color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        //Displays user name and Greet
        static void GreetUser(){
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get User input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's Play a game", inputName);
        }

        //Print color Message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text color
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = color;

            //Write/ print out text
            //Console.WriteLine("Please enter an actual Number");
            Console.WriteLine(message);

            //Reset the color Back
            Console.ResetColor();

        }
    }
}
 