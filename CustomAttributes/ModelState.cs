
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CustomAttributes;

    public class ModelState
    {
        public static bool IsValid<T>(T model)
        {
            foreach(var item in model.GetType().GetProperties())
            {
                var email = item.GetCustomAttributes(typeof(EmailAddressAttribute), true);
                if (email != null)
                {
                    var methods = email.GetType().GetMethod("IsValid",BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    bool result = (bool)methods.Invoke(email, new object[] { model });
                    if(!result) return false;
                }
                
            }
            return true;
        }
    }

