using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace T1_Examen_Calidad_OblitasEliana
{
    public class PokerTest
    {
        [Test]
        public void Caso01()//Ganador del juego
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "1, 2, 3, 4, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "7, 5, 6, 8, 1" });

            var result = poker.MostrarGanador();

            Assert.AreEqual("Jugador 1", result);
        }

        [Test]
        public void Caso02()//Mínimo 2 jugadores
        {
            var Jugador = new ExceptionTestClass();

            var jugador = new Jugador();
            jugador.AddJugador("Jose");
            jugador.AddJugador("María");

            var result = contarJugadores();

            Assert.Throws(typeof(Exception), () => jugador.comprobarJugadores(contador);
            //Thrown new exception("Hay mas de 6 jugadores");
        }

        [Test]
        public void Caso03()//Maximo 5 jugadores
        {
            var Jugador = new ExceptionTestClass();

            var jugador = new Jugador();
            jugador.AddJugador("Jose");
            jugador.AddJugador("María");
            jugador.AddJugador("Luis");
            jugador.AddJugador("Isabel");
            jugador.AddJugador("Fernando");
            jugador.AddJugador("Ivan");

            var result = contarJugadores();

            Assert.Throws(typeof(Exception), () => jugador.contarJugadores(6);
        }

        [Test]
        public void Caso04()//Empate
        {
            var jugador = new Jugador();
            jugador.AddCarta(4, "Jose");
            jugador.AddCarta(3, "Jose");
            jugador.AddCarta(5, "Jose");
            jugador.AddCarta(2, "Jose");
            jugador.AddCarta(1, "Jose");

            jugador.AddCarta(8, "Maria");
            jugador.AddCarta(6, "Maria");
            jugador.AddCarta(5, "Maria");
            jugador.AddCarta(7, "Maria");
            jugador.AddCarta(9, "Maria");

            var result = comprobarEscalera();

            Assert.AreEqual("Escaleras", result.cartas);
        }

        [Test]
        public void Caso05()//Cartas Iguales 1 = Cartas iguales y 0 = Cartas diferentes
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "1, 2, 3, 4, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "3, 2, 1, 4, 5" });

            var result = poker.ComprobarCartas();
            var poker = new ExceptionTestClass();

            Assert.Throws(typeof(Exception), () => jugador.comprobarCartas(0));
            //Thrown new exception("Las cartas son iguales");
            Assert.AreEqual("0", result);
        }
    }
}
