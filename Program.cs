using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Campus.Entities;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.Clear();
        Console.WriteLine("Ingrese la cantidad de estudiantes a registrar 👨‍🚀: ");
        int cantidad = int.Parse(Console.ReadLine());
        Console.Clear();
        List<Estudiantes> lstEstudiantes = new List<Estudiantes>();
        for (int i = 0; i < cantidad; i++)
        {

            Estudiantes est = new Estudiantes();
            int codigoEstudiante = 0;
            bool opcE = true;
            while (opcE)
            {
                Console.WriteLine("Ingrese el código del estudiante 💬: ");
                string cod = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(cod))
                {
                    Console.WriteLine("❌Error, el código no puede estar vacío.  Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (!int.TryParse(cod, out codigoEstudiante))
                {
                    Console.WriteLine("❌Error, ingrese un código válido (número entero). Press Enter to continue... ");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (cod.Length > 10)
                {
                    Console.WriteLine("❌Error, el código no puede tener más de 15 caracteres. Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    est.Cod = codigoEstudiante;
                    opcE = false;
                }
            }

            bool name = true;
            while (name)
            {
                Console.WriteLine("Ingrese el nombre de estudiante 🧑: ");
                est.Name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(est.Name))
                {
                    Console.WriteLine("❌Error, el Nombre no puede estar vacío. Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (est.Name.Length > 40)
                {
                    Console.WriteLine("❌Error, el Nombre no puede tener más de 40 caracteres. Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (est.Name.All(char.IsDigit))
                {
                    Console.WriteLine("❌Error, el Nombre no puede ser un número. Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    name = false;
                }
            }

            bool email = true;
            while (email)
            {
                Console.WriteLine("Ingrese el Email del estudiante 📧: ");
                est.Email = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(est.Email))
                {
                    Console.WriteLine("❌Error, el Email no puede estar vacío. Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (est.Email.Length > 40)
                {
                    Console.WriteLine("❌Error, el Email no puede tener más de 40 caracteres. Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (est.Email.All(char.IsDigit))
                {
                    Console.WriteLine("❌Error, el Email no puede ser un número. Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    email = false;
                }
            }

            int edad = 0;
            bool edadBool = true;
            while (edadBool)
            {
                Console.WriteLine("Ingrese la edad del estudiante 💬: ");
                string age = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(age))
                {
                    Console.WriteLine("❌Error, la edad no puede estar vacía. Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (!int.TryParse(age, out edad))
                {
                    Console.WriteLine("❌Error, ingrese una edad válida (número entero). Press Enter to continue... ");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (age.Length > 2)
                {
                    Console.WriteLine("❌Error, la edad no puede tener más de 2 caracteres. Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    est.Age = edad;
                    edadBool = false;
                }
            }

            bool direccion = true;
            while (direccion)
            {
                Console.WriteLine("Ingrese la direccion del estudiante: 🏡 ");
                est.Address = Console.ReadLine();

                if (string.IsNullOrEmpty(est.Address))
                {
                    Console.WriteLine("❌Error, la direccion no puede estar vacía. Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (est.Address.Length > 30)
                {
                    Console.WriteLine("❌Error, la direccion no puede tener mas de 30 caracteres. Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (est.Address.All(char.IsDigit))
                {
                    Console.WriteLine("❌Error, el Email no puede ser un número. Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    direccion = false;
                }
            }

            lstEstudiantes.Add(est);
            Console.Write("\nPress Enter to continue...🌟");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("El estudiantes fueron registrados exitosamente...✨");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n{0,-20} {1,-36} {2,-10} {3,20} {4,20} ", "Cod. Estudiante", "Nombre Estudiante", "Email Estudiante", "Edad Estudiante", "Direcciones Estudiante");

        foreach (Estudiantes alum in lstEstudiantes)
        {
            Console.WriteLine("{0,-20} {1,-36} {2,-10} {3,20} {4,20} ", alum.Cod, alum.Name, alum.Email, alum.Age, alum.Address);
        }
        Console.Write("\nPress Enter to continue...🌟");
        Console.ReadKey();

        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("<------ MENU PRINCIPAL ------>\n");
            Console.WriteLine("1. Estudiantes Registrados. 📃");
            Console.WriteLine("2. Agregar notas a los Estudiantes. 📝");
            Console.WriteLine("3. Listado de Notas finales. 📋");
            Console.WriteLine("\n4. Salir 👋");
            Console.WriteLine("\nElige una de las opciones: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\n{0,17} {1,-40} {2,6} {3,6} {4,6} {5,6} {6,6} {7,6} {8,6} {9,6} {10,6}", "Codigo Estudiante", "Nombre", "Q1", "Q2", "Q3", "Q4", "T1", "T2", "P1", "P2", "P3");
                    for (int i = 0; i < lstEstudiantes.Count; i++)
                    {
                        Console.WriteLine("{0,-17} {1,-40} {2,6} {3,6} {4,6} {5,6} {6,6} {7,6} {8,6} {9,6} {10,6}", lstEstudiantes[i].Cod, lstEstudiantes[i].Name, lstEstudiantes[i].Quiz[0], lstEstudiantes[i].Quiz[1], lstEstudiantes[i].Quiz[2], lstEstudiantes[i].Quiz[3], lstEstudiantes[i].Trabajos[0], lstEstudiantes[i].Trabajos[1], lstEstudiantes[i].Parciales[0], lstEstudiantes[i].Parciales[1], lstEstudiantes[i].Parciales[2]);
                    }
                    Console.Write("\nPresione cualquier tecla para continuar...🌟");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("{0,17} {1,-40} {2,6} {3,6} {4,6} {5,6} {6,6} {7,6} {8,6} {9,6} {10,6}", "Codigo Estudiante", "Nombre", "Q1", "Q2", "Q3", "Q4", "T1", "T2", "P1", "P2", "P3");
                    for (int i = 0; i < lstEstudiantes.Count; i++)
                    {
                        Console.WriteLine("{0,-17} {1,-40} {2,6} {3,6} {4,6} {5,6} {6,6} {7,6} {8,6} {9,6} {10,6}", lstEstudiantes[i].Cod, lstEstudiantes[i].Name, lstEstudiantes[i].Quiz[0], lstEstudiantes[i].Quiz[1], lstEstudiantes[i].Quiz[2], lstEstudiantes[i].Quiz[3], lstEstudiantes[i].Trabajos[0], lstEstudiantes[i].Trabajos[1], lstEstudiantes[i].Parciales[0], lstEstudiantes[i].Parciales[1], lstEstudiantes[i].Parciales[2]);
                    }

                    int codigoEstudiante = 0;
                    bool opc1 = true;
                    while (opc1)
                    {
                        Console.WriteLine("\nIngrese el codigo del estudiante 💬: ");
                        string codigoE = Console.ReadLine();

                        for (sbyte i = 0; i < lstEstudiantes.Count; i++)
                        {
                            if (string.IsNullOrWhiteSpace(codigoE))
                            {
                                Console.WriteLine("❌Error, el código no puede estar vacío.  Press Enter to continue...");
                                Console.ReadKey();
                            }
                            else if (!int.TryParse(codigoE, out codigoEstudiante))
                            {
                                Console.WriteLine("❌Error, ingrese un código válido (número entero). Press Enter to continue... ");
                                Console.ReadKey();
                            }
                            else if (lstEstudiantes[i].Cod != codigoEstudiante)
                            {
                                Console.WriteLine("❌Error, el código no coincide..");
                                Console.ReadKey();
                            }
                            else
                            {
                                opc1 = false;
                                Console.Clear();
                            }
                        }
                    }

                    bool case2 = false;
                    while (!case2)
                    {
                        for (sbyte i = 0; i < lstEstudiantes.Count; i++)
                        {
                            Console.WriteLine("{0,17} {1,-40} {2,6} {3,6} {4,6} {5,6} {6,6} {7,6} {8,6} {9,6} {10,6}", "Codigo Estudiante", "Nombre", "Q1", "Q2", "Q3", "Q4", "T1", "T2", "P1", "P2", "P3");
                            Console.WriteLine("{0,-17} {1,-40} {2,6} {3,6} {4,6} {5,6} {6,6} {7,6} {8,6} {9,6} {10,6}", lstEstudiantes[i].Cod, lstEstudiantes[i].Name, lstEstudiantes[i].Quiz[0], lstEstudiantes[i].Quiz[1], lstEstudiantes[i].Quiz[2], lstEstudiantes[i].Quiz[3], lstEstudiantes[i].Trabajos[0], lstEstudiantes[i].Trabajos[1], lstEstudiantes[i].Parciales[0], lstEstudiantes[i].Parciales[1], lstEstudiantes[i].Parciales[2]);
                            Console.WriteLine("\n<------ REGISTRO DE NOTAS ------>");
                            Console.WriteLine("1. Registrar Quices 📗");
                            Console.WriteLine("2. Registrar Trabajos 📘");
                            Console.WriteLine("3. Registrar Parciales 📙");
                            Console.WriteLine("4. Salir 👋");
                            Console.WriteLine("\nIngrese una opcion: ");
                            int opcNotas = Convert.ToInt32(Console.ReadLine());
                            switch (opcNotas)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine($"Quizes del Estudiante {lstEstudiantes[i].Name} 🧑\n");
                                    Console.WriteLine("1. Registrar Quiz 1");
                                    Console.WriteLine("2. Registrar Quiz 2");
                                    Console.WriteLine("3. Registrar Quiz 3");
                                    Console.WriteLine("4. Registrar Quiz 4");
                                    Console.WriteLine("\nIngrese una opcion: ");
                                    int opcQuiz = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    switch (opcQuiz)
                                    {
                                        case 1:
                                            int notaQuiz1 = 0;
                                            bool opcQ1 = true;
                                            while (opcQ1)
                                            {
                                                Console.WriteLine("Ingrese la nota del quiz 1: ");
                                                string quiz1 = Console.ReadLine();

                                                if (string.IsNullOrWhiteSpace(quiz1))
                                                {
                                                    Console.WriteLine("❌Error, la nota no puede estar vacia.  Press Enter to continue...");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (!int.TryParse(quiz1, out notaQuiz1))
                                                {
                                                    Console.WriteLine("❌Error, ingrese una nota válida (número entero). Press Enter to continue... ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (notaQuiz1 < 1 && notaQuiz1 > 100)
                                                {
                                                    Console.WriteLine("❌Error, la nota debe estar entre 1 y 100");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    opcQ1 = false;
                                                }
                                            }
                                            lstEstudiantes[i].Quiz[opcQuiz - 1] = notaQuiz1;
                                            break;
                                        case 2:
                                            int notaQuiz2 = 0;
                                            bool opcQ2 = true;
                                            while (opcQ2)
                                            {
                                                Console.WriteLine("Ingrese la nota del quiz 2: ");
                                                string quiz2 = Console.ReadLine();

                                                if (string.IsNullOrWhiteSpace(quiz2))
                                                {
                                                    Console.WriteLine("❌Error, la nota no puede estar vacía.  Press Enter to continue...");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (!int.TryParse(quiz2, out notaQuiz2))
                                                {
                                                    Console.WriteLine("❌Error, ingrese una nota válida (número entero). Press Enter to continue... ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (notaQuiz2 < 1 && notaQuiz2 > 100)
                                                {
                                                    Console.WriteLine("❌Error, la nota debe estar entre 1 y 100");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    opcQ2 = false;
                                                }
                                            }
                                            lstEstudiantes[i].Quiz[opcQuiz - 1] = notaQuiz2;
                                            break;
                                        case 3:
                                            int notaQuiz3 = 0;
                                            bool opcQ3 = true;
                                            while (opcQ3)
                                            {
                                                Console.WriteLine("Ingrese la nota del quiz 3: ");
                                                string quiz3 = Console.ReadLine();

                                                if (string.IsNullOrWhiteSpace(quiz3))
                                                {
                                                    Console.WriteLine("❌Error, la nota no puede estar vacía.  Press Enter to continue...");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (!int.TryParse(quiz3, out notaQuiz3))
                                                {
                                                    Console.WriteLine("❌Error, ingrese una nota válida (número entero). Press Enter to continue... ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (notaQuiz3 < 1 && notaQuiz3 > 100)
                                                {
                                                    Console.WriteLine("❌Error, la nota debe estar entre 1 y 100");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    opcQ3 = false;
                                                }
                                            }
                                            lstEstudiantes[i].Quiz[opcQuiz - 1] = notaQuiz3;
                                            break;
                                        case 4:
                                            int notaQuiz4 = 0;
                                            bool opcQ4 = true;
                                            while (opcQ4)
                                            {
                                                Console.WriteLine("Ingrese la nota del quiz 4: ");
                                                string quiz4 = Console.ReadLine();

                                                if (string.IsNullOrWhiteSpace(quiz4))
                                                {
                                                    Console.WriteLine("❌Error, la nota no puede estar vacía.  Press Enter to continue...");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (!int.TryParse(quiz4, out notaQuiz4))
                                                {
                                                    Console.WriteLine("❌Error, ingrese una nota válida (número entero). Press Enter to continue... ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (notaQuiz4 < 1 && notaQuiz4 > 100)
                                                {
                                                    Console.WriteLine("❌Error, la nota debe estar entre 1 y 100");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    opcQ4 = false;
                                                }
                                            }
                                            lstEstudiantes[i].Quiz[opcQuiz - 1] = notaQuiz4;
                                            break;
                                        default:
                                            Console.WriteLine("Elige una opcion entre 1 y 4");
                                            Console.ReadKey();
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine($"Trabajos del Estudiante {lstEstudiantes[i].Name} 🧑\n");
                                    Console.WriteLine("1. Registrar Trabajo 1");
                                    Console.WriteLine("2. Registrar Trabajo 2");
                                    Console.WriteLine("\nElija una opcion: ");
                                    int opcTrabajos = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    switch (opcTrabajos)
                                    {
                                        case 1:
                                            int notaTrabajo1 = 0;
                                            bool opcT1 = true;
                                            while (opcT1)
                                            {
                                                Console.WriteLine("Ingrese la nota del Trabajo 1: ");
                                                string trabajo1 = Console.ReadLine();

                                                if (string.IsNullOrWhiteSpace(trabajo1))
                                                {
                                                    Console.WriteLine("❌Error, la nota no puede estar vacia.  Press Enter to continue...");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (!int.TryParse(trabajo1, out notaTrabajo1))
                                                {
                                                    Console.WriteLine("❌Error, ingrese una nota válida (número entero). Press Enter to continue... ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (notaTrabajo1 < 1 && notaTrabajo1 > 100)
                                                {
                                                    Console.WriteLine("❌Error, la nota debe estar entre 1 y 100");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    opcT1 = false;
                                                }
                                            }
                                            lstEstudiantes[i].Trabajos[opcTrabajos - 1] = notaTrabajo1;
                                            break;
                                        case 2:
                                            int notaTrabajo2 = 0;
                                            bool opcT2 = true;
                                            while (opcT2)
                                            {
                                                Console.WriteLine("Ingrese la nota del Trabajo 1: ");
                                                string trabajo2 = Console.ReadLine();

                                                if (string.IsNullOrWhiteSpace(trabajo2))
                                                {
                                                    Console.WriteLine("❌Error, la nota no puede estar vacia.  Press Enter to continue...");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (!int.TryParse(trabajo2, out notaTrabajo2))
                                                {
                                                    Console.WriteLine("❌Error, ingrese una nota válida (número entero). Press Enter to continue... ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (notaTrabajo2 < 1 && notaTrabajo2 > 100)
                                                {
                                                    Console.WriteLine("❌Error, la nota debe estar entre 1 y 100");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    opcT2 = false;
                                                }
                                            }
                                            lstEstudiantes[i].Trabajos[opcTrabajos - 1] = notaTrabajo2;
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine($"Parciales del Estudiante {lstEstudiantes[i].Name} 🧑\n");
                                    Console.WriteLine("1. Registrar Parcial 1");
                                    Console.WriteLine("2. Registrar Parcial 2");
                                    Console.WriteLine("3. Registrar Parcial 3");
                                    Console.WriteLine("\n Elija una opcion: ");
                                    int opcParciales = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    switch (opcParciales)
                                    {
                                        case 1:
                                            int notaParciales1 = 0;
                                            bool opcP1 = true;
                                            while (opcP1)
                                            {
                                                Console.WriteLine("Ingrese la nota del Parcial 1: ");
                                                string parcial1 = Console.ReadLine();

                                                if (string.IsNullOrWhiteSpace(parcial1))
                                                {
                                                    Console.WriteLine("❌Error, la nota no puede estar vacia.  Press Enter to continue...");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (!int.TryParse(parcial1, out notaParciales1))
                                                {
                                                    Console.WriteLine("❌Error, ingrese una nota válida (número entero). Press Enter to continue... ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (notaParciales1 < 1 && notaParciales1 > 100)
                                                {
                                                    Console.WriteLine("❌Error, la nota debe estar entre 1 y 100");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    opcP1 = false;
                                                }
                                            }
                                            lstEstudiantes[i].Parciales[opcParciales - 1] = notaParciales1;
                                            break;
                                        case 2:
                                            int notaParciales2 = 0;
                                            bool opcP2 = true;
                                            while (opcP2)
                                            {
                                                Console.WriteLine("Ingrese la nota del Parcial 2: ");
                                                string parcial2 = Console.ReadLine();

                                                if (string.IsNullOrWhiteSpace(parcial2))
                                                {
                                                    Console.WriteLine("❌Error, la nota no puede estar vacia.  Press Enter to continue...");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (!int.TryParse(parcial2, out notaParciales2))
                                                {
                                                    Console.WriteLine("❌Error, ingrese una nota válida (número entero). Press Enter to continue... ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (notaParciales2 < 1 && notaParciales2 > 100)
                                                {
                                                    Console.WriteLine("❌Error, la nota debe estar entre 1 y 100");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    opcP2 = false;
                                                }
                                            }
                                            lstEstudiantes[i].Parciales[opcParciales - 1] = notaParciales2;
                                            break;
                                        case 3:
                                            int notaParciales3 = 0;
                                            bool opcP3 = true;
                                            while (opcP3)
                                            {
                                                Console.WriteLine("Ingrese la nota del Parcial 3: ");
                                                string parcial3 = Console.ReadLine();

                                                if (string.IsNullOrWhiteSpace(parcial3))
                                                {
                                                    Console.WriteLine("❌Error, la nota no puede estar vacia.  Press Enter to continue...");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (!int.TryParse(parcial3, out notaParciales3))
                                                {
                                                    Console.WriteLine("❌Error, ingrese una nota válida (número entero). Press Enter to continue... ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else if (notaParciales3 < 1 && notaParciales3 > 100)
                                                {
                                                    Console.WriteLine("❌Error, la nota debe estar entre 1 y 100");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    opcP3 = false;
                                                }
                                            }
                                            lstEstudiantes[i].Parciales[opcParciales - 1] = notaParciales3;
                                            break;
                                    }
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("Has elegido salir al menu principal ");
                                    Console.ReadKey();
                                    case2 = true;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Elige una opcion entre 1 y 5");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.ReadLine();
                                    break;
                            }
                        }
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Notas Finales de los estudiantes ✨\n");
                    Console.WriteLine("{0,17} {1,-40} {2,6} {3,6} {4,6} {5,6}", "Codigo Estudiante", "Nombre", "DQ", "DT", "DP", "NF");
                    for (int i = 0; i < lstEstudiantes.Count; i++)
                    {
                    int? definitivaQuices = 0;
                    int? definitivaTrabajos = 0;
                    int? definitivaParciales = 0;
                    for (int q = 0; q < lstEstudiantes.Count; q++)
                    {
                        foreach (int? nota in lstEstudiantes[q].Quiz)
                        {
                            if (nota != null)
                            {
                                definitivaQuices += nota / 4;
                            }
                        }
                    }
                    for (byte t = 0; t < lstEstudiantes.Count; t++)
                        {
                            foreach (int? nota in lstEstudiantes[t].Trabajos)
                            {
                                if (nota != null)
                                {
                                    definitivaTrabajos += nota / 2;
                                }
                            }
                        }
                    for (byte t = 0; t < lstEstudiantes.Count; t++)
                        {
                            foreach (int? nota in lstEstudiantes[t].Parciales)
                            {
                                if (nota != null)
                                {
                                    definitivaParciales += nota / 3;
                                }
                            }
                        }
                    definitivaQuices = (int)Math.Round((decimal)definitivaQuices, 1);
                    definitivaTrabajos = (int)Math.Round((decimal)definitivaTrabajos, 1);
                    definitivaParciales = (int)Math.Round((decimal)definitivaParciales, 1);
                    double? notaFinal = Math.Round(((definitivaQuices * 0.25) + (definitivaTrabajos * 0.15) + (definitivaParciales * 0.6)).Value, 1);
                    Console.WriteLine("\n{0,-17} {1,-40} {2,6} {3,6} {4,6} {5,6}",lstEstudiantes[i].Cod, lstEstudiantes[i].Name, definitivaQuices, definitivaTrabajos, definitivaParciales, notaFinal);
                    Console.WriteLine("\nPress Enter to continue...⭐");
                    Console.ReadKey();    
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Has elegido salir de la aplicación");
                    Console.ReadLine();
                    salir = true;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Elige una opcion entre 1 y 4");
                    Console.ReadLine();
                    break;
            }

        }
    }
}

