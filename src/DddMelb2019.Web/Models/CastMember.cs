using System;
using System.ComponentModel.DataAnnotations;

namespace DddMelb2019.Web.Models
{
    public class CastMember
    {
        [Key]
        public int CastMemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string ImdbUrl { get; set; }
    }
}