using Microsoft.AspNetCore.Mvc;
using SNTApiV.App;
using System.Data.Entity;

namespace SNTApiV.Model.Control
{
    [ApiController]
    [Route("/v1/users")]
    public class пользователиControl : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Пользователиs
                .Include(u => u.Rроль).ToList();
            return Ok(list);
        }

        [HttpPost("/login")]
        public IActionResult Login(LoginApp loginApp)
        {
            using ApplicationContext _context = new ApplicationContext();
            пользователи? пользователь = _context.Пользователиs.Include(u => u.Rроль).FirstOrDefault(x => x.Login.ToLower() == loginApp.Login.ToLower());
            if (пользователь == null)
            {
                return BadRequest();
            }
            if (пользователь.Password != loginApp.Password)
            {
                return BadRequest();
            }
            return Ok(пользователь);
        }

        [HttpGet("{IDПользователи}")]
        public IActionResult GetById(int IDПользователи)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Пользователиs.Include(u => u.IDРольПользователя).FirstOrDefault(x => x.IDПользователи == IDПользователи);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(пользователи taskEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Пользователиs.Add(taskEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(пользователи taskEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Пользователиs.Update(taskEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{IDПользователиDell}")]
        public IActionResult Delete(int IDПользователиDell)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Пользователиs.FirstOrDefault(x => x.IDПользователи == IDПользователиDell);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Пользователиs.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
