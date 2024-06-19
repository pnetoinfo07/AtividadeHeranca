using Atividade2;

Pessoa p = new Pessoa();
p.Nome = "Paulo";
p.Idade = 18;
Console.WriteLine($"Meu nome é {p.Nome}, tenho {p.Idade} anos");

Estudante e = new Estudante();
e.Nome = "André";
e.Idade = 30;
e.Matricula = 1;
Console.WriteLine($"Meu nome é {e.Nome}, Sou estudante e possuo a matrícula: {e.Matricula} tenho {e.Idade} anos");
