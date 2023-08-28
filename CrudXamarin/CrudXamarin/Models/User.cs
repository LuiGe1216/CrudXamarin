using System;
using System.Collections.Generic;
using System.Text;

namespace CrudXamarin.Models
{
    public class User
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int dni { get; set; }
        public int celular { get; set; }
        public  string correo { get; set; }

    }
}
