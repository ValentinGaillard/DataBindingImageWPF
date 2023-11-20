using System;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace CineFile
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private BitmapImage _imageSource;

        public BitmapImage ImageSource
        {
            get { return _imageSource; }
            set
            {
                _imageSource = value;
                OnPropertyChanged(nameof(ImageSource));
            }
        }

        public MainViewModel()
        {
            // Set the initial image source using a relative path
            ImageSource = new BitmapImage(new Uri("pack://application:,,,/medias/CielBird.png", UriKind.RelativeOrAbsolute));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}