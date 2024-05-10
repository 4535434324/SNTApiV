using Microsoft.AspNetCore.Mvc;
using SNTApiV.App;

namespace SNTApiV.Model.Control
{
    [ApiController]
    [Route("/v1/streets")]
    public class УлицыControl : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Улицыs.ToList();
            return Ok(list);
        }

        [HttpGet("{IDУлица}")]
        public IActionResult GetById(int IDУлица)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Улицыs.FirstOrDefault(x => x.IDУлица == IDУлица);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(Улицы улицы)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Улицыs.Add(улицы).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(Улицы улицы)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Улицыs.Update(улицы).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{IDУлицаDell}")]
        public IActionResult Delete(int IDУлицаDell)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Улицыs.FirstOrDefault(x => x.IDУлица == IDУлицаDell);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Улицыs.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
