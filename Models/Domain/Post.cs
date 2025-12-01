namespace Blog.Models.Domain
{
    public class Post
    {
        public Guid Id { get; set; }    // Уникальный идентификатор поста

        public string Name { get; set; }   // Заголовок поста

        public string Description { get; set; }   // Краткое описание поста

        public string Author { get; set; }   // Автор поста 

        public DateTime Created { get; set; }   // Дата и время создания поста

        public DateTime LastUpdated { get; set; }   // Дата и время последнего обновления поста

        public bool IsVisible { get; set; }   // Флаг видимости поста
    }

}
