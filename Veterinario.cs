using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria
{
    public class Veterinario : Pessoa
    {
        public string? nomeVeterinario;
        public string? telefoneVeterinario;
        public string? emailVeterinario;
        public string? crmvVeterinario;
        public string? especialidadeVeterinario;
       
        public Veterinario(string ctNome, string ctTelefone, string ctEmail, string ctCrmv, string ctEspecialidade) : base(ctNome, ctTelefone, ctEmail)
        {                                                                                                  /* ": base()"é uma forma de fazer ele aceitar essas informações do parametro
                                                                                                              vindo do c++, uma forma não nativa do c++ */
            nomeVeterinario = ctNome;
            telefoneVeterinario = ctTelefone;
            emailVeterinario = ctEmail;
            crmvVeterinario = ctCrmv;
            especialidadeVeterinario = ctEspecialidade;
            Console.WriteLine(".");
        }
    }
}
