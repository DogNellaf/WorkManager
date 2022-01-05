using Google.Apis.Calendar.v3.Data;
using System;

namespace WorkManager.Models
{
    public class Lesson
    {
        public Student Student { get; private set; }
        public DateTime Date { get; private set; }
        public readonly Event BaseEvent;
        public Lesson(Event based)
        {
            BaseEvent = based;
            Date = based.Start.DateTime.Value;

            //TODO: Сослаться на парсера XML
            //Найти по данным студента
        }
    }
}
