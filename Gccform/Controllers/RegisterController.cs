using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gccform.Models;
using Gccform.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using Gccform.ViewModels;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gccform.Controllers
{
    [Route("register")]
    public class RegisterController : Controller
    {
        private readonly DemoDbContext _context;

        public RegisterController(DemoDbContext context)
        {
            _context = context;
        }

        // GET: Person
        [Route("")]
        public async Task<IActionResult> Index()
        {

            var persons = await _context.Persons.ToListAsync();
            var personNames = await _context.PersonNames.ToListAsync();
            TableView tabelModel = new TableView();
            tabelModel.Persons = persons;
            tabelModel.PersonNames = personNames;

            return View(tabelModel);
        }



        //[Route("")]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost, Route("create")]
        public IActionResult Create(Person person, Address address, Church church, Contact contact, PersonName personName)
        {



            _context.Add(person);
            address.Person = person;
            church.Person = person;
            contact.Person = person;
            personName.Person = person;


            _context.Add(address);
            _context.Add(church);
            _context.Add(contact);
            _context.Add(personName);

            _context.SaveChanges();
                



            return RedirectToAction("Index");


        }


        // GET: Person/Details/5
        [Route("details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
           
            var person = await _context.Persons
                .SingleOrDefaultAsync(m => m.ID == id);

            var address = await _context.Addresses
                .SingleOrDefaultAsync(m => m.PersonID == id);
            
            var contact = await _context.Contacts
                .SingleOrDefaultAsync(m => m.PersonID == id);
            
            var church = await _context.Churches
                .SingleOrDefaultAsync(m => m.PersonID == id);
            
            var personName = await _context.PersonNames
                .SingleOrDefaultAsync(m => m.PersonID == id);

            if (person == null)
            {
                return NotFound();
            }

            ViewBag.Person = person;
            ViewBag.Address = address;
            ViewBag.Contact = contact;
            ViewBag.Church = church;
            ViewBag.PersonName = personName;

            return View();
        }


        // GET: Person/Edit/5
        [HttpGet,Route("edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            var person = await _context.Persons
                .SingleOrDefaultAsync(m => m.ID == id);

            var address = await _context.Addresses
                .SingleOrDefaultAsync(m => m.ID == id);

            var contact = await _context.Contacts
                .SingleOrDefaultAsync(m => m.ID == id);

            var church = await _context.Churches
                .SingleOrDefaultAsync(m => m.ID == id);

            var personName = await _context.PersonNames
                .SingleOrDefaultAsync(m => m.ID == id);

            if (person == null)
            {
                return NotFound();
            }


            EditView mymodel = new EditView();
            mymodel.Persons = person;
            mymodel.Addresses = address;
            mymodel.Contacts = contact;
            mymodel.Churches = church;
            mymodel.PersonNames = personName;

            return View(mymodel);
        }



        // POST: Person/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost,Route("edit")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Person person, Address address, Church church, Contact contact, PersonName personName)
        {
            if (id != person.ID)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    address.Person = person;
                    church.Person = person;
                    contact.Person = person;
                    personName.Person = person;
                    _context.Update(address);
                    _context.Update(church);
                    _context.Update(contact);
                    _context.Update(personName);
                    _context.SaveChanges();
                    return RedirectToAction("Index");

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            EditView mymodel = new EditView();
            mymodel.Persons = person;
            mymodel.Addresses = address;
            mymodel.Contacts = contact;
            mymodel.Churches = church;
            mymodel.PersonNames = personName;

            return View(mymodel);
        }


        // GET: Person/Delete/5
        [HttpGet,Route("delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Persons
                .SingleOrDefaultAsync(m => m.ID == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: Person/Delete/5
        [HttpPost, Route("delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.Persons.SingleOrDefaultAsync(m => m.ID == id);
            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }






        private bool PersonExists(int id)
        {
            return _context.Persons.Any(e => e.ID == id);
        }



    }
}
