using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite la cantidad de estudiantes: ");
        int cantidad = int.Parse(Console.ReadLine());

        // Arreglos
        string[] nombres = new string[cantidad];
        double[,] notas = new double[cantidad, 4];
        double[] promedios = new double[cantidad];
        string[] estatus = new string[cantidad];

        // Registrar estudiantes
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("\nNombre del estudiante: ");
            nombres[i] = Console.ReadLine();

            double suma = 0;

            for (int j = 0; j < 4; j++)
            {
                Console.Write("Digite la nota " + (j + 1) + ": ");
                notas[i, j] = double.Parse(Console.ReadLine());
                suma += notas[i, j];
            }

            promedios[i] = suma / 4;

            if (promedios[i] >= 70)
            {
                estatus[i] = "Aprobado";
            }
            else
            {
                estatus[i] = "Reprobado";
            }
        }

        // Mostrar la tabla al final
        Console.WriteLine();
       Console.WriteLine("+-------------------------+--------+--------+--------+--------+-----------+------------+");
Console.WriteLine("| Estudiante              | Nota 1 | Nota 2 | Nota 3 | Nota 4 | Promedio  | Estatus    |");
Console.WriteLine("+-------------------------+--------+--------+--------+--------+-----------+------------+");

for (int i = 0; i < cantidad; i++)
{
    Console.WriteLine(
        $"| {nombres[i],-23}" +
        $"| {notas[i,0],6}" +
        $" | {notas[i,1],6}" +
        $" | {notas[i,2],6}" +
        $" | {notas[i,3],6}" +
        $" | {promedios[i],9:F2}" +
        $" | {estatus[i],-10} |");
}

Console.WriteLine("+-------------------------+--------+--------+--------+--------+-----------+------------+");
    }
}
