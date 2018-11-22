using System;
using System.Collections;
using System.Collections.Generic;
using PracticaUf1.Properties;

namespace PracticaUf1
{
    public class Tablero
    {
		private int dimension;
		private ArrayList palabras=new ArrayList();
		private List<Casilla> casillas = new List<Casilla>();
        public Tablero()
        {
			this.dimension = 15;
			for (int y = 0; y < this.dimension; y++){
				for (int x = 0; x < this.dimension; x++){
					this.casillas.Add(new Casilla(x, y));
				}
			}

			

        }
		public ArrayList Palabras
        {
			get { return palabras; }
			set { palabras = value; }
        }
		public int Dimension
        {
            get { return dimension; }
			set { dimension = value; }
        }
		public List<Casilla> Casillas
        {
            get { return casillas; }
			set { casillas = value; }
        }

    }
}
