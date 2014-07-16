using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json;
using Testing.CourseraEntity;
using UOfW = Testing.UnitOfWork;

namespace Testing.Helpful
{
    public class ConvertToCategory : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var categoryIds = (ICollection<int>)serializer.Deserialize(reader, typeof(ICollection<int>));
            var result = new Collection<Category>();
            var uow = new UOfW.UnitOfWork();
            foreach (var categoryId in categoryIds)
            {
                var item = uow.CategoryRepository.Get(x => x.CategoryIdFromApi == categoryId).FirstOrDefault();
                result.Add(item);
            }
            return result;
        }

        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }
}