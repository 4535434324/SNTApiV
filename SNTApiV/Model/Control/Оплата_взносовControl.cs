using Microsoft.AspNetCore.Mvc;
using SNTApiV.App;

namespace SNTApiV.Model.Control
{
    [ApiController]
    [Route("/v1/Paymentofbills")]
    public class Оплата_взносовControl : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Оплата_Взносовs.ToList();
            return Ok(list);
        }

        [HttpGet("{ID_Оплата_Взноса}")]
        public IActionResult GetById(int ID_Оплата_Взноса)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Оплата_Взносовs.FirstOrDefault(x => x.ID_Оплата_Взноса == ID_Оплата_Взноса);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(Оплата_взносов оплата_Взносов)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Оплата_Взносовs.Add(оплата_Взносов).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(Оплата_взносов оплата_Взносов)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Оплата_Взносовs.Update(оплата_Взносов).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{ID_Оплата_ВзносаDell}")]
        public IActionResult Delete(int ID_Оплата_ВзносаDell)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Оплата_Взносовs.FirstOrDefault(x => x.ID_Оплата_Взноса == ID_Оплата_ВзносаDell);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Оплата_Взносовs.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
