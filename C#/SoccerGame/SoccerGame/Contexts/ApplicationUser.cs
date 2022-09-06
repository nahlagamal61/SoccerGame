namespace SoccerGame.Contexts
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationUser  : IdentityUser
    {
        public string FullName { get; set; }
    }
    
}
