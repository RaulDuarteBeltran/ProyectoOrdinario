using System;
namespace ProyectoOrdinario.Interfaces
{
	public interface IJuego
	{
		IDealer Dealer { get; }
		void AgregarJugador(IJugador jugador);
		void IniciarJuego();
		void MostrarGanador();
	}
}

