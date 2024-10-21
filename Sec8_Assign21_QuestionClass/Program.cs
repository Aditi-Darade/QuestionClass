class Program
{
    static void Main()
    {
        //TO DO: Create an object of Question class and pass no arguments to the constructor
        Question q1 = new Question();
        //TO DO: Create an object of Question class and pass value for questionText only to the constructor.
        Question q2 = new Question("What is the capital of the USA?");
        //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD and correctAnswerLetter to the constructor.
        Question q3 = new Question("What is the capital of the USA?", "London", "New York", "Washington, D.C.", "San Diego", 'C');
        //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD only to the constructor.
        Question q4 = new Question() {questionText = "What is the capital of the USA?", optionA = "London", optionB = "New York", optionC = "Washington, D.C.", optionD = "San Diego" };
    }
}