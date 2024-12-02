namespace Vaques;

public class Vaca
{
    public string Nom { get; }
    public int Pes { get; }
    public int LitresPerDia { get; }

    public Vaca(string nom, int pes, int litresPerDia)
    {
        Nom = nom;
        Pes = pes;
        LitresPerDia = litresPerDia;
    }
    
    
}