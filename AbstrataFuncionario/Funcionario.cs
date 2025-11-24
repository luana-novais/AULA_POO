namespace AbstrataFuncionario
{
    public abstract class Funcionario
    {
        protected int codigo;
        protected string? nome;
        protected Endereco endereco;
        protected double salario;

        public List<Dependente> vetD { get; set; }

        public Funcionario(int codigo, string? nome, Endereco endereco, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Endereco = endereco;
            Salario = salario;
            vetD = new List<Dependente>();
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string? Nome { get => nome; set => nome = value; }

        public Endereco Endereco
        {
            get => endereco;
            set => endereco = value;
        }

        public double Salario { get => salario; set => salario = value; }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo} Nome: {Nome} Salário {Salario:c}");
        }

        public abstract double CalcularSalario(int diasUteis);

        public int CalcularTotalDependente() => vetD.Count;

        public void AdicionarDependente(Dependente novoDep) => vetD.Add(novoDep);

        public void RemoverDependentesMaioridade(int codigo)
        {
            vetD.RemoveAll(d => d.Codigo == codigo && d.VerificarMaiorIdade());
        }

        public void ListarDependentes()
        {
            foreach (var dep in vetD)
            {
                Console.WriteLine($"{dep.Codigo} - {dep.Nome} ({dep.Idade} anos)");
            }
        }
    }
}
