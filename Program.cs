using SilentAuctionConsole.Classes;


main();

void main()
{
    SilentAuction silentauction = new();
    bool login = silentauction.Login();

    Console.WriteLine("All Users: ");
    foreach (User user in silentauction.Users)
    {
        Console.WriteLine($"User ID: {user.ID}, User username: {user.Username}");
    }
    if (login)
    {
        Console.WriteLine($"Current Logged in user: {silentauction.LoggedInUser.Username}");
    }
    else
    {
        Console.WriteLine("No logged in user");
    }


}



