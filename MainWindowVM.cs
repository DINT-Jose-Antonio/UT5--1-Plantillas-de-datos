using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

namespace UT5__1_Plantillas_de_datos
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<string> tiposComida;
        private ObservableCollection<Plato> listaPlatos;
        private Plato platoSeleccionado;

        public ObservableCollection<string> TiposComida
        {
            get => this.tiposComida;
            set
            {
                this.tiposComida = value;
                this.NotifyPropertyChanged("TiposComida");
            }
        }

        public ObservableCollection<Plato> ListaPlatos
        {
            get => this.listaPlatos;
            set
            {
                this.listaPlatos = value;
                this.NotifyPropertyChanged("ListaPlatos");
            }
        }

        public Plato PlatoSeleccionado
        {
            get => this.platoSeleccionado;
            set
            {
                this.platoSeleccionado = value;
                this.NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

        public MainWindowVM()
        {
            this.ListaPlatos = Plato.GetSamples(@"F:\DAM\Desarrollo de interfaces\UT5 -1-Plantillas de datos\assets");
            ObservableCollection<string> observableCollection = new ObservableCollection<string>();
            observableCollection.Add("China");
            observableCollection.Add("Americana");
            observableCollection.Add("Mexicana");
            this.TiposComida = observableCollection;
        }

        public void QuitarSeleccionado() => PlatoSeleccionado = null;

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
