using System.ComponentModel.DataAnnotations;

namespace Web.Enum
{
    /// <summary>
    /// Социальный статус пользователя
    /// </summary>
    public enum UserSocialStatus
    {
        // Школьник начальных классов
        [Display(Name = "Pupil of Elementary School")]
        PupilElementarySchool = 10,

        // Школьник средней школы
        [Display(Name = "Pupil of Middle School")]
        PupilMiddleSchool = 20,

        // Школьник старшей школы
        [Display(Name = "Pupil of High School")]
        PupilHighSchool = 30,

        // Студент ВУЗа (колледжа)
        [Display(Name = "College student")]
        StudentColledge = 40,

        // Аспирант, магистр
        [Display(Name = "Postgraduate")]
        Postgraduate = 50,

        // Преподаватель, профессор
        [Display(Name = "Teacher or professor")]
        Teacher = 60,

        // Человек с высшим образованием
        [Display(Name = "Person with Higher Education")]
        PersonWithHigherEducation = 70,

        // Человек со средним образованием
        [Display(Name = "Person With Secondary Education")]
        PersonWithSecondaryEducation = 80,

        // Я не хочу указывать свой соц.статус
        [Display(Name = "Other category")]
        Other = 90
    }
}