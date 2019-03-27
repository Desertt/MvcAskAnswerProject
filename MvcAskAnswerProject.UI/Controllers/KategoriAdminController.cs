using MvcAskAnswerProject.Business;
using MvcAskAnswerProject.Entities;
using System.Web.Mvc;

namespace MvcAskAnswerProject.UI.Controllers
{
    public class KategoriAdminController : Controller
    {
        private YonetimKategori yonetimKategori = new YonetimKategori();
        // GET: KategoriAdmin
        public ActionResult Index()
        {
            //return View(db.Kategoris.ToList());
            return View(yonetimKategori.List());
        }


        // GET: KategoriAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                yonetimKategori.Insert(kategori);
                return RedirectToAction("Index");
            }

            return View(kategori);
          
        }

        // GET: KategoriAdmin/Edit/5
        public ActionResult Edit(int? id)
        {
            /*if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kategori kategori = db.Kategoris.Find(id);
            if (kategori == null)
            {
                return HttpNotFound();
            }
            return View(kategori);*/
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Kategori kategori)
        {
            /*if (ModelState.IsValid)
            {
                db.Entry(kategori).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kategori);*/
            return View();
        }

        // GET: KategoriAdmin/Delete/5
        public ActionResult Delete(int? id)
        {
            /*if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kategori kategori = db.Kategoris.Find(id);
            if (kategori == null)
            {
                return HttpNotFound();
            }
            return View(kategori);*/
            return View();
        }

    }
}
