using System.ComponentModel.DataAnnotations;

namespace SNTApiV.Model
{
    public class Сотки
    {
        [Key]
        public int IDСотки { get; set; }
        public string Количество_соток {  get; set; }
    }
}
