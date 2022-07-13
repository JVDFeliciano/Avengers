using Avengers.Infra.Data;

namespace Avengers.Endpoints.Users
{
    public class InfoUserPost
    {
        public static string Template => "/infousers";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;

        public IResult Action(InfoUserRequest, ApplicationDbContext context)
        {
            var infoUser = new InfoUser
            {
                Name = InfoUserRequest.Name,
            }
            return Results.Ok("Aoopa");
        }
    }
}
