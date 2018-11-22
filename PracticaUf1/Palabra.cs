using System;
namespace PracticaUf1
{
    public class Palabra
    {
		String item;
		int posicion;
		Boolean horizontal;
		Boolean encontrada;
		public Palabra(String item, int posicion, Boolean horizontal)
		{
			this.encontrada = false;
			this.item = item;
			this.posicion = posicion;
			this.horizontal = horizontal;
		}
		public String Item
        {
            get { return item; }
            set { item = value; }
        }
		public int Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }
		public Boolean Horizontal
        {
            get { return horizontal; }
            set { horizontal = value; }
        }
		public Boolean Encontrada
        {
			get { return encontrada; }
			set { encontrada = value; }
        }
	}
}
