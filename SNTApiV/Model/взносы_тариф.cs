using System.ComponentModel.DataAnnotations;

namespace SNTApiV.Model
{
    public class взносы_тариф
    {
        [Key]
        public int ID_взноса {  get; set; }
        public string Наменование_взноса {  get; set; }
        public int ID_тип_взноса { get; set; }
        public string Цена_взноса {  get; set; }
    }
}
