using SilentAuctionConsole.Classes;


main();

void main()
{
    Test();
    ShowIntroMenu();
}

void Test()
{
    SilentAuction silentauction = new();
    ConsoleMenu.ShowLoginMenu(silentauction);
    bool login = silentauction.Login();
    // bool login = false;


    if (login)
    {
        silentauction.CreateTestUsers();
        silentauction.CreateTestSilentAuction();
        silentauction.ViewAllAuctions();


        /*Console.WriteLine("All Users: ");
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
        */
    }
}

void ShowIntroMenu()
{
    // display welcome
    //string welcomeString = "Wecome to Silent Auction";
    //Console.WriteLine(welcomeString);
    //Console.WriteLine(new String('-', welcomeString.Length));



    // Console.WriteLine(response);


}
