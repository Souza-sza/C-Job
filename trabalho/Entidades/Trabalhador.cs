
using trabalho.Entidades;

namespace trabalho.Entidades
{
    internal class Trabalhador
    {
        public string Nome { get; set; }
        public TrabalhoNivel Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>();
        public Trabalhador() { }

        public Trabalhador(string nome, TrabalhoNivel nivel, double salarioBase, Departamento departamentos)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamentos;
        }
        public void AdicionarContrato(HoraContrato contrato)
        {
            Contratos.Add(contrato);
        }
        public void RemoveContrato(HoraContrato contrato)
        {
            Contratos.Remove(contrato);
        }
        public double ganho (int ano, int mes)
        {
            double soma = SalarioBase;
            foreach(HoraContrato contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.TotalValor();
                }
            }
            return soma;
        } 
    }
}
