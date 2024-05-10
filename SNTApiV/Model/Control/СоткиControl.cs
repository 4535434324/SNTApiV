using Microsoft.AspNetCore.Mvc;
using SNTApiV.App;

namespace SNTApiV.Model.Control
{
    [ApiController]
    [Route("/v1/weaving")]
    public class СоткиControl : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Соткиs.ToList();
            return Ok(list);
        }

        [HttpGet("{IDСотки}")]
        public IActionResult GetById(int IDСотки)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Соткиs.FirstOrDefault(x => x.IDСотки == IDСотки);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(Сотки сотки)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Соткиs.Add(сотки).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(Сотки сотки)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Соткиs.Update(сотки).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{IDСоткиDell}")]
        public IActionResult Delete(int IDСоткиDell)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Соткиs.FirstOrDefault(x => x.IDСотки == IDСоткиDell);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Соткиs.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
