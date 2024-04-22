namespace CalculoIRRF_INSS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculoINSS = new CalculoINSS();

            Console.WriteLine("DIgite o Salario Bruto:");
            string salarioBruto = Console.ReadLine();
            Convert.ToDouble(salarioBruto);

            var memo = calculoINSS.CalcularDesconto(Convert.ToDouble(salarioBruto));

            double descontoINSS = memo.Desconto;

            ImpostoDeRenda imposto = new ImpostoDeRenda(Convert.ToDouble(salarioBruto), descontoINSS);

            Console.WriteLine($"Salário Bruto: {salarioBruto:C}");

            Console.WriteLine($"Desconto INSS: {descontoINSS:C}");

            Console.WriteLine($"Salário Base: {imposto.CalcularSalarioBase():C}");

            Console.WriteLine($"IRRF: {imposto.CalcularIRRF():C}");
        }
    }
}
