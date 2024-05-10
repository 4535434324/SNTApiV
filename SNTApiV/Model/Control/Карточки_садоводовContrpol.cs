using Microsoft.AspNetCore.Mvc;
using SNTApiV.App;

namespace SNTApiV.Model.Control
{
    [ApiController]
    [Route("/v1/gardeningcards")]
    public class Карточки_садоводовContrpol : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Карточки_Садоводовs.ToList();
            return Ok(list);
        }

        [HttpGet("{IDКарточки_Садовода}")]
        public IActionResult GetById(int IDКарточки_Садовода)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Карточки_Садоводовs.FirstOrDefault(x => x.IDКарточки_Садовода == IDКарточки_Садовода);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(Карточки_садоводов карточки_Садоводов)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Карточки_Садоводовs.Add(карточки_Садоводов).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(Карточки_садоводов карточки_Садоводов)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.Карточки_Садоводовs.Update(карточки_Садоводов).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{IDКарточки_СадоводаDell}")]
        public IActionResult Delete(int IDКарточки_СадоводаDell)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.Карточки_Садоводовs.FirstOrDefault(x => x.IDКарточки_Садовода == IDКарточки_СадоводаDell);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.Карточки_Садоводовs.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
