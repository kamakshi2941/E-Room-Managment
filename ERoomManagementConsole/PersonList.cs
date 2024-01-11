using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ERoomManagementConsole
{
    [XmlRoot("RegisterList")]
    [XmlInclude(typeof(Person))]
    [XmlInclude(typeof(FloorFirst))]
    [XmlInclude(typeof(FloorSecond))]
    [XmlInclude(typeof(FloorThird))]
    public class PersonList : IDisposable
    {

        private List<AbstractPerson> person = null;

        [XmlArray("Registers")]
        [XmlArrayItem("Register", typeof(AbstractPerson))]
        public List<AbstractPerson> Person { get { return person; } set { person = value; } }

        public PersonList()
        {
            Person = new List<AbstractPerson>();
        }

        public void Add(AbstractPerson book)
        {
            Person.Add(book);
        }

        public void Remove(AbstractPerson book)
        {
            Person.Remove(book);
        }


        public bool Contains(AbstractPerson book)
        {
            return Person.Contains(book);
        }

        public int Count()
        {
            return Person.Count();
        }

        public AbstractPerson this[int i]
        {
            get { return Person[i]; }
        }

        public void Sort()
        {
            Person.Sort();
        }

        public void Clear()
        {
            Person.Clear();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
