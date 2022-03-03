
using System.Settings;
using System.Generic.Collections;
using System.Text;
using System.IO;

public class Main : NicknameList
{

    public static String MainGenerator()
    {

        String[] userName;


        Console.log("Are you a person or is this for your pet? (Enter 1 for person or 2 for pet): \n");
        Console.WriteLine(userInput);

        if (userInput == 1)
        {
            userStringMale();

            Console.log("Your generated nickname is: " + nickNames[usernickNameMale]);
        }
        if (userInput == 2)
        {
            userStringAnimals();

            Console.log("Your pets generated nickname is: " + nickNames[usernickNameAnimal]);
        }
        else
        {
            Console.log("Enter 1 or 2 please: \n");
            Console.WriteLine(userInput);
        }

    }
    public static String userStringMale(String usernickNameMale)
    {

        Random rnd = new Random();
        //Takes random element from array   
        int usernickNameMale = rnd.Next(nickNamesMale.length);

        return usernickNameMale;
    }


    public static String userStringAnimals(String usernickNameAnimal)
    {
        Random rando = new Random();
        //Takes random element from array
        int usernickNameAnimal = rando.Next(nickNamesAnimals.length);

        return usernickNameAnimal;
    }

}

