using System;


namespace Defining_Classes___Part_2
{
    [AttributeUsage(AttributeTargets.Struct |
  AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
  AllowMultiple = true)]
    public class CustomVersion : System.Attribute
    {
        public CustomVersion():this(null)
        {
        }
        public CustomVersion(Version version)
        {
            this.Version = version;
        }
        private  Version version = new Version(2, 11);
        public Version Version
        {
            get
            {
                return this.version;
            }
            private set
            {
                this.version = value;
            }
        }

    }
}
