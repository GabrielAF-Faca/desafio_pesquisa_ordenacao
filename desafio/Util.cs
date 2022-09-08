using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio
{
    internal class Util
    {
        /// <summary>
        /// Método de ordenação Comb (pente)
        /// </summary>
        /// <param name="lista">Lista de Aluno</param>
        public static void comb_sort(List<string> lista, List<Aluno> lista2 = null)
        {
            int tam = lista.Count;
            int dist = tam;
            bool houve_troca;

            do
            {

                dist = (int)(dist / 1.3);

                if (dist < 1) dist = 1;

                houve_troca = false;

                for (int i = 0; i + dist < tam; i++)
                {

                    if (String.Compare(lista[i], lista[i + dist], true) > 0)
                    {

                        string aux = lista[i];
                        lista[i] = lista[i + dist];
                        lista[i + dist] = aux;

                        if (lista2 != null)
                        {
                            Aluno aux2 = lista2[i];
                            lista2[i] = lista2[i + dist];
                            lista2[i + dist] = aux2;
                        }
                        houve_troca = true;


                    }

                }


            } while (dist > 1 || houve_troca);
        }


        public static void comb_sort(List<Aluno> lista)
        {
            int tam = lista.Count;
            int dist = tam;
            bool houve_troca;

            do
            {
                dist = (int)(dist / 1.3);

                if (dist < 1) dist = 1;

                houve_troca = false;

                for (int i = 0; i + dist < tam; i++)
                {

                    if (String.Compare(lista[i].get_nome(), lista[i + dist].get_nome(), true) > 0)
                    {

                        Aluno aux = lista[i];
                        lista[i] = lista[i + dist];
                        lista[i + dist] = aux;

                        houve_troca = true;


                    }

                }


            } while (dist > 1 || houve_troca);
        }

    }
}
