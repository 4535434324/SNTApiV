using System.ComponentModel.DataAnnotations;

namespace SNTApiV.Model
{
    public class Работники
    {
        [Key]
        public int IDРаботника {  get; set; }
        public string Фамилия_работника { get; set; }
        public string Имя_работника  { get; set; }
        public string Отчество_работника { get; set; }
        public string Серия_номер_паспорта_работника { get; set; }
        public int IdДолжность { get; set; }
        public string Смен_в_неделю { get; set; }
        public string Пароль { get; set; }
    }
}
