using System.ComponentModel.DataAnnotations;

namespace SNTApiV.Model
{
    public class Улицы
    {
        [Key]
        public int IDУлица { get; set; }
        public string Намиенование_улицы_СНТ {  get; set; }
    }
}
