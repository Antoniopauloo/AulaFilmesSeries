using AulaFilmesSeries.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaFilmesSeries.Respository
{
    public class Armazenamento
    {
        public static List<Usuario> Usuarios =
            new List<Usuario>();

        public static List<Item> Biblioteca =
            new List<Item>();
    }
}
