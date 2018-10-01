
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DataService.VerticalServices
{
    public static class XmlSerializerService
    {
        public static string XmlSerialize(object obj)
        {
            using (MemoryStream b = new MemoryStream())
            {
                var xs = new XmlSerializer(obj.GetType());

                xs.Serialize(b, obj);
                return System.Text.Encoding.UTF8.GetString(b.ToArray());
            }
        }

        public static string Serialize(object member)
        {
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(member.GetType());
            var settings = new XmlWriterSettings();
            settings.Indent = false;
            settings.OmitXmlDeclaration = true;

            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, member, emptyNamepsaces);
                return stream.ToString();
            }
        }
    }
}
