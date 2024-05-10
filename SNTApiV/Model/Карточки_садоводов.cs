using System.ComponentModel.DataAnnotations;

namespace SNTApiV.Model
{
    public class Карточки_садоводов
    {
        [Key]
        public int IDКарточки_Садовода {  get; set; }
        public string Номер_садовода { get; set; }
        public string Фамилия_садовода { get; set; }
        public string Имя_содовода { get; set; }
        public string Отчество_садовода { get; set; }
        public string Серия_номер_паспорта_садовода { get; set; }
        public int Код_Улица_участка_садовода { get; set; }
        public string Номер_участка_садовода { get; set; }
        public int Код_Сотак_участка_садовода { get; set; }
        public string Книжка_выдана {  get; set; }
        public string Дата_рождения { get; set; }
        public string Кадастровый_номер {  get; set; }
        public string ЕГРПНомер { get; set; }
        public string Год_принятия_в_товарищество { get; set; }
        public string Номер_телефона_садовода { get; set; }
    }
}
