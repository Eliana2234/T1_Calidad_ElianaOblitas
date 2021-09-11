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
            var jugador = new Jugador();
            jugador.AddCarta(4,"Jose");
            jugador.AddCarta(3, "Jose");
            jugador.AddCarta(5, "Jose");
            jugador.AddCarta(2, "Jose");
            jugador.AddCarta(1, "Jose");

            jugador.AddCarta(8, "Maria");
            jugador.AddCarta(6, "Maria");
            jugador.AddCarta(1, "Maria");
            jugador.AddCarta(7, "Maria");
            jugador.AddCarta(9, "Maria");

            var result = MostrarGanador();

            Assert.AreEqual("Jose", result.name);
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

            Assert.Throws(typeof(Exception), () => jugador.contarJugadores(contador);
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
        public void Caso04()//Cartas Iguales
        {
            var jugador = new Jugador();
            jugador.AddCarta(4, "Jose");
            jugador.AddCarta(3, "Jose");
            jugador.AddCarta(5, "Jose");
            jugador.AddCarta(2, "Jose");
            jugador.AddCarta(1, "Jose");

            jugador.AddCarta(1, "Maria");
            jugador.AddCarta(4, "Maria");
            jugador.AddCarta(2, "Maria");
            jugador.AddCarta(3, "Maria");
            jugador.AddCarta(5, "Maria");

            var result = comprobarCartas();

            Assert.Throws(typeof(Exception), () => jugador.comprobarCartas(jugador1, jugador2));
            Assert.AreEqual(, result);
        }
    }
}
