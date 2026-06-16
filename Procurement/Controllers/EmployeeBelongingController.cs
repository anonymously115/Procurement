
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Procurement.Models;

public class EmployeeBelongingController : Controller
{
    private readonly ProcurementContext _context;

    public EmployeeBelongingController(ProcurementContext context)
    {
        _context = context;
    }

    // GET: EMPLOYEEBELONGINGS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.EmployeeBelonging.ToListAsync());
    }

    // GET: EMPLOYEEBELONGINGS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var employeebelonging = await _context.EmployeeBelonging
            .FirstOrDefaultAsync(m => m.Id == id);
        if (employeebelonging == null)
        {
            return NotFound();
        }

        return View(employeebelonging);
    }

    // GET: EMPLOYEEBELONGINGS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: EMPLOYEEBELONGINGS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,EmployeeCode,EmployeeFullName,EmployeeAffiliationOrganizationCode,EmployeeAffiliationOrganizationName,EmployeeAffiliationUpperOrganizationCode,EmployeeAffiliationUpperOrganizationName,EmployeeJobTitleCode,EmployeeHandJobTitle,ReportTargetEmployeeCode,ReportTargetEmployeeFullName")] EmployeeBelonging employeebelonging)
    {
        if (ModelState.IsValid)
        {
            _context.Add(employeebelonging);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(employeebelonging);
    }

    // GET: EMPLOYEEBELONGINGS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var employeebelonging = await _context.EmployeeBelonging.FindAsync(id);
        if (employeebelonging == null)
        {
            return NotFound();
        }
        return View(employeebelonging);
    }

    // POST: EMPLOYEEBELONGINGS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,EmployeeCode,EmployeeFullName,EmployeeAffiliationOrganizationCode,EmployeeAffiliationOrganizationName,EmployeeAffiliationUpperOrganizationCode,EmployeeAffiliationUpperOrganizationName,EmployeeJobTitleCode,EmployeeHandJobTitle,ReportTargetEmployeeCode,ReportTargetEmployeeFullName")] EmployeeBelonging employeebelonging)
    {
        if (id != employeebelonging.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(employeebelonging);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeBelongingExists(employeebelonging.Id))
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
        return View(employeebelonging);
    }

    // GET: EMPLOYEEBELONGINGS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var employeebelonging = await _context.EmployeeBelonging
            .FirstOrDefaultAsync(m => m.Id == id);
        if (employeebelonging == null)
        {
            return NotFound();
        }

        return View(employeebelonging);
    }

    // POST: EMPLOYEEBELONGINGS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var employeebelonging = await _context.EmployeeBelonging.FindAsync(id);
        if (employeebelonging != null)
        {
            _context.EmployeeBelonging.Remove(employeebelonging);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool EmployeeBelongingExists(int? id)
    {
        return _context.EmployeeBelonging.Any(e => e.Id == id);
    }
}
