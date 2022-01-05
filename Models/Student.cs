namespace WorkManager.Models
{
    public class Student
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Duration { get; set; }
        public double PricePerMinute => Price / Duration;

        public override string ToString()
        {
            return $"Ученик {Name}, ставка {Price}/{Duration} мин. ({PricePerMinute} за минуту)";
        }
    }
}
