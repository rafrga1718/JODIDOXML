using System;
using System.Collections;
using System.Collections.Generic;
using PracticaUf1.Properties;
namespace PracticaUf1
{
    public static class FuncionalidadTablero
    {
		public static void MostrarTablero(Tablero tablero)
        {
			for (int i = 0, size = 0; i < (tablero.Dimension * tablero.Dimension) && size < tablero.Dimension; i++, size++)
            {
				Console.Write(tablero.Casillas[i].Letra+"  ");
				if(size==(tablero.Dimension-1))
				{
					Console.WriteLine();
					size = -1;
				}
            }
        }
		public static int CalcularLongitud(Tablero tablero, int i)
		{
			return tablero.Palabras[i].ToString().Length;
		}
		public static Posicion BuscarCasillaVacia(Tablero tablero)
		{
			int i;
			System.Threading.Thread.Sleep(5);

			Random rnd = new Random();
			int casilla = rnd.Next(0, tablero.Dimension * tablero.Dimension);
			for (i = 0; i < (tablero.Dimension * tablero.Dimension * 2) && tablero.Casillas[casilla].Palabra != false; i++){
				System.Threading.Thread.Sleep(5);
				casilla = rnd.Next(0, tablero.Dimension * tablero.Dimension);
			}
			return tablero.Casillas[casilla].Posicion;
		}
		public static int DeterminarOrientacion()
		{
			System.Threading.Thread.Sleep(5);
			Random rnd = new Random();
			int orientacion = rnd.Next(0, 2);
			return orientacion;		
		}
		public static int CalcularCasilla(Tablero tablero, Posicion posicion)
        {
			int numeroCasilla = posicion.Posiciony * tablero.Dimension + posicion.Posicionx;
            return numeroCasilla;
        }
		public static int ProbarOrientacion(Tablero tablero, int i,Posicion posicion){
			int numPalabra = CalcularCasilla(tablero,posicion);
			int longitud = CalcularLongitud(tablero, i);
			int orientacion = DeterminarOrientacion();
			Console.WriteLine("nuevo orientacion"+orientacion);
            int check = 0;

			if (orientacion == 0)
			{ //orientación x
				check = 0;
				for (int x = 0; x < longitud && tablero.Dimension - posicion.Posicionx >= longitud && tablero.Casillas[numPalabra + x].Palabra == false; x++)
				{
					check++;
					if (check == longitud - 1)
					{
						return 0;
					}
				}
			}
			else if (orientacion == 1)
			{
				check = 0;
				for (int y = 0; y < longitud && tablero.Dimension - posicion.Posiciony>= longitud && tablero.Casillas[numPalabra + tablero.Dimension*y].Palabra == false; y++)
				{//orientación y

					check++;
					if (check == longitud - 1)
					{
						return 1;
					}
				}

			}
			return 2;
			}
			
		public static void InsertaPalabra(Tablero tablero, int orientacion, Posicion posicion, int i, List<Palabra> palabras)
		{
			if(orientacion==0){
				int numeroCasilla = CalcularCasilla(tablero, posicion);
				for (int x = 0; x < CalcularLongitud(tablero, i) ;x++)
				{	
					//TratarFicheros.CreaXML(tablero);
					Console.WriteLine("horizontal");          
					//Console.WriteLine(tablero.Casillas[numeroCasilla].Letra);
					String palabra = tablero.Palabras[i].ToString();
					Console.WriteLine(palabra[x]);
					tablero.Casillas[numeroCasilla+x].Letra = palabra[x];
					tablero.Casillas[numeroCasilla + x].Llena = true;

					//posicion.Posicionx = posicion.Posicionx + 1;
				}
				palabras.Add(new Palabra(tablero.Palabras[i].ToString(), numeroCasilla, true));
			}
			else if (orientacion==1)
			{
				int numeroCasilla = CalcularCasilla(tablero, posicion);
				for (int y = 0; y < CalcularLongitud(tablero, i); y++)
                {
					Console.WriteLine("vertical");
                    //Console.WriteLine(tablero.Casillas[numeroCasilla].Letra);
                    String palabra = tablero.Palabras[i].ToString();
                    Console.WriteLine(palabra[y]);
					tablero.Casillas[numeroCasilla + tablero.Dimension*y].Letra = palabra[y];
					tablero.Casillas[numeroCasilla + tablero.Dimension * y].Palabra = true;
                         //posicion.Posicionx = posicion.Posicionx + 1;
                }
				palabras.Add(new Palabra(tablero.Palabras[i].ToString(), numeroCasilla, false));
			}

		}


    }
}
