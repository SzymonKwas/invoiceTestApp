using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace InvoiceAPIApp.Models
{
    [DataContract]
    public class Invoice
    {
        // Do serializacji musi byc domyslny konstruktor bez zadnych parametrow!
        public Invoice()
        {

        }

        // Co nie przeszkadza, zeby byl przeciazony inny konstruktor z polami
        public Invoice(int id, string pole1, string pole2, string pole3KtoreNieJestWczytywane)
        {
            Id = id;
            this.pole1 = pole1;
            this.pole2 = pole2;
            this.pole3KtoreNieJestWczytywane = pole3KtoreNieJestWczytywane;
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string pole1 { get; set; }
        [DataMember]
        public string pole2 { get; set; }

        //BezDataMember
        public string pole3KtoreNieJestWczytywane { get; set; }
    }
}