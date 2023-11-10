// Her ligger dictionary med en liste over studenter og deres informasjon
Dictionary<string, List<string>> StudentRegister = new Dictionary<string, List<string>>();
    List<string> StudentInfo1 = new List<string> { "Håkon Sunde", "16", "101" };
    List<string> StudentInfo2 = new List<string> { "Ola Hagen Bendixen", "16", "261" };
    List<string> StudentInfo3 = new List<string> { "John Doe", "17", "398" };
    List<string> StudentInfo4 = new List<string> { "Lebron James", "38", "423" }; 

// Disse er student ideene som brukes til å søke mellom studentene senere i koden, slik at maskinenen kan finne dem i dictionary
    StudentRegister["101"] = StudentInfo1;
    StudentRegister["261"] = StudentInfo2;
    StudentRegister["398"] = StudentInfo3;
    StudentRegister["423"] = StudentInfo4;

// Et set med forskjellige fagkoder som jeg bruker lenger ned hvor man skal skrive inn karakter til de forskjellige fagene
HashSet<string> fagkoder = new HashSet<string>();
    fagkoder.Add("ENG");
    fagkoder.Add("NOR");
    fagkoder.Add("MAT");
    fagkoder.Add("NAT");

// Lagde en liste for karakterene brukeren skriver inn lenger ned, som er derfor den er tom
List<string> karakterer = new List<string>();

// Ber om studentnummeret, som jeg i den andre if løkken sjekker om samsvarer med noen fra studentregisteret øverst, som er hvorfor vi har linje 9-12
Console.Write("Skriv inn Student nummer: ");
string? brukerInput = Console.ReadLine();

// Ekstre feature som spør brukerenen om de ønsker å skrive inn karakterer eller ikke, dersom de sier ja fortsetter koden som vanlig ved å skrive inn karakterer, skriver de nei blir de automatisk sendt til informasjonen om studenten de øsnket å se på, karakterer står da som ikke oppgitt
Console.Write("Vil du sette inn karakterer til denne studenten? (y/n): ");
string? karakterInput = Console.ReadLine();

if (karakterInput.ToLower() == "y".ToLower()) // Condition i if løkken sjekker om brukeren sa "y"
{

if (StudentRegister.ContainsKey(brukerInput)) // Sjekker om studentregister har keyen som brukerene skrev inn
{

    Console.WriteLine("Skriv inn karakterer: ");

    while (true)
        {

        foreach (string fagkode in fagkoder) // Foreach løkke som går gjennom alle fagkodene og ber brukeren skrive inn karakter til disse, verdien fra karakterene som skrives inn blir lagret i listen jeg lagde litt lenger oppe
            {
                Console.Write($"{fagkode}: ");
                string? karakter = Console.ReadLine();
                karakterer.Add($"{fagkode}: {karakter}");
            }
            
            break;
        }
// Skriver ut all informasjonen om studenten som ble valgt, inkludert karakterene som akkurat ble gitt
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
    else // Hvis keyen ikke eksisterer i studentregisteret blir det error
    {
        Console.WriteLine("Fant ikke student.");
    }
} 
else if (karakterInput.ToLower() == "n".ToLower()) // Sjekker om brukeren skrev inn "n"
{
    Console.WriteLine("Student ID: ");
    Console.WriteLine($"Navn: {StudentRegister[brukerInput][0]}");
    Console.WriteLine($"Alder: {StudentRegister[brukerInput][1]}");
    Console.WriteLine($"Student nummer: {StudentRegister[brukerInput][2]}");

    Console.WriteLine("Karakterer: Ikke oppgitt");
}
else // Error hvis brukerenen ikke skrev inn enten y eller n 
{
    Console.WriteLine("Velg enten y eller n");
}