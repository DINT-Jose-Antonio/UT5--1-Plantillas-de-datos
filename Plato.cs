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
        public class Plato : INotifyPropertyChanged
        {

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; NotifyPropertyChanged("Nombre"); }
        }
             


        private string imagen;

        public string Imagen
        {

            get { return imagen; }
            set
            {
                imagen = value;
                this.NotifyPropertyChanged("Imagen");
            }
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set
            {
                this.tipo = value;
                this.NotifyPropertyChanged("Imagen");
            }
        }


        private bool gluten;

        public bool Gluten
        {

            get { return gluten; }
            set
            {
                this.gluten = value;
                this.NotifyPropertyChanged("Gluten");
            }
        }


        private bool soja;

        public bool Soja
            {
            get { return soja; }
            set
                {
                    this.soja = value;
                    this.NotifyPropertyChanged("Soja");
                }
            }

        private bool leche;

        public bool Leche
            {
            get { return leche; }
            set
                {
                    this.leche = value;
                    this.NotifyPropertyChanged("Leche");
                }
            }



        private bool sulfitos;

        public bool Sulfitos
            {
            get { return sulfitos; }
            set
                {
                    this.sulfitos = value;
                    this.NotifyPropertyChanged("Sulfitos");
                }
            }

            public Plato(
              string nombre,
              string imagen,
              string tipo,
              bool gluten,
              bool soja,
              bool leche,
              bool sulfitos)
            {
                this.Nombre = nombre;
                this.Imagen = imagen;
                this.Tipo = tipo;
                this.Gluten = gluten;
                this.Soja = soja;
                this.Leche = leche;
                this.Sulfitos = sulfitos;
            }

            public Plato()
            {
            }

            public static ObservableCollection<Plato> GetSamples(
              string rutaImagenes)
            {
                ObservableCollection<Plato> samples = new ObservableCollection<Plato>();
                samples.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, "burguer.jpg"), "Americana", true, false, true, true));
                samples.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, "dumplings.jpg"), "China", true, true, false, false));
                samples.Add(new Plato("Tacos", Path.Combine(rutaImagenes, "tacos.jpg"), "Mexicana", true, false, false, true));
                samples.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, "cerdoagridulce.jpg"), "China", true, true, false, true));
                samples.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, "hotdog.jpg"), "Americana", true, true, true, true));
                samples.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, "fajitas.jpg"), "Mexicana", true, false, false, true));
                return samples;
            }

            public event PropertyChangedEventHandler PropertyChanged;

            public void NotifyPropertyChanged(string propertyName)
            {
                PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
                if (propertyChanged == null)
                    return;
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
