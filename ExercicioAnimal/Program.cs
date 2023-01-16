using System;
namespace ExercicioAnimal
{
    class ExercicioAnimal
    {
        //leão, chacal, morcego, cisne, arara, dragão de comodo, lontra, pinguim, coruja, elefante, jacaré e ornitorrinco
        static void Main(String[] args)
        {
            var leao = new Leao();
            var chacal = new Chacal();
            var morcego = new Morcego();
            var cisne = new Cisne();
            var arara = new Arara();
            var ddc = new DragaoDeComodo();
            var lontra = new Lontra();
            var pinguim = new Pinguim();
            var coruja = new Coruja();
            var elefante = new Elefante();
            var jacare = new Jacare();
            var ornitorrinco = new Ornitorrinco();

            Console.WriteLine("Leão");
            Console.WriteLine($"É mamífero? {EMamifero(leao)}");
            Console.WriteLine($"É ave? {EAve(leao)}");
            Console.WriteLine($"É réptil? {EReptil(leao)}");
            Console.WriteLine($"É ovíparo? {EOviparo(leao)}");
            Console.WriteLine($"É aquático? {EAquatico(leao)}");
            Console.WriteLine($"É voador? {EVoador(leao)}\r\n");

            
            Console.WriteLine("Chacal");
            Console.WriteLine($"É mamífero? {EMamifero(chacal)}");
            Console.WriteLine($"É ave? {EAve(chacal)}");
            Console.WriteLine($"É réptil? {EReptil(chacal)}");
            Console.WriteLine($"É ovíparo? {EOviparo(chacal)}");
            Console.WriteLine($"É aquático? {EAquatico(chacal)}");
            Console.WriteLine($"É voador? {EVoador(chacal)}\r\n");

            
            Console.WriteLine("Morcego");
            Console.WriteLine($"É mamífero? {EMamifero(morcego)}");
            Console.WriteLine($"É ave? {EAve(morcego)}");
            Console.WriteLine($"É réptil? {EReptil(morcego)}");
            Console.WriteLine($"É ovíparo? {EOviparo(morcego)}");
            Console.WriteLine($"É aquático? {EAquatico(morcego)}");
            Console.WriteLine($"É voador? {EVoador(morcego)}\r\n");

            Console.WriteLine("Cisne");
            Console.WriteLine($"É mamífero? {EMamifero(cisne)}");
            Console.WriteLine($"É ave? {EAve(cisne)}");
            Console.WriteLine($"É réptil? {EReptil(cisne)}");
            Console.WriteLine($"É ovíparo? {EOviparo(cisne)}");
            Console.WriteLine($"É aquático? {EAquatico(cisne)}");
            Console.WriteLine($"É voador? {EVoador(cisne)}\r\n");

            Console.WriteLine("Arara");
            Console.WriteLine($"É mamífero? {EMamifero(arara)}");
            Console.WriteLine($"É ave? {EAve(arara)}");
            Console.WriteLine($"É réptil? {EReptil(arara)}");
            Console.WriteLine($"É ovíparo? {EOviparo(arara)}");
            Console.WriteLine($"É aquático? {EAquatico(arara)}");
            Console.WriteLine($"É voador? {EVoador(arara)}\r\n");

            Console.WriteLine("Dragao de Comodo");
            Console.WriteLine($"É mamífero? {EMamifero(ddc)}");
            Console.WriteLine($"É ave? {EAve(ddc)}");
            Console.WriteLine($"É réptil? {EReptil(ddc)}");
            Console.WriteLine($"É ovíparo? {EOviparo(ddc)}");
            Console.WriteLine($"É aquático? {EAquatico(ddc)}");
            Console.WriteLine($"É voador? {EVoador(ddc)}\r\n");

            Console.WriteLine("Lontra");
            Console.WriteLine($"É mamífero? {EMamifero(lontra)}");
            Console.WriteLine($"É ave? {EAve(lontra)}");
            Console.WriteLine($"É réptil? {EReptil(lontra)}");
            Console.WriteLine($"É ovíparo? {EOviparo(lontra)}");
            Console.WriteLine($"É aquático? {EAquatico(lontra)}");
            Console.WriteLine($"É voador? {EVoador(lontra)}\r\n");

            Console.WriteLine("Pinguim");
            Console.WriteLine($"É mamífero? {EMamifero(pinguim)}");
            Console.WriteLine($"É ave? {EAve(pinguim)}");
            Console.WriteLine($"É réptil? {EReptil(pinguim)}");
            Console.WriteLine($"É ovíparo? {EOviparo(pinguim)}");
            Console.WriteLine($"É aquático? {EAquatico(pinguim)}");
            Console.WriteLine($"É voador? {EVoador(pinguim)}\r\n");

            Console.WriteLine("Coruja");
            Console.WriteLine($"É mamífero? {EMamifero(coruja)}");
            Console.WriteLine($"É ave? {EAve(coruja)}");
            Console.WriteLine($"É réptil? {EReptil(coruja)}");
            Console.WriteLine($"É ovíparo? {EOviparo(coruja)}");
            Console.WriteLine($"É aquático? {EAquatico(coruja)}");
            Console.WriteLine($"É voador? {EVoador(coruja)}\r\n");

            Console.WriteLine("Elefante");
            Console.WriteLine($"É mamífero? {EMamifero(elefante)}");
            Console.WriteLine($"É ave? {EAve(elefante)}");
            Console.WriteLine($"É réptil? {EReptil(elefante)}");
            Console.WriteLine($"É ovíparo? {EOviparo(elefante)}");
            Console.WriteLine($"É aquático? {EAquatico(elefante)}");
            Console.WriteLine($"É voador? {EVoador(elefante)}\r\n");

            Console.WriteLine("Jacare");
            Console.WriteLine($"É mamífero? {EMamifero(jacare)}");
            Console.WriteLine($"É ave? {EAve(jacare)}");
            Console.WriteLine($"É réptil? {EReptil(jacare)}");
            Console.WriteLine($"É ovíparo? {EOviparo(jacare)}");
            Console.WriteLine($"É aquático? {EAquatico(jacare)}");
            Console.WriteLine($"É voador? {EVoador(jacare)}\r\n");

            Console.WriteLine("Ornitorrinco");
            Console.WriteLine($"É mamífero? {EMamifero(ornitorrinco)}");
            Console.WriteLine($"É ave? {EAve(ornitorrinco)}");
            Console.WriteLine($"É réptil? {EReptil(ornitorrinco)}");
            Console.WriteLine($"É ovíparo? {EOviparo(ornitorrinco)}");
            Console.WriteLine($"É aquático? {EAquatico(ornitorrinco)}");
            Console.WriteLine($"É voador? {EVoador(ornitorrinco)}\r\n");
        }
        
