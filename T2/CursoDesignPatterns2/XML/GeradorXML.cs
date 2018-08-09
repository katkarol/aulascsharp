using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CursoDesignPatterns2.XML
{
    public class GeradorXML
    {
        public String GerarXml(Object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, o);

            return writer.ToString();
        }
    }
}
