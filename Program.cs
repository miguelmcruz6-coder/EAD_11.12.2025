
using EAD_11._12._2025;

List<Materia> materias = new List<Materia>();


for (int i = 0; i < 5; i++)
{
    Materia materia = new Materia();
    switch (i)
    {
        case 0:
            materia.Nome = "Português";
            Console.Write("\nDigite a nota em Português:\t");
            materia.Nota = double.Parse(Console.ReadLine()!);
            break;
        case 1:
            materia.Nome = "Matemática";
            Console.Write("Digite a nota em Matemática:\t");
            materia.Nota = double.Parse(Console.ReadLine()!);
            break;
        case 2:
            materia.Nome = "Geografia";
            Console.Write("Digite a nota em Geografia:\t");
            materia.Nota = double.Parse(Console.ReadLine()!);
            break;
        case 3:
            materia.Nome = "História";
            Console.Write("Digite a nota em História:\t");
            materia.Nota = double.Parse(Console.ReadLine()!);
            break;
        case 4:
            materia.Nome = "Física";
            Console.Write("Digite a nota em Física:\t");
            materia.Nota = double.Parse(Console.ReadLine()!);
            break;
    }
    materias.Add(materia);
}
Console.WriteLine();

double melhorNota = materias.Max(m => m.Nota);

if (materias.Count(m => m.Nota == melhorNota) > 1)
{
    Console.WriteLine("Você teve a melhor nota em mais de uma matéria:");
    foreach (var materia in materias)
    {
        materia.MelhoresNotas(melhorNota);
    }
    Console.WriteLine($"com uma nota de {melhorNota}.");
}
else
{
    foreach (var materia in materias)
    {
        materia.MelhorNota(melhorNota);
    }
}
Console.WriteLine();
