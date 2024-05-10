using Microsoft.AspNetCore.Mvc;
using SNTApiV.App;

namespace SNTApiV.Model.Control
{
    [ApiController]
    [Route("/v1/Invoice_Type")]
    public class Тип_взносаControler : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Тип_Взносаs.ToList();
            return Ok(list);
        }

        [HttpGet("{IDВзнос_тип}")]
        public IActionResult GetById(int IDВзнос_тип)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Тип_Взносаs.FirstOrDefault(x => x.IDВзнос_тип == IDВзнос_тип);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(Тип_взноса тип_Взноса)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Тип_Взносаs.Add(тип_Взноса).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(Тип_взноса тип_Взноса)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Тип_Взносаs.Update(тип_Взноса).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{IDВзнос_типDell}")]
        public IActionResult Delete(int ID_взносаDell)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Тип_Взносаs.FirstOrDefault(x => x.IDВзнос_тип == ID_взносаDell);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Тип_Взносаs.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
