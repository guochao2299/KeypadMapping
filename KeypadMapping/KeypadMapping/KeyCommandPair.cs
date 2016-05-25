using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace KeypadMapping
{
    [Serializable]
    public class KeyCommandPair
    {
        private Int32 m_key = -1;

        public Int32 Key
        {
            get
            {
                return m_key;
            }
            set
            {
                m_key = value;
            }
        }

        private string m_command = string.Empty;

        public string Command
        {
            get
            {
                return m_command;
            }
            set
            {
                m_command = value;
            }
        }
        public override bool Equals(object obj)
        {
            if(obj==null || (!(obj is KeyCommandPair)))
            {
                return false;
            }

            return this.Key==((KeyCommandPair)obj).Key;
        }
        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}
