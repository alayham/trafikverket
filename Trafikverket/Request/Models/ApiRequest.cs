using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Trafikverket.Request.Models
{
    /// <summary>
    /// The Trafikverket API request.
    /// Reference: https://api.trafikinfo.trafikverket.se/API/TheRequest
    /// </summary>
    [XmlRootAttribute("REQUEST")]
    public class ApiRequest
    {
        [XmlElement("LOGIN")]
        public AuthKey ApiKey { get; set; }

        [XmlElement("QUERY")]
        public List<ApiQuery> Query { get; set; }

        private ApiRequest()
        {
            ApiKey = new AuthKey("");
            Query = new List<ApiQuery>();
        }
        public ApiRequest(string apiKey)
        {
            ApiKey = new AuthKey(apiKey);
            Query = new List<ApiQuery>();
        }


        public string AsXml()
        {
            XmlSerializerNamespaces emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true
            };
            StringWriter stream = new StringWriter();
            XmlWriter writer = XmlWriter.Create(stream, settings);
            XmlSerializer serializer = new XmlSerializer(this.GetType());
            serializer.Serialize(writer, this, emptyNamespaces);
            return stream.ToString();
        }
    }
}
