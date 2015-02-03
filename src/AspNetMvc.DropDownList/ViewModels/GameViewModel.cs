using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AspNetMvc.DropDownList
{
    public class GameViewModel
    {
        [Required(ErrorMessage = "You have to enter a name for player one.")]
        [DisplayName("Player one:")]
        public string PlayerOne { get; set; }

        [Required(ErrorMessage = "You have to enter a name for player two.")]
        [DisplayName("Player two:")]
        public string PlayerTwo { get; set; }

        [Required(ErrorMessage = "You have to specify the number of rounds.")]
        [Range(1, 7, ErrorMessage = "The number of rounds you specified is invalid. Minimum is 1, maximum is 7.")]
        [DisplayName("Rounds:")]
        public int Rounds { get; set; }

        public string Ruleset { get; set; }

        public IEnumerable<SelectListItem> Rulesets
        {
            get
            {
                return new SelectListItem[]
                {
                    new SelectListItem
                    {
                        Text = "Classic",
                        Value = "classic"
                    },

                    new SelectListItem
                    {
                        Text = "Modern",
                        Value = "modern"
                    },

                    new SelectListItem
                    {
                        Text = "None",
                        Value = "anarchy"
                    }
                };
            }
        }
    }
}