using System;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Text;
using System.Collections.Generic;

namespace Items
{
	public class XMLMannager<T>: IArchivo<T>
	{
		public bool Guardar(string archivo, T datos)
		{

			try
			{
				using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(T));
					serializer.Serialize(writer, datos);
				}

				return true;

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return false;
			}
		}

		public bool Leer(string archivo, out T datos)
		{
			try
			{
				using (XmlTextReader reader = new XmlTextReader(archivo))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(T));
					datos = (T)serializer.Deserialize(reader);
					return true;
				}

			}
			catch (Exception)
			{
				datos = default(T);
				return false;
			}
		}
	}
}

