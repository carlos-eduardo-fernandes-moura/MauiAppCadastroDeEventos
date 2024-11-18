namespace MauiAppCadastroDeEventos.Models
{
    public class Eventos()
    {
        public string nome { get; set; }
        public Local local { get; set; }
        public int qnt_dias { get; set; }
        public string temBebidaAlcolica { get; set; }
        public double valor
        {
            get
            {
                if (this.temBebidaAlcolica == "Sim")
                {
                    double valorSim=(local.valorDiaria + 10) * this.qnt_dias;
                    return valorSim;
                }
                else
                {
                   double valorNao = (local.valorDiaria * this.qnt_dias);
                   return valorNao;

                }
            }
        }
    }
}
