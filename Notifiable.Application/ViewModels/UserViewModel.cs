using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using FluentValidator;
using FluentValidator.Validation;

namespace Notifiable.Application.ViewModels
{
    public class UserViewModel : FluentValidator.Notifiable
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public string ProvidedPassword { get; set; }

        public bool Active { get; set; }

        public IEnumerable<Notification> Validate()
        {
            AddNotifications(new ValidationContract()
                .IsNotNullOrEmpty(Name, "Name", "Por favor, informe o nome")
                .IsEmail(Email, "Email", "Por favor, insira um email válido")
                .IsGreaterThan(BirthDate.Year, 2000, "BirthDate", "Por favor, insira uma data de nascimento")
                .IsNotNullOrEmpty(ProvidedPassword, "Password", "Por favor, informe uma senha")
            );

            return Notifications;
        }
    }

}
