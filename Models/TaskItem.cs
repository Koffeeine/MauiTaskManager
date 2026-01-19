using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTask.Models
{
    public partial class TaskItem : ObservableObject
    {
        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private bool isCompleted;
    }
}
