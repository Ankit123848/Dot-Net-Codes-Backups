using Microsoft.AspNetCore.Mvc;
using MVCCORE_CodeFirst.Models;
using System.Linq;
using System.Net;



namespace MVCCORE_CodeFirst.Controllers
{
	public class DepartmentController : Controller
	{
		public DepartmentController(AppDbContext context)
		{
			_context = context;
		}
		public AppDbContext _context { get; }
		public IActionResult Index()
		{
			var data = _context.Departments.ToList();
			return View(data);
		}





		// GET:/Create
		public ActionResult Create()
		{
			return View();
		}





		// POST:/Create
		[HttpPost]
		public ActionResult Create(Department newdepartment)
		{
			try
			{
				// TODO: Add insert logic here
				_context.Departments.Add(newdepartment);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}



		[HttpGet]
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{ return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }







			else
			{
				var data = _context.Departments.FirstOrDefault(cust => cust.Id == id);
				return View(data);
			}







		}
		// POST: Edit/5
		[HttpPost]
		public ActionResult Edit(int? id, Department modifiedobj)
		{
			try
			{
				if (id == null)
				{
					return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
				}







				else
				{
					var data = _context.Departments.FirstOrDefault(cust => cust.Id == id);
					data.Name = modifiedobj.Name;
					_context.SaveChanges();
					return RedirectToAction("Index");
				}
			}
			catch
			{
				return View();
			}
		}



		//Get:Delete
		[HttpGet]
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
			}
			else
			{
				var data = _context.Departments.FirstOrDefault(cust => cust.Id == id);
				return View(data);
			}
		}







		// POST: Delete/5
		[HttpPost, ActionName("Delete")]
		public ActionResult Delete(int? id, Department modifiedobj)
		{
			{
				try
				{
					if (id == null)
					{
						return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
					}
					else
					{
						Department data = _context.Departments.Find(id);
						_context.Departments.Remove(data);
						_context.SaveChanges();
						return RedirectToAction("Index");
					}
				}
				catch
				{
					return View();
				}
			}
		}
		private class HttpStatusCodeResult : ActionResult
		{
			private HttpStatusCode badRequest;



			public HttpStatusCodeResult(HttpStatusCode badRequest)
			{
				this.badRequest = badRequest;
			}



		}





	}
}