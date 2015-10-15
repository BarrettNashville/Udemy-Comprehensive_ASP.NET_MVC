using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NHibernate.Type;
using SimpleBlog.Models;

namespace SimpleBlog.Areas.Admin.ViewModels
{
    public class UsersIndex
    {
         public IEnumerable<User> Users {get; set; }

    }

    public class UsersNew
    {
        [Required, MaxLength(128)]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, MaxLength(256), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}