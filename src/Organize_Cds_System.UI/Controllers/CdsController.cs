using Microsoft.AspNetCore.Mvc;
using Organize_Cds_System.Application.Interfaces.Products.Cds;
using Organize_Cds_System.Entity.Entities.Products.Cds;
using System.Linq;
using System.Threading.Tasks;

namespace Organize_Cds_System.UI.Controllers
{
    public class CdsController : Controller
    {
        private readonly ICdApp _cdApp;

        public CdsController(ICdApp cdApp)
        {
            _cdApp = cdApp;

        }
        // GET: CdsController
        public async Task<IActionResult> Index()
        {
            return View(await _cdApp.List());
        }

        // GET: CdsController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            return View(await _cdApp.GetEntityById(id));
        }

        // GET: CdsController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: CdsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cd cd)
        {
            try
            {
                await _cdApp.AddCd(cd);
                if (cd.Notifications.Any())
                {
                    foreach (var item in cd.Notifications)
                    {
                        ModelState.AddModelError(item.PropertyName, item.Message);
                    }
                    return View("Edit", cd);
                }
            }
            catch
            {
                return View("Edit", cd);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: CdsController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _cdApp.GetEntityById(id));
        }

        // POST: CdsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Cd cd)
        {
            try
            {
                await _cdApp.UpdateCd(cd);
                if (cd.Notifications.Any())
                {
                    foreach (var item in cd.Notifications)
                    {
                        ModelState.AddModelError(item.PropertyName, item.Message);
                    }
                    return View("Edit", cd);
                }
            }
            catch
            {
                return View("Edit", cd);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: CdsController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _cdApp.GetEntityById(id));
        }

        // POST: CdsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Cd cd)
        {
            try
            {
                var deleteProduct = await _cdApp.GetEntityById(id);
                await _cdApp.Delete(deleteProduct);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
