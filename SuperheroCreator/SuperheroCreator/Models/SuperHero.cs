using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperheroCreator.Models
{
    public class SuperHero
    {
        [Key]

        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Superhero Name")]
        public  string superheroName { get; set; }

        [DisplayName("First Name")]
        public string firstName { get; set; }

        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [DisplayName("Primary Ability")]
        public string primaryAbility { get; set; }

        [DisplayName("Secondary Ability")]
        public string secondaryAbility { get; set; }

        [DisplayName("Catchphrase")]
        public string catchPhrase { get; set; }
    }
}