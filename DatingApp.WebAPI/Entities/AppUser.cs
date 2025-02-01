using System.ComponentModel.DataAnnotations;

namespace DatingApp.WebAPI.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public required string UserName { get; set; } 
    } 
}
