using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Model
{
    public class CharacterEventArgs: EventArgs
    {
        public int Str { get; private set; }
        public int Dex { get; private set; }
        public int Con { get; private set; }
        public int Int { get; private set; }
        public int Wis { get; private set; }
        public int Cha { get; private set; }
        public string Img { get; private set; }

        public CharacterEventArgs(int str, int dex, int con, int intel, int wis, int cha,string img)
        {
            Str = str;
            Dex = dex;
            Con = con;
            Int = intel;
            Wis = wis;
            Cha = cha;
            Img = img;
        }
    }
}
