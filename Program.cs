(int,int) ConvertMToHM(int nbMin)
{
    return(nbMin/60, nbMin%60);
}

// Programme principal
(int H, int M) = ConvertMToHM(215);
Console.WriteLine($"{H}:{M}");