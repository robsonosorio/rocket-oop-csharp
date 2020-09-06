using Secao09.Exercicios.Exercicio_02_Composicao.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao09.Exercicios.Exercicio_02_Composicao
{
    public class Exercicio_02_Composicao
    {
        public void Exercicio() 
        {
            Console.Clear();

            Comment comentario01 = new Comment("Boa viagem! Não esquece de mandar os registro! ");
            Comment comentario02 = new Comment("Caraca man! Isso é surreal!");
            Post post01 = new Post( DateTime.Parse("03/09/2020 13:05:44"), "Embarcando para Nova Zelândia", "Partiu visitar esse país dahora!", 43);

            post01.AddComment(comentario01);
            post01.AddComment(comentario02);

            Comment comentario03 = new Comment("Boa noite! :) ");
            Comment comentario04 = new Comment("Que a força esteja com você! ");
            Post post02 = new Post( DateTime.Parse("01/08/2020 23:14:19"), "Boa noite galera! o/", "Vejo vocês amanhã", 15);

            post02.AddComment(comentario03);
            post02.AddComment(comentario04);

            Console.WriteLine(post01);
            Console.WriteLine(post02);
        }
    }
}
