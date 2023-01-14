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
    class Mamifero : Animal
    {
        public int QteMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorPelo { get; set; }

        public void Amamentar()
        {
            Console.WriteLine("Amamentando");
        }
    }
    
    class Reptil : Animal
    {
        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }
    }

    interface IAquatico
    {
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
    }

    interface IOviparo
    {
        public void Botar()
        {
            Console.WriteLine("Bota");
        }
        public void Chocar()
        {
            Console.WriteLine("Correspondente da Choquei");
        }
    }

    interface IVoar
    {

    }


}