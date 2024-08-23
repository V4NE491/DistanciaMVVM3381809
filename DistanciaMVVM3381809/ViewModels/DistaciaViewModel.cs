using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DistanciaMVVM3381809.ViewModels
{
    public class DistaciaViewModel : INotifyPropertyChanged
    {

        public class Modelo
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        public class CalcularDistancia
        {
            public static double CalcularD(Modelo p1, Modelo p2)
            {
                return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            }

        }

        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;
        private double _distancia;

        public double X1
        {
            get => _x1;
            set
            {
                _x1 = value;
                OnPropertyChanged();
                CalcularD();
            }
        }

        public double Y1
        {
            get => _y1;
            set
            {
                _y1 = value;
                OnPropertyChanged();
                CalcularD();
            }
        }

        public double X2
        {
            get => _x2;
            set
            {
                _x2 = value;
                OnPropertyChanged();
                CalcularD();
            }
        }

        public double Y2
        {
            get => _y2;
            set
            {
                _y2 = value;
                OnPropertyChanged();
                CalcularD();
            }
        }

        public double Distancia
        {
            get => _distancia;
            private set
            {
                _distancia = value;
                OnPropertyChanged();
            }
        }

        private void CalcularD()
        {
            var p1 = new Modelo { X = X1, Y = Y1 };
            var p2 = new Modelo { X = X2, Y = Y2 };
            Distancia = CalcularDistancia.CalcularD(p1, p2);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
