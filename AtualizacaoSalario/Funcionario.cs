using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtualizacaoSalario {
        internal class Funcionario {
        public String Name;
        public Double SalarioBruto;
        public Double Imposto;

        public Double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentoSalarial(double porcentagem) {
            SalarioBruto = (SalarioBruto + (SalarioBruto * porcentagem / 100));
        }

        public override String ToString() {
            return Name
                + ", Salário atualizado para R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
