using System;
namespace PracticaUf1
{
    public class Posicion
    {
		private int posicionx;
        private int posiciony;
		public Posicion(int posicionx, int posiciony)
        {
			this.posicionx = posicionx;
            this.posiciony = posiciony;
        }
		public int Posicionx
        {
            get { return posicionx; }
            set { posicionx = value; }
        }
        public int Posiciony
        {
            get { return posiciony; }
            set { posiciony = value; }
        }
    }
}
