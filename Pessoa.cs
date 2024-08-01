public class Pessoa
{
    public string Nome { get; private set; }
    public int Idade { get; private set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}";
    }
}
