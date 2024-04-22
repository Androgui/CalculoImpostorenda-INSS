namespace CalculoIRRF_INSS
{
    public class INSS
    {
        public float faixaInicio { get; private set; }
        public float faixaFim { get; private set; }
        public float aliquota { get; private set; }

        public INSS(float valorInicio, float valorFim, float aliquota)
        {
            faixaInicio = valorInicio;
            faixaFim = valorFim;
            this.aliquota = aliquota;
        }

        public float CalcularItervaloFaixa(float valor)
        {
            if (valor < faixaFim)
                return valor - faixaInicio;

            return faixaFim - faixaInicio;
        }

        public bool FaixaContemValor(float valor)
        {
            return valor >= faixaInicio && valor <= faixaFim;
        }
    }
}