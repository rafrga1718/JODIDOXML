using System;
using System.IO;
//using System;
using System.Collections;
using System.Collections.Generic;
using PracticaUf1.Properties;
namespace PracticaUf1
{
    public static class TratarFicheros
    {
		public static void AlmacenaPalabras(Tablero tablero)
		{
			try{            
                String desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				String path= desktop + "/SopaLletres/Palabras.txt";
				File.Exists(path);
				String[] content = File.ReadAllLines(path);
                String[] palabras = content[0].Split(' ');
                foreach (var palabra in palabras)
				{
					tablero.Palabras.Add(palabra);
				}
			}
			catch{
				Console.Write("No existe el fichero");
			}
		}
		public static void CreaSopaLetras(Tablero tablero)
		{
			String desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String path = desktop + "/SopaLletres/SopaLletres.txt";
			if (File.Exists(path))
			{
				File.WriteAllText(path, "");
				for (int i = 0, size = 0; i < (tablero.Dimension * tablero.Dimension) && size < tablero.Dimension; i++, size++)
				{
					File.AppendAllText(path, tablero.Casillas[i].Letra + "  ");
					//Console.Write(tablero.Casillas[i].Letra + "  ");
					if (size == (tablero.Dimension - 1))
					{
						File.AppendAllText(path, "\r\n");
						size = -1;
					}
				}
			}
			else
            {
                for (int i = 0, size = 0; i < (tablero.Dimension * tablero.Dimension) && size < tablero.Dimension; i++, size++)
                {
                    File.AppendAllText(path, tablero.Casillas[i].Letra + "  ");
                    //Console.Write(tablero.Casillas[i].Letra + "  ");
                    if (size == (tablero.Dimension - 1))
                    {
						File.AppendAllText(path, "\r\n");
                        size = -1;
                    }
                }  
			}
				
		}
		public static void CreaInfoDetallada(Tablero tablero)
		{
			Dictionary<string, string> info =new Dictionary<string, string>();
			String desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String path = desktop + "/SopaLletres/Palabras.txt";
			String infoPath = desktop + "/SopaLletres/InfoDetallada.txt";
			FileInfo file = new FileInfo(path);
			info.Add("Nom del fitxer: ", file.Name);
			info.Add("Extensió: ", file.Extension);
			info.Add("Data de creació: ", file.CreationTime.ToString());
			info.Add("Data de modificació: ", file.LastWriteTime.ToString());
			info.Add("Numero de mots: ", file.Length.ToString());
			foreach (KeyValuePair<string, string> kvp in info)
            {
				File.AppendAllText(infoPath, kvp.Key + " "+ kvp.Value +"\r\n");
            }
		}
		public static void CreaXML(Tablero tablero)
		{
			//String desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
   //         String path = desktop + "/SopaLletres/NumeroOcurrencias.xml";
			//XmlTextWriter writer;
            //writer = new XmlTextWriter(path, Encoding.UTF8);
            //writer.Formatting = Formatting.Indented;
            //writer.WriteStartDocument();
            //writer.WriteStartElement("ejemplo");
            //writer.WriteElementString("nodo1", "texto del nodo1");
            //writer.WriteElementString("nodo2", "texto del nodo2");
            //writer.WriteEndElement();
            //writer.WriteEndDocument();
            //writer.Flush();
            //writer.Close();
		}
		public static void BuscaPalabras(Tablero tablero, List<Palabra> words)
		{
			String desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String path = desktop + "/SopaLletres/PalabrasABuscar.txt";
			String[] content = File.ReadAllLines(path);
            String[] palabras = content[0].Split(' ');           
			int i;
			foreach (var palabra in palabras)
            {
				for (i = 0; i < words.Count && palabra != words[i].Item; i++)
                {               
                }
				if (i < (words.Count - 1))
				{
					words[i].Encontrada = true;
				}
            }
		}
		public static void PintaPalabras(Tablero tablero, List<Palabra> words)
		{
			List<int> palabras = new List<int>();
			foreach (var word in words){

				if(word.Encontrada==true){
					int value=word.Posicion;
					if (word.Horizontal == true)
					{
						for (int i = 0; i < word.Item.Length; value++, i++)
						{
							palabras.Add(value);
						}
					}
					else
					{
						for (int i = 0; i < word.Item.Length; value=value+tablero.Dimension, i++)
                        {
                            palabras.Add(value);
                        }
                    }

     			}
			}
			palabras.Sort();
			int j = 0;
			for (int i = 0, size = 0; i < (tablero.Dimension * tablero.Dimension) && size < tablero.Dimension; i++, size++)
            {
				
				if (palabras[j]==i) 
				{
					j++;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(tablero.Casillas[i].Letra + "  ");
					if (size == (tablero.Dimension - 1))
					{
						Console.WriteLine();
						size = -1;
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(tablero.Casillas[i].Letra + "  ");
					if (size == (tablero.Dimension - 1))
					{
						Console.WriteLine();
						size = -1;
					}
				}
				if (j==palabras.Count){
					j = 0;
				}
            }
		}
    }

}
