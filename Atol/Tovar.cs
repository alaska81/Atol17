using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Atol
{
    [XmlType("Tovar")]
    class Tovar : IXmlSerializable
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public double Qty { get; set; }
        public double Summa { get; set; }
        public int NDS { get; set; }
        public double NDS_value { get; set; }
        public int Discont { get; set; }
        public double Discont_value { get; set; }

        // Xml Serialization Infrastructure 
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(Title);
        }

        public void ReadXml(XmlReader reader)
        {
            Title = reader.ReadString();
        }

        public XmlSchema GetSchema()
        {
            return (null);
        } 
    }
}
