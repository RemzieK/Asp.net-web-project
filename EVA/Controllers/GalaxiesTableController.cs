using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EVA.Models.GalaxyTable;

namespace EVA.Controllers
{
    public class GalaxiesTableController : Controller
    {
        private readonly GalaxyDbContext _galaxyDbContext;

        public GalaxiesTableController(GalaxyDbContext galaxyDbContext)
        {
            _galaxyDbContext = galaxyDbContext;
        }

        // GET: Galaxies
        public async Task<IActionResult> GalaxiesTableView()
        {
            var galaxies = await _galaxyDbContext.Galaxies.ToListAsync();
            return View(galaxies);
        }

        // GET: Galaxies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galaxy = await _galaxyDbContext.Galaxies.FirstOrDefaultAsync(m => m.Id == id);
            if (galaxy == null)
            {
                return NotFound();
            }

            return View(galaxy);
        }

        // GET: Galaxies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Galaxies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Location,Description,Shape")] GalaxiesTableModel galaxy)
        {
            if (ModelState.IsValid)
            {
                _galaxyDbContext.Galaxies.Add(galaxy);
                await _galaxyDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(GalaxiesTableView));
            }
            return View(galaxy);
        }

        // GET: Galaxies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galaxy = await _galaxyDbContext.Galaxies.FindAsync(id);
            if (galaxy == null)
            {
                return NotFound();
            }

            return View(galaxy);
        }

        // POST: Galaxies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Location,Description,Shape")] GalaxiesTableModel galaxy)
        {
            if (id != galaxy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _galaxyDbContext.Update(galaxy);
                    await _galaxyDbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GalaxyExists(galaxy.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(galaxy);
        }

        // GET: Galaxies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galaxy = await _galaxyDbContext.Galaxies.FirstOrDefaultAsync(m => m.Id == id);
            if (galaxy == null)
            {
                return NotFound();
            }

            return View(galaxy);
        }

        // POST: Galaxies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var galaxy = await _galaxyDbContext.Galaxies.FindAsync(id);
            _galaxyDbContext.Galaxies.Remove(galaxy);
            await _galaxyDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(GalaxiesTableView));
        }

        private bool GalaxyExists(int id)
        {
            return _galaxyDbContext.Galaxies.Any(e => e.Id == id);
        }
    }
}
