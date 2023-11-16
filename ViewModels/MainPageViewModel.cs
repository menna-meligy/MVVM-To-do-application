using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Template10.Mvvm;
using TodoXaml.Models;
using TodoXaml.Services;
using TodoXaml.Views;
using Windows.UI.Xaml.Navigation;

namespace TodoXaml.ViewModels
{
    internal class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<TodoItem> Todos { get; set; }
        public ICommand AddCommand { get; }
        public MainPageViewModel() { 
         AddCommand = new DelegateCommand(executeAddCommand);
        }

    private void executeAddCommand() {
            NavigationService.Navigate(typeof(MainPageViewModel));
    }

        /*private DataType mydata;
        public DataType Mydata { 
            get=> mydata;

            set { 
            mydata = value;
                RaisePropertyChanged(nameof(Mydata));
            } }*/



        /* public static ObservableCollection<TodoItem> Todos { get; set; } = new ObservableCollection<TodoItem>()
         {
             new TodoItem()
             {
                 Id = 1,
              Title = "Buy milk",
              Description = "If it’s egg, then buy 10! ",
              Priority = Priority.Normal,
              IsDone = true,
              Deadline = DateTimeOffset.Now + TimeSpan.FromDays(1)
              },
              new TodoItem()
              {
              Id = 2,
              Title = "Write the dissertaion",
              Description = "At least 40 pages, with many nice screenshots",
              Priority = Priority.High,
              IsDone = false,
              Deadline = new DateTime(2017, 12, 08, 12, 00, 00, 00)
             }
         };*/

        public override async Task OnNavigatedToAsync(
 object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            var todos = await new TodoService().GetTodosAsync();
            Todos = new ObservableCollection<TodoItem>(todos);
            RaisePropertyChanged(nameof(Todos));
            await base.OnNavigatedToAsync(parameter, mode, state);
        }

        public void NavigateToDetailPage(int id)
        {
            NavigationService.Navigate(typeof(TodoDetailsPage), id);
        }
    }
    }
