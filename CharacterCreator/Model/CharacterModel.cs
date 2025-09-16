using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CharacterCreator.Model
{
    internal class CharacterModel
    {

        private int _str;
        private int _dex;
        private int _con;
        private int _int;
        private int _wis;
        private int _cha;
        private string _imgSrc;
        private int numberofImages = 3;
        private string[] _images = {"character1.jpg", "character2.jpg", "character3.jpg" }; 

        private Random _rand;

        public event EventHandler<CharacterEventArgs> CharacterChanged;
        public CharacterModel() 
        {
            _rand = new Random();
            _str = 0;
            _dex = 0;
            _con = 0;
            _int = 0;
            _wis = 0;
            _cha = 0;
            _imgSrc = "character1.jpg";
        }

        public void CreateNewCharacter()
        {
            _str = _rand.Next(1,101);
            _dex = _rand.Next(1, 101);
            _con = _rand.Next(1, 101);
            _int = _rand.Next(1, 101);
            _wis = _rand.Next(1, 101);
            _cha = _rand.Next(1, 101);

            _imgSrc = "character" +_rand.Next(1,4)+".jpg";

            /* switch (_rand.Next(0,numberofImages))
             {
                 case 0: _imgSrc = "character1.jpg";break;
                 case 1: _imgSrc = "character2.jpg";break;
                 case 2: _imgSrc = "character3.jpg";break;
                 default: _imgSrc = "character1.jpg";break;
             }
            */
             OnNewCharacter();
        }
        public void OnNewCharacter()
        {
            CharacterChanged.Invoke(this,new CharacterEventArgs(_str,_dex,_con,_int,_wis,_cha,_imgSrc));

        }

        public void SetAttr(int arrt, int value)
        {
            if (value >= 0 && value <= 100 && value != null && arrt >=0)
            {
                switch (arrt)
                {
                    case 0: _str=value; break;
                    case 1: _dex=value; break;
                    case 2: _con=value; break;
                    case 3: _int=value; break;
                    case 4: _wis=value; break;
                    case 5: _cha=value; break;
                }
            }
        }
        
        /*
        public void SetStr(int value)
        {
            if (value >= 0 && value <= 100 && value != null)
            {
                _str = value;
            }
        }
        public void SetDex(int value)
        {
            if (value >= 0 && value <= 100 && value != null)
            {
                _dex = value;
            }
        }
        public void SetCon(int value)
        {
            if (value >= 0 && value <= 100 && value != null)
            {
                _con = value;
            }
        }
        public void SetInt(int value)
        {
            if (value >= 0 && value <= 100 && value != null)
            {
                _int = value;
            }
        }
        public void SetWis(int value)
        {
            if (value >= 0 && value <= 100 && value != null)
            {
                _wis = value;
            }
        }
        public void SetCha(int value)
        {
            if (value >= 0 && value <= 100 && value != null)
            {
                _cha = value;
            }
        }*/
        public void SetImg(string _img)
        {
            if (_img != null)
            {
                _imgSrc = _img;
            }
        }
    }
}
