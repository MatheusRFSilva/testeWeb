﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
namespace web
{
    public class Catalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Quem mexeu na Minha Query", 12.99m));
            livros.Add(new Livro("002", "Fique Rico com C# R$", 30.99m));
            livros.Add(new Livro("003", "Java Para Baixinhos", 25.99m));
            return livros;

        }
    }
}

