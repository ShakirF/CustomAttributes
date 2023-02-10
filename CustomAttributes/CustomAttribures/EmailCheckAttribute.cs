
using CustomAttributes.Models;
using System.Text.RegularExpressions;

namespace CustomAttributes.CustomAttribures;
[AttributeUsage(AttributeTargets.Method| AttributeTargets.Property,AllowMultiple =true)]
    public class EmailCheckAttribute : Attribute
    {
    public bool IsValid(object value)
    {
        Person person = value as Person;
        Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$");
        return regex.IsMatch(person.Email);
    }
}

