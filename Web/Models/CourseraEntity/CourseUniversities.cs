namespace Web.Models.CourseraEntity
{
    // Вспомогательная сущность для связи многие ко многим элементов Курсов и Университетов
    public class CourseUniversities
    {
        public int CourseId { get; set; }
        public int UniversityId { get; set; }
    }
}