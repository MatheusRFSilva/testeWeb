using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace web
{
    public class Relatorio
    {
        private readonly Catalogo catalogo;

        public Relatorio(Catalogo catalogo)
        {
            this.catalogo = catalogo;
        }

        public async Task Imprimir(HttpContext context)
        {

            foreach (var livro in catalogo.GetLivros())
            {
                await context.Response.WriteAsync($"{livro.Codigo,-10}{livro.Nome,-40}{livro.Preco.ToString("c"),10}\r\n");
            }
        }
    }
}
