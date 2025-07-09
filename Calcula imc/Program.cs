using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula_imc
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso = DigitaPeso("Digite seu peso: ", "Peso inválido,digite novamente!");
            double altura = DigitaAltura("Digite sua altura: ", "Altura inválida,digite novamente");

            double imc;

            imc = peso / (altura * altura) ;

            string classificacao = Classific(imc);

            Console.WriteLine("Seu peso : " + peso);
            Console.WriteLine("Sua altura: " + altura);
            Console.WriteLine("Seu imc: " + imc);
            Console.WriteLine("Classificacão: " + classificacao); //Apenas teste sobre a funcionalidade de uma branch
            //git push origin "nome da braanch" ,comando que sobe a branch no github 

        }

        static double DigitaPeso(string mensagemPeso,string mensagemErro)
        {
            bool ok;
            double peso;
            string s;

            do { Console.WriteLine(mensagemPeso);
                s = Console.ReadLine();
                ok = double.TryParse(s, out peso);

                if (!ok ) {Console.WriteLine(mensagemErro);}
               
            } while (!ok || peso < 0); return peso;



        }
        static double DigitaAltura(string mensagemAltura, string mensagemErro)
        {
            bool ok;
            double altura;
            string s;
            do
            {
                Console.WriteLine(mensagemAltura);
                s = Console.ReadLine();
                ok = double.TryParse(s, out altura);

                if (!ok) { Console.WriteLine(mensagemErro); }
               
            } while (!ok || altura < 0); 
            return altura;
        }

        static string Classific(double imc)
        {
            string classific;
            if (imc > 39.9) {classific ="Obesidade grave"; }

            else if (imc > 29.9) { classific = "Obesidade"; }

            else if (imc > 24.9) { classific = "Sobrepeso"; }

            else if (imc > 18.5) { classific = "Peso normal"; }

            else classific = "abaixo do peso";

            return classific;
        }



       
    }
}
