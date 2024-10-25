using System;
using System.Text;
using System.Text.RegularExpressions;

class Question2
{
    static void Main()
    {
        string registrationDigits = "51"; 
        char firstNameChar = 'u';         
        char lastNameChar = 'h';          
        string favoriteMovieChars = "In"; 
        string specialChars = "@$%!&*";   
        int length = 14;


        Random random = new Random();
        StringBuilder password = new StringBuilder();

        
        password.Append(registrationDigits);
        password.Append(firstNameChar);
        password.Append(lastNameChar);
        password.Append(favoriteMovieChars);

        
        string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789" + specialChars;
        while (password.Length < length)
        {
            char nextChar = allowedChars[random.Next(allowedChars.Length)];
            if (nextChar != '#')
                password.Append(nextChar);
        }

        
        string regexPattern = @"^(?!.*#).{14}$";
        if (Regex.IsMatch(password.ToString(), regexPattern))
        {
            Console.WriteLine("Generated Password: " + password);
        }
        else
        {
            Console.WriteLine("Password generation failed to meet specifications.");
        }
    }
}