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
       

        public static void bubble_sort(List<Aluno> lista)
        {
            
            bool houve_troca = true;

            while (houve_troca)
            {

                houve_troca = false;

                for (int i = 0; i < lista.Count-1; i++)
                {

                    if (String.Compare(lista[i].get_curso(), lista[i+1].get_curso(), true) > 0)
                    {
                        
                        Aluno aux = lista[i];
                        lista[i] = lista[i+1];
                        lista[i + 1] = aux;
                        
                        houve_troca = true;

                    } else if (lista[i].get_curso() == lista[i + 1].get_curso())
                    {
                            
                        if (String.Compare(lista[i].get_nome(), lista[i + 1].get_nome(), true) > 0)
                        {

                            Aluno aux = lista[i];
                            lista[i] = lista[i + 1];
                            lista[i + 1] = aux;

                            houve_troca = true;

                        }

                    }


                    

                }


            }


        }

    }
}
