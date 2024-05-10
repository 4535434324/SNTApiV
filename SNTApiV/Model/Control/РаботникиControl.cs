using Microsoft.AspNetCore.Mvc;
using SNTApiV.App;

namespace SNTApiV.Model.Control
{
    [ApiController]
    [Route("/v1/Workers")]
    public class РаботникиControl : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Работникиs.ToList();
            return Ok(list);
        }

        [HttpGet("{IDРаботника}")]
        public IActionResult GetById(int IDРаботника)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Работникиs.FirstOrDefault(x => x.IDРаботника == IDРаботника);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(Работники работники)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Работникиs.Add(работники).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(Работники работники)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Работникиs.Update(работники).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{IDРаботникаDell}")]
        public IActionResult Delete(int IDРаботникаDell)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Работникиs.FirstOrDefault(x => x.IDРаботника == IDРаботникаDell);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Работникиs.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
