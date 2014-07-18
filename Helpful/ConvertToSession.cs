using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json;
using Testing.CourseraEntity;
using UOfW = Testing.UnitOfWork;

namespace Testing.Helpful
{
    // Избаваиться от дублирования кода (Сделать базовый конвертер)
    public class ConvertToSession : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var sessionIds = (ICollection<int>)serializer.Deserialize(reader, typeof(ICollection<int>));
            var result = new Collection<Session>();
            var uow = new UOfW.UnitOfWork();
            foreach (var sessionId in sessionIds)
            {
                var item = uow.SessionRepository.Get(x => x.SessionIdFromApi == sessionId).FirstOrDefault();
                if (item != null)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }
}