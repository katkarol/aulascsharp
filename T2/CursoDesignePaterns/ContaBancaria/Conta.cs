using CursoDesignePaterns.ContaBancaria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignePaterns
{
    public class Conta
    {

        public Conta(double saldo)
        {
            if (saldo > 0)
            {
                EstadoAtual = new Positivo(); 
            }
            else
            {
                EstadoAtual = new Negativo();
            }
        }

        public double Saldo { get; private set; }
        public EstadoConta EstadoAtual { get; set; }
        public void Deposita(double valor)
        {
            this.Saldo = EstadoAtual.Depositar(this,valor);
        }
        public void Sacar(double valor)
        {
            EstadoAtual.Sacar(this, valor);
        }
    }
}
