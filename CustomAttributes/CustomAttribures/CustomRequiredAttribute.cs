

using System.Text.RegularExpressions;

namespace CustomAttributes.CustomAttribures;
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple =true)]
    public class CustomRequiredAttribute : Attribute
    {
   
}

