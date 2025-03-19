// Convertir un nb de minutes au format H:M
// Paramètre d'entrée:
// - nbMin: nombre de minutes à convertir
// Valeur de retour: nbMin au format H:M

(int, int) ConvertMToHM(int nbMin)
{
    return (nbMin / 60,nbMin % 60);
}

// Programme Principal
int nbMinutes;

Console.WriteLine("Saisir un nombres de minutes");
nbMinutes = Convert.ToInt32(Console.ReadLine());
(int H,int M) = ConvertMToHM(nbMinutes);
Console.WriteLine($"{H}:{M}");