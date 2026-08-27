using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria
{
    public class Tutor : Pessoa
    {
        
        public string? nomeTutor {  get; set; }
        public string? telefoneTutor {  get; set; }
        public string? emailTutor {  get; set; }
        public string? cpfTutor {  get; set; }

        List<Animal> animais;

        /* public Tutor(string ctNome, string ctTelefone, string ctEmail, string ctCPF) : base(ctNome, ctTelefone, ctEmail)
        {                                                                                                  /* ": base()"é uma forma de fazer ele aceitar essas informações do parametro
                                                                                                              vindo do c++, uma forma não nativa do c++ 
            nomeTutor = ctNome;
            telefoneTutor = ctTelefone;
            emailTutor = ctEmail;
            cpfTutor = ctCPF;
            Console.WriteLine(".");
        } */


        public Tutor CadastrarTutor() 
        {
            Tutor novoTutor = new Tutor();

            Console.WriteLine("Digite o nome do tutor: ");
            novoTutor = Console.ReadLine();
            Console.WriteLine("Digite o telefone do tutor: ");
            telefoneTutor = Console.ReadLine();
            Console.WriteLine("Digite o email do tutor: ");
            emailTutor = Console.ReadLine();
            Console.WriteLine("Digite o cpf do tutor: ");
            cpfTutor = Console.ReadLine();

            return novoTutor;
        }
    }
}