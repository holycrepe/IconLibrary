using System;
using System.Collections.Generic;
using System.Text;

namespace IconLibrary
{
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
    public class IconEnumAttribute : Attribute
    {
        public IconEnumAttribute(string assemblyDefaultNamespace)
        {
            this.AssemblyDefaultNamespace = assemblyDefaultNamespace;
        }

        public string AssemblyDefaultNamespace
        {
            get;
            private set;
        }
    }
}
