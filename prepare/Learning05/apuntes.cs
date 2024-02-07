using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//       List<Animal> animals = new List<Animal>();
//
//       animals.Add( new Animal("max","terrestre",10));
//       animals.Add(new Perro("boby","volador",5));
//
//       foreach( Animal animal in animals)
//       {
//        string ataque = animal.Atacar();
//        Console.WriteLine(ataque);
//       }
//
//       Animal gato = new Animal("gato","domestico",10);
//
//       DisplayAtaque( gato);
//        
//    }
//
//    static void DisplayAtaque(Animal e)
//    {
//        string atack= e.Atacar();
//        Console.WriteLine(atack);
//    }
//
//    public class Animal
//    {
//
//        private string _name ;
//        private string _tipo;
//        private int _edad ;
//
//        public Animal(string name ,string tipo, int edad )
//        {
//            _name = name;
//            _tipo = tipo;
//            _edad = edad;
//        }
//
//        public virtual string  Atacar ()
//        {
//           return "el animal ha mordido";
//        }
//    }
//
//    public class Perro : Animal
//    {
//
//        public Perro(string name ,string tipo, int edad) : base(name,tipo,edad)
//        {
//
//        }
//        public override string  Atacar()
//        {
//            return "el perro ha mordido";
//        }
//
//    }
//}