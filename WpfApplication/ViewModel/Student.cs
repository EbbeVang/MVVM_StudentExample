using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.Annotations;

namespace WpfApplication.ViewModel
{
    class Student : INotifyPropertyChanged
    {
        private Model.Student _currentStudent;

        private List<Model.Student> _studentList 

        public Model.Student CurrentCurrentStudent {
            get { return _currentStudent; }
            set
            {
                _currentStudent = value;
                // tell MVVM that CurrentCurrentStudent property changed...
                OnPropertyChanged("CurrentCurrentStudent");
            }
        }

        //always use obeservable collection when collection is needed
        public ObservableCollection<Model.Student> StudentList { get; set; }

        #region Implementation of inotify.. interface
        public event PropertyChangedEventHandler PropertyChanged;
        
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
