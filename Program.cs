
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

double melhorNota = materias.Max(m => m.Nota);
var materiasComMelhorNota = materias.Where(m => m.Nota == melhorNota).ToList();

if (materiasComMelhorNota.Count == 1)
{
    Console.WriteLine($"\nA matéria com a melhor nota é {materiasComMelhorNota[0].Nome} com nota {materiasComMelhorNota[0].Nota}.\n");
}
else
{
    Console.WriteLine("\nHouve um empate entre as seguintes matérias com a melhor nota:\n");

    Console.WriteLine("\nMatéria(s) com a melhor nota:\n");
    foreach (var materia in materiasComMelhorNota)
    {
        Console.WriteLine($"{materia.Nome} - Nota: {materia.Nota}");
    }
    Console.WriteLine();
}