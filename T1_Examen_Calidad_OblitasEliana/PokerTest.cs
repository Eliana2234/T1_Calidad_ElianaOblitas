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

            Assert.Throws(typeof(Exception), () => jugador.comprobarJugadores(2);
            //Thrown new exception("Se necesitan más de 2 jugadores");
            Assert.AreEqual(null, result);
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
            Assert.AreEqual(null, result);
        }

        [Test]
        public void Caso04()//Empate en el juego
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "1, 2, 3, 4, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "7, 5, 6, 8, 9" });

            var result = poker.VerificarEmpate();

            Assert.AreEqual("Empate", result);
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

        //________________________________________________________________________________________________2

        [Test]
        public void Caso06()//Ganador del juego
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "1, 6, 3, 7, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "7, 5, 8, 9, 2" });

            var result = poker.MostrarGanador();

            Assert.AreEqual("Jugador 1", result);
        }

        [Test]
        public void Caso07()//Mínimo 2 jugadores
        {
            var Jugador = new ExceptionTestClass();

            var jugador = new Jugador();
            jugador.AddJugador("Jose");
            jugador.AddJugador("María");
            jugador.AddJugador("Ivan");

            var result = contarJugadores();

            Assert.Throws(typeof(Exception), () => jugador.comprobarJugadores(3);
            //Thrown new exception("Se necesitan más de 2 jugadores");
            Assert.AreEqual(null, result);
        }

        [Test]
        public void Caso08()//Maximo 5 jugadores
        {
            var Jugador = new ExceptionTestClass();

            var jugador = new Jugador();
            jugador.AddJugador("Jose");
            jugador.AddJugador("María");
            jugador.AddJugador("Luis");
            jugador.AddJugador("Isabel");
            jugador.AddJugador("Fernando");
            jugador.AddJugador("Ivan");
            jugador.AddJugador("Hugo");

            var result = contarJugadores();

            Assert.Throws(typeof(Exception), () => jugador.contarJugadores(6);
            //Thrown new exception("No se permiten mas de 6 jugadores");

        }

        [Test]
        public void Caso09()////Empate en el juego
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "7, 8, 9, 10, 11" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "2, 1, 3, 4, 5" });

            var result = poker.VerificarEmpate();

            Assert.AreEqual("Empate", result);
        }

        [Test]
        public void Caso10()//Cartas Iguales 1 = Cartas iguales y 0 = Cartas diferentes
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "5, 6, 4, 9, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "3, 2, 1, 4, 5" });

            var result = poker.ComprobarCartas();
            var poker = new ExceptionTestClass();

            Assert.Throws(typeof(Exception), () => jugador.comprobarCartas(0));
            //Thrown new exception("Las cartas son iguales");
            Assert.AreEqual("0", result);
        }
        //________________________________________________________________________________________________3

        [Test]
        public void Caso11()//Ganador del juego
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "1, 2, 6, 4, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "7, 5, 6, 8, 1" });
            poker.CartasJugador3(new Jugador { Nombre = "Jugador 3", Cartas = "10, 9, 6, 8, 7" });

            var result = poker.MostrarGanador();

            Assert.AreEqual("Jugador 3", result);
        }

        [Test]
        public void Caso12()//Mínimo 2 jugadores
        {
            var Jugador = new ExceptionTestClass();

            var jugador = new Jugador();
            jugador.AddJugador("Jose");

            var result = contarJugadores();

            Assert.Throws(typeof(Exception), () => jugador.comprobarJugadores(3);
            //Thrown new exception("Hay mas de 6 jugadores");
            Assert.AreEqual(null, result);
        }

        [Test]
        public void Caso13()//Maximo 5 jugadores
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
        public void Caso14()//Ganador del juego
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "1, 2, 3, 4, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "7, 8, 6, 11, 9" });

            var result = poker.VerificarEmpate();

            Assert.AreEqual("Empate", result);
        }

        [Test]
        public void Caso15()//Cartas Iguales 1 = Cartas iguales y 0 = Cartas diferentes
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "1, 2, 3, 4, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "3, 2, 1, 4, 5" });
            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "7, 8, 6, 11, 9" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "11, 10, 1, 3, 8" });

            var result = poker.ComprobarCartas();
            var poker = new ExceptionTestClass();

            Assert.Throws(typeof(Exception), () => jugador.comprobarCartas(0));
            //Thrown new exception("Las cartas son iguales");
            Assert.AreEqual("0", result);
        }

        //________________________________________________________________________________________________4

        [Test]
        public void Caso16()//Ganador del juego
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "9, 10, 3, 4, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "7, 5, 6, 8, 1" });

            var result = poker.MostrarGanador();

            Assert.AreEqual("Jugador 1", result);
        }

        [Test]
        public void Caso17()//Mínimo 2 jugadores
        {
            var Jugador = new ExceptionTestClass();

            var jugador = new Jugador();
            jugador.AddJugador("Jose");
            jugador.AddJugador("María");

            var result = contarJugadores();

            Assert.Throws(typeof(Exception), () => jugador.comprobarJugadores(contador);
            //Thrown new exception("Se necesitan más de 2 jugadores");
            Assert.AreEqual(null, result);
        }

        [Test]
        public void Caso18()//Maximo 5 jugadores
        {
            var Jugador = new ExceptionTestClass();

            var jugador = new Jugador();
            jugador.AddJugador("Jose");
            jugador.AddJugador("María");
            jugador.AddJugador("Luis");
            jugador.AddJugador("Isabel");
            jugador.AddJugador("Fernando");
            jugador.AddJugador("Ivan");
            jugador.AddJugador("Fabrizio");
            jugador.AddJugador("Esteban");
            jugador.AddJugador("Andres");
            jugador.AddJugador("Julio");

            var result = contarJugadores();

            Assert.Throws(typeof(Exception), () => jugador.contarJugadores(6);
            Assert.AreEqual(null, result);
        }

        [Test]
        public void Caso19()//Ganador del juego
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "1, 2, 3, 4, 9" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "1, 2, 3, 4, 5" });

            var result = poker.MostrarGanador();

            Assert.AreEqual("Empate", result);
        }

        [Test]
        public void Caso20()//Cartas Iguales 1 = Cartas iguales y 0 = Cartas diferentes
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

        //________________________________________________________________________________________________5

        [Test]
        public void Caso21()//Ganador del juego
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "1, 2, 3, 4, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "7, 5, 6, 8, 1" });

            var result = poker.MostrarGanador();

            Assert.AreEqual("Jugador 1", result);
        }

        [Test]
        public void Caso22()//Mínimo 2 jugadores
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
        public void Caso23()//Maximo 5 jugadores
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
        public void Caso24()//Ganador del juego
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "1, 2, 3, 4, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "7, 5, 6, 8, 9" });

            var result = poker.MostrarGanador();

            Assert.AreEqual("Empate", result);
        }

        [Test]
        public void Caso25()//Cartas Iguales 1 = Cartas iguales y 0 = Cartas diferentes
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

        //________________________________________________________________________________________________6

        [Test]
        public void Caso26()//Ganador del juego
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "1, 2, 3, 4, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "7, 5, 6, 8, 1" });

            var result = poker.MostrarGanador();

            Assert.AreEqual("Jugador 1", result);
        }

        [Test]
        public void Caso27()//Mínimo 2 jugadores
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
        public void Caso28()//Maximo 5 jugadores
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
        public void Caso29()//Ganador del juego
        {
            var poker = new Poker();

            poker.CartasJugador1(new Jugador { Nombre = "Jugador 1", Cartas = "1, 2, 3, 4, 5" });
            poker.CartasJugador2(new Jugador { Nombre = "Jugador 2", Cartas = "7, 5, 6, 8, 9" });

            var result = poker.MostrarGanador();

            Assert.AreEqual("Empate", result);
        }

        [Test]
        public void Caso30()//Cartas Iguales 1 = Cartas iguales y 0 = Cartas diferentes
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
