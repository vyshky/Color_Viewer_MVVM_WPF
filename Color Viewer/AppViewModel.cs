using Color_Viewer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Color_Viewer
{
    public class AppViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void PropertyChanging([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        Color _color;
        bool _chBAlpha;
        bool _chBRed;
        bool _chBGreen;
        bool _chBBlue;
        List<ARGB> _colorsList;

        public AppViewModel()
        {
            _color = new Color();
            _color = Colors.Black;
            _colorsList = new List<ARGB>();
            _colorsList.Add(new ARGB(_color));
        }
        public void Refresh()
        {
            PropertyChanging("ColorBackground");
        }

        public ICommand AddColor
        {
            get
            {
                return new ButtonCommand(
                    () =>
                    {
                        ARGB newARGB = new ARGB(ColorBackground);
                        foreach (var color in _colorsList)
                        {
                            if (color.Code.Contains(newARGB.Code)) return;
                        }
                        _colorsList.Add(newARGB);
                        ColorsList = new List<ARGB>(_colorsList);
                    }
                    );
            }
        }
        public List<ARGB> ColorsList
        {
            get
            {
                return _colorsList;
            }
            set
            {
                _colorsList = value;
                PropertyChanging();
            }
        }

        public bool ChBAlpha
        {
            get { return _chBAlpha; }
            set
            {
                _chBAlpha = value;
            }
        }

        public bool ChBRed
        {
            get { return _chBRed; }
            set
            {
                _chBRed = value;
            }
        }

        public bool ChBGreen
        {
            get { return _chBGreen; }
            set
            {
                _chBGreen = value;
            }
        }
        public bool ChBBlue
        {
            get { return _chBBlue; }
            set
            {
                _chBBlue = value;
            }
        }

        public Color ColorBackground
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                PropertyChanging();
            }
        }
        public byte SliderAlpha
        {
            get { return _color.A; }
            set
            {
                if (ChBAlpha)
                {
                    _color.A = value;
                    Refresh();
                    PropertyChanging();
                }
            }
        }

        public byte SliderRed
        {
            get { return _color.R; }
            set
            {
                if (ChBRed)
                {
                    _color.R = value;
                    Refresh();
                    PropertyChanging();
                }
            }
        }

        public byte SliderGreen
        {
            get { return _color.G; }
            set
            {
                if (ChBGreen)
                {
                    _color.G = value;
                    Refresh();
                    PropertyChanging();
                }
            }
        }
        public byte SliderBlue
        {
            get { return _color.B; }
            set
            {
                if (ChBBlue)
                {
                    _color.B = value;
                    Refresh();
                    PropertyChanging();
                }
            }
        }
    }
}
