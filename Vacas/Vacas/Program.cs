namespace Vaques;

class Program
{
    static void Main(string[] args)
    {
       
        var camio = new Camio(700);

        List<Vaca> vaques = new List<Vaca>()
        {
            new Vaca("Maria", 360, 40),
            new Vaca("Pepa", 250, 35),
            new Vaca("Flor", 400, 43),
            new Vaca("Toñi", 180, 28),
            new Vaca("Conxita", 50, 12),
            new Vaca("Blanca", 90, 13),
        };
        
       
        var lletMaxima = 0;
        var nomsVaques = "";

        
        foreach (var vacaCandidata in vaques)
        {
            var hePogut = camio.PosarVaca(vacaCandidata);
            if (!hePogut)
            {
                if (camio.QuantaLletHiHa() > lletMaxima)
                {
                    lletMaxima = camio.QuantaLletHiHa();
                    nomsVaques = camio.DonamElsNoms();
                }
                camio.TreureLesVaques();
                camio.PosarVaca(vacaCandidata);
            }
        }
        
        Console.WriteLine($"Vaques {nomsVaques}: {lletMaxima} litres de llet");


    }
}