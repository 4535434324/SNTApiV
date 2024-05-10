using System.ComponentModel.DataAnnotations;

namespace SNTApiV.Model
{
    public class Должность
    {
        [Key]

        public int IDДолжность { get; set; }
        public string Наименование_должности { get; set; }
        public string Зараплатная_плата {  get; set; }
    }
}
