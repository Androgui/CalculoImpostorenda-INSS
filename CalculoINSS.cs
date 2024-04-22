namespace CalculoIRRF_INSS
{
    public class CalculoINSS
    {
        private List<INSS> tabela = new List<INSS>();
        private float desconto;

        public CalculoINSS()
        {
            tabela.Add(new INSS(0, 1_412.00f, 0.075f));
            tabela.Add(new INSS(1_412.01f, 2_666.68f, 0.090f));
            tabela.Add(new INSS(2_666.69f, 4_000.03f, 0.120f));
            tabela.Add(new INSS(4_000.04f, 7_786.02f, 0.140f));
        }

        public MemoINSS CalcularDesconto(double salarioBruto)
        {
            var memoriaCalculo = new MemoINSS();
            memoriaCalculo.SalarioBruto = (float)salarioBruto;

            foreach (var faixa in tabela)
            {
                var valorFaixa = faixa.CalcularItervaloFaixa((float)salarioBruto);
                memoriaCalculo.Desconto += AplicarAliquota(valorFaixa, faixa.aliquota);

                if (faixa.FaixaContemValor((float)salarioBruto))
                    return memoriaCalculo;
            }

            return memoriaCalculo;
        }

        private float AplicarAliquota(float valor, float aliquota)
        {
            return valor * aliquota;
        }
    }
}