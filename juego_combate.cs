public class Guerrero
    {
        public string nombre;
        public int puntosDeVida;
        public int fuerza;

        public Guerrero(string nombre, int puntosDeVida, int fuerza)
        {
            this.nombre = nombre;
            this.puntosDeVida = puntosDeVida;
            this.fuerza = fuerza;
        }

        public void Atacar(Guerrero enemigo)
        {
            int danio = this.fuerza;
            enemigo.RecibirDanio(danio);
            Console.WriteLine(this.nombre + " ataca a " + enemigo.nombre + " causando " + danio + " puntos de daño.");
        }

        public void RecibirDanio(int danio)
        {
            this.puntosDeVida -= danio;
            if (this.puntosDeVida <= 0)
            {
                this.puntosDeVida = 0;
                Console.WriteLine(this.nombre + " ha sido derrotado.");
            }
            else
            {
                Console.WriteLine(this.nombre + " recibe " + danio + " puntos de daño. Puntos de vida restantes: " + this.puntosDeVida);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("              (:                    ESTA ES UNA PELEA DE GUERREROS FUERTES QUE GANE EL MEJOR                    (:");
            Console.WriteLine();
            Console.WriteLine();
            Guerrero guerrero1 = new Guerrero("Bruce Lee", 100, 20);
            Guerrero guerrero2 = new Guerrero("Arnol Schwarzenegger ", 120, 15);

            while (guerrero1.puntosDeVida > 0 && guerrero2.puntosDeVida > 0)
            {
                guerrero1.Atacar(guerrero2);
                Console.WriteLine();

                if (guerrero2.puntosDeVida <= 0)
                {
                    Console.WriteLine(guerrero1.nombre + " ha ganado la batalla.");
                    break;
                }

                guerrero2.Atacar(guerrero1);
                Console.WriteLine();

                if (guerrero1.puntosDeVida <= 0)
                {
                    Console.WriteLine(guerrero2.nombre + " ha ganado la batalla.");
                    break;
                }
            }
            // Aqui se define quien es el guerrero mas fuerte
            Console.WriteLine("el mejor de todos los tiempos .");
            Console.ReadKey();
        }
    }
}

