using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CloneMasterDetail.Models;
using CloneMasterDetail.Services;
using Xamarin.Forms;

namespace CloneMasterDetail.ViewModels
{
    public class BaseViewModel
    {

        public IDataStore<Item> DataStore =>
            DependencyService.Get<IDataStore<Item>>() ?? new MockDataStore();

        private bool _isBusy;

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        private string _title = string.Empty;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChnage = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChnage?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangingEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            changed?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }
        #endregion
    }
}
