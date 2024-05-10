using Microsoft.AspNetCore.Mvc;
using SNTApiV.App;

namespace SNTApiV.Model.Control
{
    [ApiController]
    [Route("/v1/role")]
    public class РольControl : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Рольs.ToList();
            return Ok(list);
        }

        [HttpGet("{IDРоль}")]
        public IActionResult GetById(int IDРоль)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Рольs.FirstOrDefault(x => x.IDРоль == IDРоль);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(Роль роль)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Рольs.Add(роль).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(Роль роль)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Рольs.Update(роль).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{IDРольDell}")]
        public IActionResult Delete(int IDРольDell)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Рольs.FirstOrDefault(x => x.IDРоль == IDРольDell);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Рольs.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
