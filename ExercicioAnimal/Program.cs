using System;
namespace ExercicioAnimal
{
    class Animal
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }
        public int Idade()
        {
            var hoje = DateTime.Today;
            var idade = hoje.Year - this.DataNascimento.Year;
            return idade;
        }

        public void Movimentar()
        {
             Console.WriteLine("Eu me remexo muito!");
        }

        public void Comunicar()
        {
            Console.WriteLine("Ich bin ein Tier");
        }

        public void Alimentar()
        {
            Console.WriteLine("Vou de comes e bebes");
        }


    }
    class Mamifero
    {

    }
    
    class Reptil
    {

    }

    interface IAquatico
    {

    }

    interface IOviparo
    {

    }

    interface IVoar
    {

    }


}