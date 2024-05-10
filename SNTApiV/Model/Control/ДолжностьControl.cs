using Microsoft.AspNetCore.Mvc;
using SNTApiV.App;

namespace SNTApiV.Model.Control
{
    [ApiController]
    [Route("/v1/post")]
    public class ДолжностьControl : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Должностьs.ToList();
            return Ok(list);
        }

        [HttpGet("{IDДолжность}")]
        public IActionResult GetById(int IDДолжность)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Должностьs.FirstOrDefault(x => x.IDДолжность == IDДолжность);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(Должность должность)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Должностьs.Add(должность).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(Должность должность)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Должностьs.Update(должность).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{IDДолжностьDell}")]
        public IActionResult Delete(int IDДолжностьDell)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Должностьs.FirstOrDefault(x => x.IDДолжность == IDДолжностьDell);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Должностьs.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    
    }
}
