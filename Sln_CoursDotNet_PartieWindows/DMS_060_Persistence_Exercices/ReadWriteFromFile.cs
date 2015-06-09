using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DMS_060_Persistence_Exercices
{
    public class ReadWriteFromFile<T>
    {
        protected XmlSerializer serializer = new XmlSerializer(typeof(T));
        private string pathFileAndName;

        public ReadWriteFromFile(string pathFileAndName) 
        {
            this.pathFileAndName = pathFileAndName;
        }

        public T readFromFile()
        {
            StreamReader reader = new StreamReader(pathFileAndName);
            T datas = (T) serializer.Deserialize(reader);
            reader.Close();

            return datas;
        }

        public void writeToFile(T datas)
        {
            StreamWriter write = new StreamWriter(pathFileAndName);
            serializer.Serialize(write, datas);
            write.Close();
        }
    }
}
