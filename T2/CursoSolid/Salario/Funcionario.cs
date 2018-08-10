namespace CursoSolid.Salario
{
    public class Funcionario
    {
        public Funcionario(Cargo cargo, double salarioBase)
        {
            Cargo = cargo;
            SalarioBase = salarioBase;
        }

        public Cargo Cargo { get; private set; }

        public double SalarioBase { get; private set; }

        public double CalcularSalario()
        {
            return Cargo.Regra.Calcula(this);
        }
        
    }
}