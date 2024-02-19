using System.ComponentModel.Design;

string name = "Ewa";
// zastanawiałem czy czy przy wyborze płci da sie użyć bool
string sex = "women";
int age = 30;

if (sex == "women" && age < 30)
{
    Console.WriteLine("kobieta poniżej 30lat");
}

else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
// początkowy pomysł zakładał użycie jej w tym miejscu czyli w 3 if-ie natomiast nie miałem za bardzo pomysłu jak to rozgryźć
else if (sex != "women" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
