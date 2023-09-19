using System.Linq;

Console.WriteLine("Welk woord wil je omkeren");
Console.WriteLine("");
string woord = Console.ReadLine();
Console.WriteLine("Welke methode wil je gebruiken?");
Console.WriteLine("Methode 1: for loop");
Console.WriteLine("Methode 2: while loop");
Console.WriteLine("Methode 3: do while loop");
Console.WriteLine("Methode 4: for recursie");
Console.WriteLine("");
int keuze = Convert.ToInt32(Console.ReadLine());

char[] array1 = woord.ToArray();
List <char> list = new List <char>();

switch  (keuze)
{
    case 1:
        for (int i = array1.Length-1; i >= 0; i--)
        {
            list.Add(array1[i]);

        }


        break;

    case 2:
        int j = array1.Length-1;
        while(j >= 0)
        {
            list.Add(array1[j]);
            j--;
        }

        break;

    case 3:

        int k = array1.Length-1;
        do
        {
            list.Add(array1[k]);
            k--;
        } while (k >= 0);

        break;

    case 4:

        WoordOmkeren(array1.Length-1);
        

        break;
}
string antwoord = string.Join("",list.ToArray());

Console.WriteLine("Je woord omgekeerd is: "+antwoord);


List<char> WoordOmkeren(int l)
{
    if (l == 0)
    {
        list.Add(array1[l]);
        return null;
    }
    list.Add(array1[l]);
    return WoordOmkeren(l-1);
}