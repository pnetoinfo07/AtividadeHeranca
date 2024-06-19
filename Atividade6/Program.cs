using Atividade6;

List<InstrumentoMusical> lista = new List<InstrumentoMusical>();
Guitarra g1 =new Guitarra();
Guitarra g2 =new Guitarra();
Guitarra g3 =new Guitarra();
lista.Add(g1);
lista.Add(g2);
lista.Add(g3);
Piano p1 = new Piano();
Piano p2 = new Piano();
Piano p3 = new Piano();
Piano p4 = new Piano();
lista.Add(p1);
lista.Add(p2);
lista.Add(p3);
lista.Add(p4);

int ContadorPiano = 0;
int ContadorGuitarra = 0;

foreach(InstrumentoMusical i in lista)
{
    switch (i)
    {
        case Piano:
            ContadorPiano++;
            break;
        case Guitarra:
            ContadorGuitarra++;
            break;
    }
}

Console.WriteLine($"Guitarra {ContadorGuitarra} \n Piano {ContadorPiano}");
