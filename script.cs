Dictionary<string, List<string>> StudentRegister = new Dictionary<string, List<string>>();
    List<string> StudentInfo1 = new List<string> { "Håkon Sunde", "16", "1" };
    List<string> StudentInfo2 = new List<string> { "Ola Hagen Bendixen", "16", "2" };
    List<string> StudentInfo3 = new List<string> { "John Doe", "17", "3" };

    StudentRegister["1"] = StudentInfo1;
    StudentRegister["2"] = StudentInfo2;
    StudentRegister["3"] = StudentInfo3;
        
HashSet<string> fagkoder = new HashSet<string>();
    fagkoder.Add("ENG");
    fagkoder.Add("NOR");
    fagkoder.Add("MAT");
    fagkoder.Add("NAT");

List<string> karakterer = new List<string>();

Console.Write("Skriv inn Student nummer: ");
string? brukerInput = Console.ReadLine();

Console.Write("Vil du sette inn karakterer til denne studenten? (y/n): ");
string? karakterInput = Console.ReadLine();

if (karakterInput.ToLower() == "y".ToLower())
{

if (StudentRegister.ContainsKey(brukerInput))
{

    Console.WriteLine("Skriv inn karakterer: ");

    while (true)
        {

        foreach (string fagkode in fagkoder)
            {
                Console.Write($"{fagkode}: ");
                string? karakter = Console.ReadLine();
                karakterer.Add($"{fagkode}: {karakter}");
            }

            break;
        } 

        Console.WriteLine("\nStudent ID: ");
        Console.WriteLine($"Navn: {StudentRegister[brukerInput][0]}");
        Console.WriteLine($"Alder: {StudentRegister[brukerInput][1]}");
        Console.WriteLine($"Student nummer: {StudentRegister[brukerInput][2]}\n");
        
        Console.WriteLine("Karakterer: ");
        Console.WriteLine($"{karakterer[0]}");
        Console.WriteLine($"{karakterer[1]}");
        Console.WriteLine($"{karakterer[2]}");
        Console.WriteLine($"{karakterer[3]}");

    } 
    else 
    {
        Console.WriteLine("Fant ikke student.");
    }
} 
else if (karakterInput.ToLower() == "n".ToLower())
{
    Console.WriteLine("Student ID: ");
    Console.WriteLine($"Navn: {StudentRegister[brukerInput][0]}");
    Console.WriteLine($"Alder: {StudentRegister[brukerInput][1]}");
    Console.WriteLine($"Student nummer: {StudentRegister[brukerInput][2]}");

    Console.WriteLine("Karakterer: Ikke oppgitt");
}
else
{
    Console.WriteLine("Velg enten y eller n");
}