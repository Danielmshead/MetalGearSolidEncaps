using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalGearSolidEncaps
{
    public class ProcessaBoleto
    {
        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {

            foreach (Boleto boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
                fatura.AdicionaPagamento(pagamento);
            }
        }
    }
}
