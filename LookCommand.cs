using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look" }) { }

        public override string Execute(Player p, string[] text)
        {
            // Check format of command
            if (text.Length != 3 && text.Length != 5)
            {
                return "I don't know how to look there";
            }
            else if (text[0].ToLower() != "look")
            {
                return "Error in look input";
            }
            else if (text[1].ToLower() != "at")
            {
                return "What do you want to look at?";
            }
            else if (text.Length == 5)
            {
                if (text[3].ToLower() != "in")
                {
                    return "What do you want to look in?";
                }
            }

            // The Player is the container
            if (text.Length == 3)
            {
                string? item_desc = LookAtIn(text[2], p);
                if (item_desc != null)
                {
                    return item_desc;
                }
                else
                {
                    return $"I cannot find the {text[2]}";
                }
            }

            // The container is in the Player's inventory
            if (text.Length == 5)
            {
                IHaveInventory? container = FetchContainer(p, text[4]);
                if (container != null)
                {
                    string? item_desc = LookAtIn(text[2], container);
                    if (item_desc != null)
                    {
                        return item_desc;
                    }
                    else
                    {
                        return $"I cannot find the {text[2]} in the {container.Name}";
                    }
                }
                else
                {
                    return $"I cannot find the {text[4]}";
                }
            }

            // Command is invalid
            return "I don't know how to look there";
        }

        private IHaveInventory? FetchContainer(Player p, string container_ID)
        {
            return p.Locate(container_ID) as IHaveInventory;
        }

        private string? LookAtIn(string thing_ID, IHaveInventory container)
        {
            GameObject? item = container.Locate(thing_ID);
            if (item != null)
            {
                return item.FullDescription;
            }
            else
            {
                return null;
            }
        }
    }
}
