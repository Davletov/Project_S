namespace Web.Models.CourseraEntity
{
    // Вспомогательная сущность для связи многие ко многим элементов Курсов и Инструкторов
    public class CourseInstructors
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
    }
}