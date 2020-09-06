using System;
using System.Collections.Generic;
using System.Text;

namespace Secao09.Exercicios.Exercicio_02_Composicao.Entities
{
    public class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
