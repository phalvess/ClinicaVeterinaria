using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClinicaVeterinaria
{
    public class Animal
    {
        private int _idAnimal {  get; set; }
        public string? nomeAnimal {  get; set; }
        public string? tipoAnimal {  get; set; }
        public string? racaAnimal {  get; set; }
        private string? _dataNascimentoAnimal {  get; set; }
        private string? _cpfTutor {  get; set; }

        /* public Animal(int ctID, string ctNome, string ctTipo, string ctRaca, string ctData, string ctCPF)
        {
            _idAnimal = ctID;
            nomeAnimal = ctNome;
            tipoAnimal = ctTipo;
            racaAnimal = ctRaca;
            _dataNascimentoAnimal = ctData;
            _cpfTutor = ctCPF;
            Console.WriteLine($"Animal: {nomeAnimal}, do tutor de cpf {_cpfTutor} foi cadastrado.");
        } */
        public Animal CadastrarAnimal()
        {
            Animal novoAnimal = new Animal();

            Console.WriteLine("Digite o id do animal: ");
            _idAnimal = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o nome do animal: ");
            novoAnimal = Console.ReadLine();
            Console.WriteLine("Digite o tipo do animal: ");
            tipoAnimal= Console.ReadLine();
            Console.WriteLine("Digite a raça do animal: ");
            racaAnimal= Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento do animal: ");
            _dataNascimentoAnimal = Console.ReadLine();
            Console.WriteLine("Digite o cpf do tutor: ");
            _cpfTutor = Console.ReadLine();

            return novoAnimal; 
        }
        
    }
}
