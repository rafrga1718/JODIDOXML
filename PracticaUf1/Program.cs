using System;
using System.IO;
//using System.Xml;
using System.Collections;
using System.Collections.Generic;
using PracticaUf1.Properties;
namespace PracticaUf1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			List<Palabra> palabras = new List<Palabra>();
			Tablero tablero= new Tablero();
			//FuncionalidadTablero.InsertarPalabras(tablero);
			TratarFicheros.AlmacenaPalabras(tablero);
			Console.WriteLine(tablero.Palabras[0]);
			Console.WriteLine(tablero.Casillas[50].Letra);
			Console.WriteLine(FuncionalidadTablero.CalcularLongitud(tablero, 0));//va
			Posicion posicion;
			//Posicion posicion = FuncionalidadTablero.BuscarCasillaVacia(tablero);
			//Console.WriteLine(posicion.Posicionx);
			//Console.WriteLine(posicion.Posiciony);
			//Console.WriteLine("orientacion"+FuncionalidadTablero.DeterminarOrientacion());
			//Console.WriteLine("orientacion real: " + FuncionalidadTablero.ProbarOrientacion(tablero, 0, posicion));
			//Posicion posicion = FuncionalidadTablero.BuscarCasillaVacia(tablero);
			//FuncionalidadTablero.InsertaPalabra(tablero, FuncionalidadTablero.ProbarOrientacion(tablero, 0, posicion), posicion, 0);
			//FuncionalidadTablero.MostrarTablero(tablero);
			//Console.WriteLine("tamaño: "+tablero.Palabras.Count);
			for (int i = 0; i < tablero.Palabras.Count; i++){
				System.Threading.Thread.Sleep(50);
				posicion = FuncionalidadTablero.BuscarCasillaVacia(tablero);
				FuncionalidadTablero.InsertaPalabra(tablero, FuncionalidadTablero.ProbarOrientacion(tablero, i, posicion), posicion, i, palabras);
			}
			TratarFicheros.BuscaPalabras(tablero, palabras);
			FuncionalidadTablero.MostrarTablero(tablero);
			TratarFicheros.AlmacenaPalabras(tablero);
			TratarFicheros.CreaSopaLetras(tablero);
			TratarFicheros.CreaInfoDetallada(tablero);
			foreach(Palabra palabra in palabras){
				Console.WriteLine("Palabra: " + palabra.Item + " posicion: " + palabra.Posicion + " orientacion: " + palabra.Horizontal+ " encontrada: "+palabra.Encontrada);
			}
			TratarFicheros.PintaPalabras(tablero, palabras);
        }
    }
}
