namespace ClinicaVeterinaria
{
    class Program
    {
        static void Main()
        {
            Tutor novoTutor = new Tutor();
            List<Tutor> listaTutor = new List<Tutor>();
            Animal novoAnimal = new Animal();
            List<Animal> listaAnimal = new List<Animal>();

            Console.WriteLine("=====================");
            Console.WriteLine(" Clínica Veterinária ");
            Console.WriteLine("=====================");
            Console.WriteLine("[1] Cadastro de Tutores");
            Console.WriteLine("[2] Cadastro de Animais");
            Console.WriteLine();
            Console.WriteLine("Escolha a opção desejada: ");
            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    novoTutor = novoTutor.CadastrarTutor();
                    listaTutor.Add(novoTutor);
                    Console.WriteLine($"Tutor {novoTutor}, cadastrado com sucesso.");
                    break;
                case 2:
                    novoAnimal = novoAnimal.CadastrarAnimal();
                    listaAnimal.Add(novoAnimal);
                    Console.WriteLine($"Animal {novoAnimal}, cadastrado com sucesso.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
