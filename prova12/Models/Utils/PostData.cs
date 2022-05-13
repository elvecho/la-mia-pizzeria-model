
namespace laMiaPizzeria.Models.Utils
{
    public static class PostData
    {
        public static List<Post> posts;

       
        public static List<Post> GetPosts()
        {
            if (PostData.posts != null)
            {
                return PostData.posts;
            }

            List<Post> nuovalistaposts = new List<Post>();

            for (int i = 0; i < 5; i++)
            {
                Post post = new Post(i, "pizza" + i, "ciao", "image");
                nuovalistaposts.Add(post);

            }
            PostData.posts = nuovalistaposts;

            return PostData.posts;

        }

    }
}
