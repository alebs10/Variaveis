using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        enum Notas
        {
            //Nome do membro para a numeração
            Minimo = 10, 
            Media = 15, 
            Maxima = 20
        }

        struct Pessoa
        {
            /*Public modificador de acesso, que define a visibilidade, senão
             não vai ficar visível para nossas variáveis, e não podemos acessar
            a esses dados*/

            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {
            #region Numericas integrais 


            //#region Integral assinado.
            ////Suportam números negativos.
            //sbyte num1 = 10; // 8 bits, de -128 a 127
            //short num2 = 20; // 16 bits, -32.768 a 32.767
            //int num3 = 30; // 32 bits, -2.147.483.648 a 2.147.483.648
            //long num4 = 40; // 64 bits, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.808
            //#endregion

            //#region Integral sem sinal
            ////Não suportam números negativos.
            //byte num5 = 10; // 8 bits, intervalo de 0 a 255
            //ushort num6 = 20; // 16 bits, de 0 a 65.535
            //uint num7 = 30; // 32 bits, de 0 a 4.294.967.595
            //ulong num8 = 40; //64 bits, de 0 a 18.446.744.073.709.551.665
            //#endregion

            //sbyte numPrimo;
            //numPrimo = 127;

            //numPrimo = 100;
            //numPrimo = num1;
            #endregion

            #region Números Reais
            //float real1 = 100.75f;// 32 bits, intervalo de 1,5 x 10-45 a 3,4 x 1038, precisão de 7 digitos => Sufixo f, Ex.:10.5f.
            //double real2 = 500.753; // 64 bits, intervalo de 5,0 x 10-324 a 1,7 x  10308, precisão de 15 dígitos => Sufixo d (opcional), Ex.: 10.5d
            //decimal real3 = 752538.457m; //128 bits, intervalo de pelo menos  -7,9 x 10-28 a 7,9 x 1028, com precisão de oelo menis 28 dígitos => Sufixo m, Ex.: 10.5m

            //double valor;
            //valor = real1;
            #endregion

            #region Caractere

            // \u - Caracter de escape
            //char letra = '\u0041';
            //char escape = '\n';
            //char literal = 'A';

            #endregion

            #region Boolean

            //bool verificar = false;
            //verificar = true;

            #endregion

            #region String (Cadeia de Caracteres)

            //string texto = @"Alexandre Barbosa 2002 \n @@@??$$";
            //string mensagem = null; //valor vazio
            //mensagem = texto;

            #endregion

            #region Tipo Implícito Var - Fortemente tipada

            /*Variavel do tipo Var não tem seu valor definido na sua declaração
            seu tipo de dado só vai ser definido quando ela for inicializada, ela vai
            assumir o seu tipo até o final da execução.

            //var valor = 100;
            //valor = 200;
            //valor = "Ale";*/

            #endregion

            #region Object - System.object do .NET Framework

            /*A variável do tipo Object, é uma variável das quais todas as outras variáveis herdam,
             portanto, ela é a base para todos os outros tipos, podemos atribuir qualquer valor para a Object.

            object obj = 200;
            obj = "Ale";
             */

            #endregion

            #region Constantes

            /*Trablhamos com valor que pode ser alterado, e tem que receber o valor na sua declaração e que não
             será alterado*/

            //const double pi = 3.1415;
            // const string nome = "Ale";

            #endregion

            #region Enumerações

            /*O tipo de Enumeração fornece uma maneira eficiente para definir o conjunto
             de constantes integrais nomeadas, que podem ser atribuidas a um valor. 

            OBS: Tem que ser declarado na raíz da classe.

            Notas notasAlunos = Notas.Media;*/

            #endregion

            #region Estruturas

            /*O tipo de estrutura é um tipo que pode encapsular dados e funcionalidades
             relacionadas, eu posso criar uma estrutura de dados para armazenar valores
            relacionados a um tipo.*/

            Pessoa p1 = new Pessoa();
            p1.nome = "Alexandre";
            p1.altura = 1.81;
            p1.idade = 21;

            Pessoa p2 = new Pessoa()
            {
                nome = "Irineu",
                idade = 99,
                altura = 1.30
            };

            p1.nome = "Ale";

            #endregion 

            Console.WriteLine(p1.nome+ "\n" + p1.idade + "\n" + p1.altura + "\n");
            Console.WriteLine(p2.nome + "\n" + p2.idade + "\n" + p2.altura);
            Console.ReadKey();
        }
    }
}
