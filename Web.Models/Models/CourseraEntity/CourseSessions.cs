namespace Web.Models.CourseraEntity
{
    // Вспомогательная сущность для связи многие ко многим элементов Курсов и Сессий
    public class CourseSessions
    {
        public int CourseId { get; set; }
        public int SessionId { get; set; }
    }
}