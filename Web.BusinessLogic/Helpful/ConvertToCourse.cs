using Web.DataAccess.Repository;
using Web.Models.CourseraEntity;

namespace Web.Helpful
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Newtonsoft.Json;    

    // Конвертер необходим при связаывании Courses with Category, Instructors, Universities, Sessions
    // Сущности имеют связь многие ко многим
    public class ConvertToCourse : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            // При получении JSON c Coursera Api мы имеем Id курсов
            var courseIds = (ICollection<int>)serializer.Deserialize(reader, typeof(ICollection<int>));

            // Формируем список курсов
            var result = new Collection<Course>();
            using (var uow = new UnitOfWork())
            {
                // Для каждого id из JSON находим соотв.курс из нашего репозитория и записываем его в результирующий список
                foreach (var courseId in courseIds)
                {
                    var item = uow.Repository<Course>().Get(x => x.CourseIdFromApi == courseId).FirstOrDefault();
                    if (item != null)
                    {
                        result.Add(item);
                    }
                }
            }

            // Результирующий список курсов используется при добавлении в каждый объект Instructors, Sessions, Universities, Categories
            return result;
        }

        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }
}