
using MoziJegyeladasFajlbol;
using System.Globalization;
using System.IO;

List<Film> filmek = new List<Film>();

Console.WriteLine("Adatok beolvasása a filmek.txt fájlból...");

Console.WriteLine("========================================");

foreach (string sor in File.ReadAllLines("filmek.txt").Skip(1))
{
    Film peldany = new Film();
    string[] darabolt = sor.Split(';');
    peldany.Cim=darabolt[0];
    peldany.EladottJegyek = int.Parse(darabolt[1]);
    peldany.JegyAr = int.Parse(darabolt[2]);
    filmek.Add(peldany);
}

Console.WriteLine("Vetített filmek és bevétlek:");

int OsszesJegy = 0;
int OsszesBevetel = 0;

foreach (Film film in filmek) 
{
    Console.WriteLine($"\t- {film.Cim}: {film.EladottJegyek} db jegy -> Bevétel: {film.EladottJegyek*film.JegyAr} Ft");
    OsszesJegy += film.EladottJegyek;
    OsszesBevetel += film.EladottJegyek * film.JegyAr;
}

double atlag = (double)OsszesJegy / (double)filmek.LongCount();

Console.WriteLine("----------------------------------------");
Console.WriteLine($"Összes eladott jegy: {OsszesJegy} db");
Console.WriteLine($"Összes napi jegybevétel: {OsszesBevetel} Ft");
Console.WriteLine($"Átlagos eladott jegyszám/film: {atlag:f0} db");
Console.WriteLine("========================================");
