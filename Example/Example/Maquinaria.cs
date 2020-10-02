using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public class Maquinaria:Base
    {
        public Maquinaria() {
            var aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private void OnTimedEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            var hour = DateTime.Now;
            Hora = hour.Hour;
            Minuto = hour.Minute;
            Segundo = hour.Second;
        }
        private int _hora;
        public int Hora
        {
            get { return _hora; }
            set { _hora = value;
                OnPropertyChanged();
            }
        }
        private int _minuto;
        public int Minuto
        {
            get { return _minuto; }
            set { _minuto = value;
                OnPropertyChanged();
            }
        }
        private int _segundo;
        public int Segundo
        {
            get { return _segundo; }
            set { _segundo = value;
                OnPropertyChanged();
            }
        }
    }
}
