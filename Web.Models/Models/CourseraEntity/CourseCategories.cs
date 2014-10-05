namespace Web.Models.CourseraEntity
{
    // Вспомогательная сущность для связи многие ко многим элементов Курсов и Категорий
    public class CourseCategories
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
    }
}