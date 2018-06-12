using System;
using System.IO;
using System.Xml.Serialization;

namespace CC_Synchronizer.AppService.Data
{
    public class SyncXMLSerializer<T>
    {
        public string Serializer(T temp)
        {
            String s = "";
            XmlSerializer XML = new XmlSerializer(typeof(T));
            using (StringWriter textWriter = new StringWriter())
            {
                XML.Serialize(textWriter, temp);
                s = textWriter.ToString();
            }
            return s;
        }

        public T Deserialize(string s)
        {

            using (StringReader textWriter = new StringReader(s))
            {
                XmlSerializer XML = new XmlSerializer(typeof(T));
                return (T)XML.Deserialize(textWriter);
            }

        }
    }
}
