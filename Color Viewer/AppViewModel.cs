using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
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

        public AppViewModel()
        {
            _color = new Color();
            _color = Colors.Black;
        }
        public void Refresh()
        {
            PropertyChanging("ColorBackground");
        }

        public bool ChBAlpha
        {
            get { return _chBAlpha; }
            set
            {
                _chBAlpha = value;
                //Refresh();
            }
        }

        public bool ChBRed
        {
            get { return _chBRed; }
            set
            {
                _chBRed = value;
                //Refresh();
            }
        }

        public bool ChBGreen
        {
            get { return _chBGreen; }
            set
            {
                _chBGreen = value;
                //Refresh();
            }
        }
        public bool ChBBlue
        {
            get { return _chBBlue; }
            set
            {
                _chBBlue = value;
                //Refresh();
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
