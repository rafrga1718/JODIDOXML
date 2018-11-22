using System;
namespace PracticaUf1.Properties
{
    public class Casilla
    {
		private Boolean llena;
		private Posicion posicion;
		private Boolean palabra;
		private Char letra;
		private ConsoleColor color;
        /**
         *constructor parametrizado
         *
         *param name="posicionx"
         *param name="posiciony" 
         */
		public Casilla(int x, int y)
		{
			this.posicion = new Posicion(x,y);
			this.llena = false;
            this.palabra = false;
			Random random = new Random();
			char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
			System.Threading.Thread.Sleep(5);
			this.letra = alpha[random.Next(0, 26)];
		}
		public Boolean Palabra
        {
            get { return palabra; }
            set { palabra = value; }
        }
		public Boolean Llena
        {
            get { return llena; }
            set { llena = value; }
        }
		public Posicion Posicion
        {
			get { return posicion; }
			set { posicion = value; }
        }
        
		public Char Letra
        {
			get { return letra; }
			set { letra = value; }
        }
		public ConsoleColor Color
        {
			get { return color; }
			set { color = value; }
        }
	}
}
