using InvoiceAPIApp.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Xml.Serialization;

// https://docs.microsoft.com/pl-pl/aspnet/web-api/overview/formats-and-model-binding/media-formatters
// http://www.intstrings.com/ramivemula/articles/simple-custom-media-formatter-in-asp-net-web-api/
// https://stackoverflow.com/questions/10390356/serializing-deserializing-with-memory-stream
// https://stackoverflow.com/questions/30698349/xml-serializing-and-deserializing-with-memory-stream


namespace InvoiceAPIApp.Controllers.Formatter
{
    public class InvoiceXmlFormatter : MediaTypeFormatter
    {
        public InvoiceXmlFormatter()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/xml"));
        }

        public override Task<object> ReadFromStreamAsync(Type type, Stream readStream, HttpContent content, IFormatterLogger formatterLogger)
        {
            var taskCompletionSource = new TaskCompletionSource<object>();
            XmlSerializer serializer = new XmlSerializer(typeof(Invoice));

            try
            {
                var memoryStream = new MemoryStream();
                readStream.CopyTo(memoryStream);
          
                // Tutaj jakas wlasna implementacja deserializacji
                memoryStream.Position = 0;
                Invoice newInvoice = (Invoice)serializer.Deserialize(memoryStream);
                taskCompletionSource.SetResult(newInvoice);
            }
            catch (Exception e)
            {
                taskCompletionSource.SetException(e);
            }
            return taskCompletionSource.Task;
        }

        public override Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, System.Net.TransportContext transportContext, System.Threading.CancellationToken cancellationToken)
        {
            // TO DO NAPISANIA
            var buff = System.Text.Encoding.UTF8.GetBytes(value.ToString());
            return writeStream.WriteAsync(buff, 0, buff.Length, cancellationToken);
        }

        public override bool CanReadType(Type type)
        {
            return type == typeof(Invoice);
        }

        public override bool CanWriteType(Type type)
        {
            return type == typeof(Invoice);
        }

        public static object DeserializeFromStream(MemoryStream stream)
        {
            IFormatter formatter = new BinaryFormatter();
            stream.Seek(0, SeekOrigin.Begin);
            object o = formatter.Deserialize(stream);
            return o;
        }
    }
}