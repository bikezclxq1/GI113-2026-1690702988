/*
* Student ID : 1690702988
* Name       : Assignment1
* Section    : 129C
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("+================================================================+");
            Console.WriteLine(" ____   ___  ____  _   _   _____ ___   __        _____ _   _   _ \r\n| __ ) / _ \\|  _ \\| \\ | | |_   _/ _ \\  \\ \\      / /_ _| \\ | | | |\r\n|  _ \\| | | | |_) |  \\| |   | || | | |  \\ \\ /\\ / / | ||  \\| | | |\r\n| |_) | |_| |  _ <| |\\  |   | || |_| |   \\ V  V /  | || |\\  | |_|\r\n|____/ \\___/|_| \\_\\_| \\_|   |_| \\___/     \\_/\\_/  |___|_| \\_| (_)");
            Console.WriteLine("+================================================================+");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      =..:..-+..=:==.:+:.:+-::-:.--.-@@@@@@@@@@@@@@@@@@@@@@      \r\n      =-:.#..:+-.=.#:+.:--.-:-:.--.+@..*@@@@@@@@@@@@@@@@@@@      \r\n      =-.::=.::=:.=.++:-.*-:.=--:.---#@@@@@@@@@@@@@@@@@@@@@      \r\n      --:..=-.:--.=-.+==::++:.==.--.+.#@@@@@@@@@@@@@@@@@@@@      \r\n      --+.:+-::.:=-:--:=:=:=-*==-::#=..#@@@@@@@@@@@@@@@@@@@      \r\n      -=+-.=.*: +::*#:*#%##+*-+==-:#@@*--@@@@@@@@@@@@@@@@@@      \r\n      --+.--.*=.*.--.-*=-..*#.=+=-+.@@@@@@%@@@@@@@@@@@@@@@@      \r\n      -:+.-: *=.+:#-.+*--=+#-:-+=::*-@@@@@@@@@@@@@@@@@@@@@@      \r\n      -.+*...*=:+-=-=***+==*-:..*..=%@@@@@@@@@@@@@@@@@@@@@@      \r\n      +.=:.::+=--=+*.=. ..   : .+.    ...+@@@@@@@@@@@@@@@@@      \r\n      +:*:-:--==--*==:       . :.    .:.=@@@@@@@@@@@@@@@*.-      \r\n      =**==:=.*.=-+=-=.                =@@@@@@@@@@@*:.:*@@@      \r\n      :++====:*..-*-=.-.                ..@@@@%-..*@@@@@@@@      \r\n      :.*---=*==.--.:-..=..          ..--++..+@@@@@@@@@@@@@      \r\n      :..--=+==.:=-:.=::. .:.      ..+=--%@@@@@@@@@@@@@@@@@      \r\n      =:.....--=...*.....               .*@@@@@@@@@@@@@@@@@      \r\n      .-..+-:-+.=:  .=.                 -@@@@@@@@@@@@@@@@@@      \r\n      -:: -==-..-:..                    .%@@@@@@@@@@@@@@@@@      \r\n      .+:-:-.:-..::.:-:..                :@@@@@@@@@@@@@@@@@      \r\n      ::*-.=.:::.....::::::.::::::--=:...%@@@@@@@@@@@@@@@@@      \r\n      =---:::. .:.   ....:.:::.:=*%@@@@@@@@@@@@@@@@@@@@@@@@      \r\n      :=::.-=.  ..     ..:.:...%@@@@@@@@@@@@@@@@@@@@@@@@@@@      \r\n      +:===..-..  .-.      .:...@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("+================================================================+");



            Console.ForegroundColor = ConsoleColor.DarkYellow;
            const string GameTitle = " BORN TO WIN ";

            var hunterName = "Miffy";
            var hunterTier = 'E';
            int hunterAge = 9;
            double hunterPower = 19.5;
            float moveSpeed = 22.9f;
            bool isGender = true;

            Console.WriteLine("+================================================================+");
            Console.WriteLine($"|                        {GameTitle}                           |");
            Console.WriteLine("+================================================================+");
            Console.WriteLine($"|                        HUNTER PROFILE                          |");
            Console.WriteLine("+================================================================+");
            Console.WriteLine($"|      Name : {hunterName}                                              |");
            Console.WriteLine($"|      Tier : {hunterTier}                                                  |");
            Console.WriteLine($"|      Age : {hunterAge}                                                   |");
            Console.WriteLine($"|      Power : {hunterPower}                                              |");
            Console.WriteLine($"|      Speed : {moveSpeed}                                              |");
            Console.WriteLine($"|      Male : {isGender}                                               | ");
            Console.WriteLine("+================================================================+");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("+================================================================+");
            Console.WriteLine($"|                       CONVERSION TEST                          |");
            Console.WriteLine("+================================================================+");
            Console.WriteLine("+================================================================+");
            double hunterAgeAsDouble = hunterAge; // implicit
            Console.WriteLine($"|      Age as double (implicit) : {hunterAgeAsDouble}                              |");

       
            int speedTruncated = (int)moveSpeed; // explicit
            int speedRounded = Convert.ToInt32(moveSpeed); // convert
            Console.WriteLine($"|      Speed cast : {speedTruncated}                                           |");
            Console.WriteLine($"|      Speed convert : {speedRounded}                                        |");
            Console.WriteLine("+================================================================+");
        }
    }
}