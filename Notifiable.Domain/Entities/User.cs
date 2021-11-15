using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notifiable.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] PasswordHash { get; set; }

        [NotMapped]
        public string ProvidedPassword { get; set; }

        public bool Active { get; set; }

    }
}
