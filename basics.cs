using System;

public class Program
{
	public static void Main()
	{
		Program obj = new Program();
		int a = 1, b = 32;
		Console.WriteLine("SOMA:" + obj.calc(a, b));
		
		Aluno aluno = new Aluno("Vinícius Olímpio", 17);
		Console.WriteLine(aluno.getNome() + " " + aluno.getIdade());
		
		Console.Write("Digite o Nome do Aluno: ");
		string nome = Console.ReadLine();
		
		Console.Write("Digite a Idade do Aluno: ");
		int idade = int.Parse(Console.ReadLine());
		
		aluno.setNome(nome);
		aluno.setIdade(idade);
		
		bool maior = aluno.isMaiorIdade();
		
		Console.WriteLine("Nome alterado: {0}", aluno.getNome());
		Console.WriteLine("Idade alterada: {0}", aluno.getIdade());
		
		string text = maior ? "{0} é maior de idade!" : "{0} não é maior de idade!";
		Console.WriteLine(text, aluno.getNome());

	}
	
	public double calc(double a, double b){
		return a + b;
	}
}

public class Aluno
{
	private string nome;
	private int idade;
	public Aluno(String nome, int idade){ // constructor
		this.nome = nome;
		this.idade = idade;
	}
	
	public string getNome(){
		return this.nome;
	}
	
	public void setNome(String nome){
		this.nome = nome;
	}
	
	public void setIdade(int idade){
		this.idade = idade;
	}
	
	public int getIdade(){
		return this.idade;
	}
	
	public bool isMaiorIdade(){
		return this.idade >= 18;
	}
}