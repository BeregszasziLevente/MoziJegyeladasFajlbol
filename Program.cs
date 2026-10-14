
using MoziJegyeladasFajlbol;
using System.Globalization;
using System.IO;

List<Film> filmek = new List<Film>();
string[] sorok = File.ReadAllLines("filmek.txt");

foreach (string sor in sorok)
{
    Film peldany = new Film();
    string[] darabolt = sor.Split(';');
    peldany.Cim=darabolt[0];
    peldany.EladottJegyek = int.Parse(darabolt[1]);
    peldany.JegyAr = int.Parse(darabolt[2]);
}