using System.ComponentModel.DataAnnotations;

namespace SNTApiV.Model
{
    public class Тип_взноса
    {
        [Key]
        public int IDВзнос_тип { get; set; }
        public string Наименование_тип_взноса { get; set; }
    }
}
