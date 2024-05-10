using LinqToDB;
using Microsoft.AspNetCore.Mvc;
using SNTApiV.App;

namespace SNTApiV.Model.Control
{
    [ApiController]
    [Route("/v1/Contributions_rate")]
    public class Взносы_тарифControl : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Взносы_Тарифs.ToList();
            return Ok(list);
        }

        [HttpGet("{ID_взноса}")]
        public IActionResult GetById(int ID_взноса)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Взносы_Тарифs.FirstOrDefault(x => x.ID_взноса == ID_взноса);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(взносы_тариф Взносы_тариф)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Взносы_Тарифs.Add(Взносы_тариф).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(взносы_тариф Взносы_тариф)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Взносы_Тарифs.Update(Взносы_тариф).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{ID_взносаDell}")]
        public IActionResult Delete(int ID_взносаDell)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Взносы_Тарифs.FirstOrDefault(x => x.ID_взноса == ID_взносаDell);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Взносы_Тарифs.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
