using Humanizer;
using System.Globalization;

static IEnumerable<string> Companies()
{
    yield return "Ibis Hotels";
    yield return "Spar";
    yield return "McDonalds";
    yield return "Bavet";
    yield return "KRC Genk";
    yield return "Burger King";
    yield return "Otomat";
    yield return "Holiday Inn";
    yield return "Van Der Valk";
    yield return "Versuz";
}

const string StrobboHeadline= "AutomatiseerJePersoneelsplanningEnTijdregistratie";
const string StrobboSummary = "Een_All_in_oplossing_met_payroll_integratie,_automatische_Dimona_aangifte_en_digitale_tikklok";

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Strobbo!");

List<int> rankings = [];
Random random = new();
foreach (var company in Companies())
{
    int ranking = random.Next(1, 10);
    rankings.Add(ranking);
    Console.WriteLine($"Hello {company}: {ranking.ToWords()}.");
}
Console.WriteLine($"Prize: {(rankings.Average() * 100).ToString("C", CultureInfo.CreateSpecificCulture("da-DK"))}");

Console.WriteLine($"{StrobboHeadline.Humanize()}");
Console.WriteLine($"{StrobboSummary.Humanize()}");
