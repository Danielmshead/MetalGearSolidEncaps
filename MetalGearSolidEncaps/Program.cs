namespace MetalGearSolidEncaps
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Boleto>boletos= new List<Boleto>();
            boletos.Add(new Boleto(200));
            boletos.Add(new Boleto(300));
            boletos.Add(new Boleto(400));

            Fatura fatura = new Fatura("Daniel", 900);

            ProcessaBoleto pdb = new ProcessaBoleto();

            pdb.Processa(boletos, fatura);

            Console.WriteLine(fatura.Pago);
            Console.ReadKey();
        }
    }
}