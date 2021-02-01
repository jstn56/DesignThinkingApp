using DesignThinking.Models;
using System;
namespace DesignThinking.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        private User model;

        public UserViewModel(User model)
        {
            this.model = model;
        }

        public User Model { get=> model; set => model = value; }

        public bool IsSelected { get; set; }
    }
}
