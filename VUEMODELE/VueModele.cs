using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GSB___JLAME.MODELE_VUE
{
    public abstract class VueModele : INotifyPropertyChanged
    {
        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
