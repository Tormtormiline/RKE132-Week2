﻿// See https://aka.ms/new-console-template for more information

// rakendus küsib kasutajalt tema sugu  (m/f)
//rakendus küsib kasutajalt sisestada oma perekonnanimi 
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = char.Parse(Console.ReadLine()); // loeb konsoolist maha andmeid string (sõna) formaadis

Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}

else if (userGender == 'f') ;
{
    Console.WriteLine($"Welcome, M. {userLastName} !");
}



