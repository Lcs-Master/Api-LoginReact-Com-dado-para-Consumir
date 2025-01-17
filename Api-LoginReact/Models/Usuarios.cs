using System.Collections.Generic;

namespace Api_LoginReact.Models
{
    public class Usuarios
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string Matricula { get; set; }

        public Usuarios() { }

   
        public static List<Usuarios> ObterUsuarios()
        {
            
            var usuarios = new List<Usuarios>
            {
                new Usuarios { Nome = "João Silva", CPF = "123.456.789-00", Celular = "(11) 91234-5678", Matricula = "001" },
                new Usuarios { Nome = "Maria Oliveira", CPF = "987.654.321-00", Celular = "(11) 99876-5432", Matricula = "002" },
                new Usuarios { Nome = "Carlos Santos", CPF = "111.222.333-44", Celular = "(11) 93456-7890", Matricula = "003" },
                new Usuarios { Nome = "Ana Costa", CPF = "555.666.777-88", Celular = "(11) 94567-8901", Matricula = "004" },
                new Usuarios { Nome = "Pedro Almeida", CPF = "222.333.444-55", Celular = "(11) 95678-9012", Matricula = "005" },
                new Usuarios { Nome = "Beatriz Ferreira", CPF = "444.555.666-77", Celular = "(11) 96789-0123", Matricula = "006" },
                new Usuarios { Nome = "Lucas Lima", CPF = "777.888.999-00", Celular = "(11) 97890-1234", Matricula = "007" },
                new Usuarios { Nome = "Camila Rocha", CPF = "888.999.000-11", Celular = "(11) 98901-2345", Matricula = "008" },
                new Usuarios { Nome = "Gabriel Melo", CPF = "000.111.222-33", Celular = "(11) 99012-3456", Matricula = "009" },
                new Usuarios { Nome = "Larissa Borges", CPF = "333.444.555-66", Celular = "(11) 90123-4567", Matricula = "010" }
            };

            return usuarios;
        }
    }
}
