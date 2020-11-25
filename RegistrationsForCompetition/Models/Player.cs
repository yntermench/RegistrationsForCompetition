using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationsForCompetition.Models
{
    public class Player
    {
        [Required(ErrorMessage = "Вы не ввели логин.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Вы не ввели почту."),
         RegularExpression(".+\\@.+\\..+", ErrorMessage = "Вы ввели недействительную почту.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Вы не ввели пароль.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Вы не ввели свой уровень.")]
        public int? Level { get; set; }
        public int? CountPP { get; set; }
        [Required(ErrorMessage = "Вы не выбрали ничего из указанных вариантов.")]
        public bool? Multiplayer { get; set; }
    }
}
