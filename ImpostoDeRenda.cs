namespace CalculoIRRF_INSS
{
    public class ImpostoDeRenda
    {
        private double _salarioBruto;
        private double _descontoINSS;


        public ImpostoDeRenda(double salarioBruto, double descontoINSS)
        {
            _salarioBruto = salarioBruto;
            _descontoINSS = descontoINSS;
        }

        public double CalcularSalarioBase()
        {
            return _salarioBruto - _descontoINSS;
        }

        public double CalcularIRRF()
        {
            double salarioBase = CalcularSalarioBase();
            double irrf = 0;

            if (salarioBase <= 2259.20)
            {
                irrf = 0;
            }
            else if (salarioBase <= 2826.65)
            {
                irrf = salarioBase * 0.075 - 169.44;
            }
            else if (salarioBase <= 3751.05)
            {
                irrf = salarioBase * 0.15 - 381.44;
            }
            else if (salarioBase <= 4664.68)
            {
                irrf = salarioBase * 0.225 - 662.77;
            }
            else
            {
                irrf = salarioBase * 0.275 - 869.36;
            }

            return Math.Max(irrf, 0);
        }
    }

}