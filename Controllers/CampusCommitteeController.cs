using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GECPATAN_FACULTY_PORTAL.Models;

namespace GECPATAN_FACULTY_PORTAL.Controllers
{
    public class CampusCommitteeController : Controller
    {
        private readonly FacultyPortalContext _context;

        public CampusCommitteeController(FacultyPortalContext context)
        {
            _context = context;
        }

        // GET: CampusCommittee
        public async Task<IActionResult> Index()
        {
            return View(await _context.CampusCommittee.ToListAsync());
        }

        // GET: CampusCommittee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campusCommittee = await _context.CampusCommittee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campusCommittee == null)
            {
                return NotFound();
            }

            return View(campusCommittee);
        }

        // GET: CampusCommittee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CampusCommittee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,TitleImage,About,Measures,MeasureImage,SubObjImg,BulletPointsImg,PageFlyer,Tagline,BlogLink,Link,ShowDocument,TableView,IsDeleted,CreatedDate,CreatedDateInt,UpdatedDate,UpdatedDateInt")] CampusCommittee campusCommittee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campusCommittee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(campusCommittee);
        }

        // GET: CampusCommittee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campusCommittee = await _context.CampusCommittee.FindAsync(id);
            if (campusCommittee == null)
            {
                return NotFound();
            }
            return View(campusCommittee);
        }

        // POST: CampusCommittee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,TitleImage,About,Measures,MeasureImage,SubObjImg,BulletPointsImg,PageFlyer,Tagline,BlogLink,Link,ShowDocument,TableView,IsDeleted,CreatedDate,CreatedDateInt,UpdatedDate,UpdatedDateInt")] CampusCommittee campusCommittee)
        {
            if (id != campusCommittee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campusCommittee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampusCommitteeExists(campusCommittee.Id))
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
            return View(campusCommittee);
        }

        // GET: CampusCommittee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campusCommittee = await _context.CampusCommittee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campusCommittee == null)
            {
                return NotFound();
            }

            return View(campusCommittee);
        }

        // POST: CampusCommittee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campusCommittee = await _context.CampusCommittee.FindAsync(id);
            if (campusCommittee != null)
            {
                _context.CampusCommittee.Remove(campusCommittee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampusCommitteeExists(int id)
        {
            return _context.CampusCommittee.Any(e => e.Id == id);
        }
    }
}
