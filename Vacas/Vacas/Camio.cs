namespace Vaques;

public class Camio
{
    private int pesMaxim;
    private List<Vaca> vaques = new List<Vaca>();
    public Camio(int pes)
    {
        pesMaxim = pes;
    }

    private int ComptaElsKilosQuePortes()
    {
        var kilos = 0;
        foreach(var especimen in vaques)
        {
            kilos += especimen.Pes;
        }
        return kilos;
    }
    public bool PosarVaca(Vaca vaca)
    {
        // Quants kilos pesen les vaques actuals
        if (ComptaElsKilosQuePortes() + vaca.Pes > pesMaxim)
        {
            return false;
        }
        vaques.Add(vaca);
        return true;
    }

    public void TreureLesVaques()
    {
        vaques.Clear();
    }

    public int QuantaLletHiHa()
    {
        var litres = 0;
        foreach(var especimen in vaques)
        {
            litres += especimen.LitresPerDia;
        }
        return litres;
    }

    public string DonamElsNoms()
    {
        var resultat = "";
        foreach (var vaca in vaques)
        {
            resultat += vaca.Nom + " ";
        }

        return resultat;
    }
}