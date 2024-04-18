using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();

        public IdentifiableObject(string[] idents)
        {
            foreach (string ident in idents)
            {
                _identifiers.Add(ident);
            }
        }

        public bool AreYou(string elem)
        {
            foreach (string ident in _identifiers)
            {
                if (elem.ToLower() == ident)
                {
                    return true;
                }
            }
            return false;
        }

        public string FirstId
        {
            get
            {
                if (_identifiers.Count == 0)
                {
                    return "";
                }
                else
                {
                    return _identifiers[0];
                }
            }
        }

        public void AddIdentifier(string ident)
        {
            _identifiers.Add(ident.ToLower());
        }
    }
}
