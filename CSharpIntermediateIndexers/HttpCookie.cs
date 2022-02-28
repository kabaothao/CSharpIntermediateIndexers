using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateIndexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>(); 
        }

        public string this[string key]
        {
            get { return _dictionary[key]; } //we rely the get to store the key
            set { _dictionary[key] = value; } //we rely key to 
        }

    }
}


/*
 If you're not familiar with a dictionary it's a data type that resize in system that collections that

generic and it uses a hash table to store data hash table has a special mechanism that makes it extremely

fast to look up an item by its key.

 s*/