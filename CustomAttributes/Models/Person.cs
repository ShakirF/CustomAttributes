using CustomAttributes.CustomAttribures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes.Models
{
    public class Person
    {
        [CustomRequired]
        public string Name { get; set; }
        [CustomRequired]
        public string Surname  { get; set; }
        [CustomRequired]
        [EmailCheck]
        public string Email { get; set; }
    }
}
