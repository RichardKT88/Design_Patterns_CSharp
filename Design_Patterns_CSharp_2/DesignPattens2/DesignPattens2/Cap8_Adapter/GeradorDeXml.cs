using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPattens2.Capitulo08
{
    class GeradorDeXml
    {
        public String GeraXML(object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());

            StringWriter writer = new StringWriter();

            serializer.Serialize(writer, o);

            return writer.ToString();
        }
    }
}
