using Blog.Models.Domain;

namespace Blog
{
    public static class SD
    {
        public static List<Post> posts = new(); // Список для хранения постов

        public static void AddPost(Post newPost)
        {
            posts.Add(newPost);
        }
    }
}
