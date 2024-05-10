using System.ComponentModel.DataAnnotations;

namespace SNTApiV.Model
{
    public class Оплата_взносов
    {
        [Key]
        public int ID_Оплата_Взноса {  get; set; }
        public int ID_Koд_садовода {  get; set; }
        public int ID_Код_взноса {  get; set; }
        public string Состояние_оплаты {  get; set; }
        public string К_оплате {  get; set; }
        public string Дата_и_время_оплаты {  get; set; }
    }
}