        static bool EAquatico (Animal ani)
        {
            return ani is IAquatico;
        }
        static bool EOviparo (Animal ani)
        {
            return ani is IOviparo;
        }

        static bool EVoador(Animal ani)
        {
            return ani is IVoar;
        }

        static bool EMamifero (Animal ani)
        {
            return ani is Mamifero;
        }

        static bool EReptil (Animal ani)
        {
            return ani is Reptil;
        }

        static bool EAve (Animal ani)
        {
            return ani is Ave;
        }

    }
    
    abstract class Animal
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
             Console.WriteLine("Movimentando");
        }

        public void Comunicar()
        {
            Console.WriteLine("Comunicando");
        }

        public void Alimentar()
        {
            Console.WriteLine("Alimentando");
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

    class Ave : Animal
    {
        public bool Rapina { get; set; }
        public bool CorPena { get; set; }

        public void Ciscar()
        {
            Console.WriteLine("Ciscando");
        }
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
            Console.WriteLine("Botando");
        }
        public void Chocar()
        {
            Console.WriteLine("Chocando");
        }
    }

    interface IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public void Voar()
        {
            Console.WriteLine("Voando");
        }
    }
    
    class Leao : Mamifero
    {

    }

    class Chacal : Mamifero
    {

    }

    class Morcego : Mamifero, IVoar
    {
        public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Cisne : Ave, IVoar, IOviparo, IAquatico
    {
        public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Arara : Ave, IVoar, IOviparo
    {
        public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class DragaoDeComodo : Reptil, IOviparo
    {

    }

    class Lontra : Mamifero, IAquatico
    {
        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Pinguim : Ave, IOviparo, IAquatico
    {
        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Coruja : Ave, IVoar, IOviparo
    {
        public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Elefante : Mamifero
    {

    }

    class Jacare : Reptil, IOviparo, IAquatico
    {
        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Ornitorrinco : Mamifero, IOviparo, IAquatico
    {
        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }



}