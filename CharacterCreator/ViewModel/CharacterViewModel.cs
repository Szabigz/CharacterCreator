using CharacterCreator.Model;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.ViewModel
{
    internal class CharacterViewModel : ViewModelBase
    {

        private CharacterModel _characterModel;

        private int _str;
        private int _dex;
        private int _con;
        private int _int;
        private int _wis;
        private int _cha;

        private string _imgSrc;
        public int Str
        {
            get
            {
                return _str;
            }
            set
            {
                if (_str != value)
                {
                    _str = value;
                   _characterModel.SetAttr(0,value);
                    OnPropertyChanged(nameof(Str));
                }
            }
        }
        public int Dex
        {
            get
            {
                return _dex;
            }
            set
            {
                if (_dex != value)
                {
                    _dex = value;
                    _characterModel.SetAttr(1, value);
                    OnPropertyChanged(nameof(Dex));
                }
            }
        }
        public int Con
        {
            get
            {
                return _con;
            }
            set
            {
                if (_con != value)
                {
                    _con = value;
                    _characterModel.SetAttr(2, value);
                    OnPropertyChanged(nameof(Con));
                }
            }
        }
        public int Int
        {
            get
            {
                return _int;
            }
            set
            {
                if (_int != value)
                {
                    _int = value;
                    _characterModel.SetAttr(3, value);
                    OnPropertyChanged(nameof(Int));
                }
            }
        }
        public int Wis
        {
            get
            {
                return _wis;
            }
            set
            {
                if (_wis != value)
                {
                    _wis = value;
                    _characterModel.SetAttr(4, value);
                    OnPropertyChanged(nameof(Wis));
                }
            }
        }
        public int Cha
        {
            get
            {
                return _cha;
            }
            set
            {
                if (_cha != value)
                {
                    _cha = value;
                    _characterModel.SetAttr(5, value);
                    OnPropertyChanged(nameof(Cha));
                }
            }
        }

        public string Img
        {
            get
            {
                return _imgSrc;
            }
            set
            {
                if (_imgSrc != value)
                {
                    _imgSrc = value;
                    _characterModel.SetImg(value);
                    OnPropertyChanged(nameof(Img));
                }
            }
        }

        public RelayCommand NewCharacterCommand { get; private set; }

        // Change the type of ChangeImgCommand from RelayCommand to RelayCommand<string>
        public RelayCommand<string> ChangeImgCommand { get; private set; }
        public CharacterViewModel(CharacterModel model)
        {
            _characterModel = new CharacterModel();
            _characterModel.CharacterChanged += OnCharacterChanged;
            NewCharacterCommand = new RelayCommand(_characterModel.CreateNewCharacter);
            ChangeImgCommand = new RelayCommand<string>(ChangeCharacterImage);
            _imgSrc = "character1.jpg";
        }
        private void OnCharacterChanged(object sender, CharacterEventArgs jani)
        {
            Str = jani.Str;
            Dex = jani.Dex;
            Con = jani.Con;
            Int = jani.Int;
            Wis = jani.Wis;
            Cha = jani.Cha;
            Img = jani.Img;
        }
        private void ChangeCharacterImage(string p)
        {
            int param = int.Parse(p);
            switch (param)
            {
                case 0: Img = "character1.jpg"; break;
                case 1: Img = "character2.jpg"; break;
                case 2: Img = "character3.jpg"; break;
                default: Img = "character1.jpg"; break;
            }
        }
    }
}
