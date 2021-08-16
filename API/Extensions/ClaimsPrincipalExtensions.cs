using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
         public static string RetrieveEmailFromPrincipal(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.Email);
        }

        public static int RetrieveUserIdFromPrincipal(this ClaimsPrincipal user)
        {
            var userid = user.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.Parse(userid);
        }
    }
}