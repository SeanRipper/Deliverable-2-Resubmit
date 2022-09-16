
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;


Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee or juice. How many people are in your group? Please, parties of 6 or lower.");

int partysize = int.Parse(Console.ReadLine());
int guest1 = 1;
int guest2 = 2;
int guest3 = 3;
int guest4 = 4;
int guest5 = 5;
int guest6 = 6;
int bevC = 0;
int bevJ = 0;

if (partysize < 1)
{
    Console.WriteLine("I'm sorry, we cannot take a reservation for 0 people!");
    return;
}
else if (partysize > 6)

{
    Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
    return;
}
else if (partysize == 1)
{

    Console.WriteLine("A table for " + partysize + "! Please follow me and take a seat.");

    Console.WriteLine("Let's get everyone started with some drinks. We've got juice or coffee.");


    Console.WriteLine("");
    Console.WriteLine("Alright, person number " + guest1 + ", juice or coffee?");


    string orderfirst = Console.ReadLine();

    if (orderfirst == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfirst + ", good choice!");
        bevJ += 1;
    }
    else if (orderfirst == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfirst + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
}
else if (partysize == 2)
{
    Console.WriteLine("A table for " + partysize + "! Please follow me and take a seat.");

    Console.WriteLine("Let's get everyone started with some drinks. We've got juice or coffee.");


    Console.WriteLine("");
    Console.WriteLine("Alright, person number " + guest1 + ", juice or coffee?");

    string orderfirst = Console.ReadLine();

    if (orderfirst == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfirst + ", good choice!");
        bevJ += 1;
    }
    else if (orderfirst == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfirst + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }

    Console.WriteLine("Alright, person number " + guest2 + ", juice or coffee?");
    string ordersecond = Console.ReadLine();

    if (ordersecond == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(ordersecond + ", good choice!");
        bevJ += 1;
    }
    else if (ordersecond == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(ordersecond + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
}
else if (partysize == 3)
{
    Console.WriteLine("A table for " + partysize + "! Please follow me and take a seat.");

    Console.WriteLine("Let's get everyone started with some drinks. We've got juice or coffee.");


    Console.WriteLine("");
    Console.WriteLine("Alright, person number " + guest1 + ", juice or coffee?");

    string orderfirst = Console.ReadLine();

    if (orderfirst == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfirst + ", good choice!");
        bevJ += 1;
    }
    else if (orderfirst == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfirst + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }

    Console.WriteLine("Alright, person number " + guest2 + ", juice or coffee?");
    string ordersecond = Console.ReadLine();

    if (ordersecond == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(ordersecond + ", good choice!");
        bevJ += 1;
    }
    else if (ordersecond == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(ordersecond + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine("Alright, person number " + guest3 + ", juice or coffee?");
    string orderthird = Console.ReadLine();

    if (orderthird == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderthird + ", good choice!");
        bevJ += 1;
    }
    else if (orderthird == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderthird + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
}

else if (partysize == 4)
{
    Console.WriteLine("A table for " + partysize + "! Please follow me and take a seat.");

    Console.WriteLine("Let's get everyone started with some drinks. We've got juice or coffee.");


    Console.WriteLine("");
    Console.WriteLine("Alright, person number " + guest1 + ", juice or coffee?");

    string orderfirst = Console.ReadLine();

    if (orderfirst == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfirst + ", good choice!");
        bevJ += 1;
    }
    else if (orderfirst == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfirst + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }

    Console.WriteLine("Alright, person number " + guest2 + ", juice or coffee?");
    string ordersecond = Console.ReadLine();

    if (ordersecond == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(ordersecond + ", good choice!");
        bevJ += 1;
    }
    else if (ordersecond == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(ordersecond + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine("Alright, person number " + guest3 + ", juice or coffee?");
    string orderthird = Console.ReadLine();

    if (orderthird == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderthird + ", good choice!");
        bevJ += 1;
    }
    else if (orderthird == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderthird + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine("Alright, person number " + guest4 + ", juice or coffee?");
    string orderfourth = Console.ReadLine();

    if (orderfourth == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfourth + ", good choice!");
        bevJ += 1;
    }
    else if (orderfourth == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfourth + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
}

else if (partysize == 5)
{
    Console.WriteLine("A table for " + partysize + "! Please follow me and take a seat.");

    Console.WriteLine("Let's get everyone started with some drinks. We've got juice or coffee.");


    Console.WriteLine("");
    Console.WriteLine("Alright, person number " + guest1 + ", juice or coffee?");

    string orderfirst = Console.ReadLine();

    if (orderfirst == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfirst + ", good choice!");
        bevJ += 1;
    }
    else if (orderfirst == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfirst + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }

    Console.WriteLine("Alright, person number " + guest2 + ", juice or coffee?");
    string ordersecond = Console.ReadLine();

    if (ordersecond == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(ordersecond + ", good choice!");
        bevJ += 1;
    }
    else if (ordersecond == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(ordersecond + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine("Alright, person number " + guest3 + ", juice or coffee?");
    string orderthird = Console.ReadLine();

    if (orderthird == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderthird + ", good choice!");
        bevJ += 1;
    }
    else if (orderthird == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderthird + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine("Alright, person number " + guest4 + ", juice or coffee?");
    string orderfourth = Console.ReadLine();

    if (orderfourth == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfourth + ", good choice!");
        bevJ += 1;
    }
    else if (orderfourth == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfourth + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine("Alright, person number " + guest5 + ", juice or coffee?");
    string orderfifth = Console.ReadLine();

    if (orderfifth == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfifth + ", good choice!");
        bevJ += 1;
    }
    else if (orderfifth == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfifth + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
}

else if (partysize == 6)
{
    Console.WriteLine("A table for " + partysize + "! Please follow me and take a seat.");

    Console.WriteLine("Let's get everyone started with some drinks. We've got juice or coffee.");


    Console.WriteLine("");
    Console.WriteLine("Alright, person number " + guest1 + ", juice or coffee?");

    string orderfirst = Console.ReadLine();

    if (orderfirst == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfirst + ", good choice!");
        bevJ += 1;
    }
    else if (orderfirst == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfirst + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }

    Console.WriteLine("Alright, person number " + guest2 + ", juice or coffee?");
    string ordersecond = Console.ReadLine();

    if (ordersecond == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(ordersecond + ", good choice!");
        bevJ += 1;
    }
    else if (ordersecond == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(ordersecond + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine("Alright, person number " + guest3 + ", juice or coffee?");
    string orderthird = Console.ReadLine();

    if (orderthird == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderthird + ", good choice!");
        bevJ += 1;
    }
    else if (orderthird == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderthird + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine("Alright, person number " + guest4 + ", juice or coffee?");
    string orderfourth = Console.ReadLine();

    if (orderfourth == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfourth + ", good choice!");
        bevJ += 1;
    }
    else if (orderfourth == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfourth + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine("Alright, person number " + guest5 + ", juice or coffee?");
    string orderfifth = Console.ReadLine();

    if (orderfifth == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfifth + ", good choice!");
        bevJ += 1;
    }
    else if (orderfifth == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(orderfifth + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
    Console.WriteLine("Alright, person number " + guest6 + ", juice or coffee?");
    string ordersixth = Console.ReadLine();

    if (ordersixth == "juice")
    {
        Console.WriteLine("");
        Console.WriteLine(ordersixth + ", good choice!");
        bevJ += 1;
    }
    else if (ordersixth == "coffee")
    {
        Console.WriteLine("");
        Console.WriteLine(ordersixth + ", good choice!");
        bevC += 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("We don't have that. No drink for you!");
    }
}

    Console.WriteLine("");
double totalbuffet = (partysize * 9.99);
double finalbuffet = Math.Round(totalbuffet, 2);
double totaljuice = (bevJ * 1.99);
double finaljuice = Math.Round(totaljuice, 2);
double totalcoffee = (bevC * 2.99);
double finalcoffee = Math.Round(totalcoffee, 2);
double totalprice = finalbuffet + finalcoffee + finaljuice;

double finalprice = Math.Round(totalprice, 2);

Console.WriteLine("Okay, so that's " + bevC + " coffees and " + bevJ + " juices. I'll be right back. Feel free to grab your food!");
Console.WriteLine("Here's your bill!");
Console.WriteLine("Total Price: " + finalprice);
Console.WriteLine(partysize + " buffets = " + partysize + " x 9.99 = " + finalbuffet);
Console.WriteLine(bevC + " coffees = " + bevC + " x 2.99 = " + finalcoffee);
Console.WriteLine(bevJ + " juices = " + bevJ + " x 1.99 = " + finaljuice);
