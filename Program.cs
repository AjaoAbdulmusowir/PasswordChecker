// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.Write("Enter your password: ");
string password = Console.ReadLine();
Console.Write("Re-enter your password: ");
string confirmPassword = Console.ReadLine();

/*if (!password.Equals(string.Empty) && !confirmPassword.Equals(string.Empty))
{
    if (password.Equals(confirmPassword))
    {
        Console.WriteLine("Password match");
    }
    else
    {
        Console.WriteLine("Password do not match");
    }
}
else
{
    Console.WriteLine("Please enter your password");
} */



if (!password.Equals(string.Empty))
{
    if (!confirmPassword.Equals(string.Empty))
    {
        if (password.Length >=6 && confirmPassword.Length >=6)
        {
            if (password.Equals(confirmPassword))
            {
                Console.WriteLine("Password match");
            }
            else
            {
                Console.WriteLine("Password did not match");
            }
        }
        else 
        {
            Console.WriteLine("Enter 6 or more characters");
        }
    }
    else 
    {
        Console.WriteLine("Please enter password confirmation");
    }
}
else
{
    Console.WriteLine("Please enter a password");
}



// if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirmPassword))
// {
//     if (password.Length >= 6 && confirmPassword.Length >= 6)
//     {
//         if (password.Equals(confirmPassword))
//         {
//             Console.WriteLine("Password match.");
//         }
//         else
//         {
//             Console.WriteLine("Passwords do not match.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Password and confirmation must be at least 6 characters long.");
//     }
// }
// else
// {
//     Console.WriteLine("Please enter both password and confirmation.");
// }



