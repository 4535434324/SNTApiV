using System.ComponentModel.DataAnnotations;
using System.Web.Providers.Entities;

namespace SNTApiV.Model
{
    public class пользователи
    {
        [Key]
        public int IDПользователи {  get; set; }
        public string Name { get; set; }

        public int IDРольПользователя { get; set; }

        public Роль Rроль { get; set; }

        public string Login { get; set; }
        public string Password {  get; set; }



    }
}
