using CustomAttributes.CustomAttribures;
using CustomAttributes.Models;
using System.Reflection;

Person person = new Person()
{
    Name = "Shakir",
    Surname = "Farajullayev"
};

Console.WriteLine(ModelState.IsValid(person));


public class ModelState
{
    public static bool IsValid(Person p)
    {
        foreach(var item in p.GetType().GetProperties())
        {
            object[] attributes =  item.GetCustomAttributes(typeof(CustomRequiredAttribute), true);
            if (attributes.Length != 0)
            {
                object? value = item.GetValue(p);
                if (value == null) return false;
            }
        }
        return true;
    }
   


}