using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Repository
{
    public class HangingMan
    {
        public int BodyParts { get; set; }
        public HangingMan(int bodyParts)
        {
            BodyParts = bodyParts;
        }
        public HangingMan() { }
    }
}
