using AutoMapper;
using NovaKids.Infra.Data.Repositories;
using NovaKidsControl.Domain.Entities;
using NovaKidsMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NovaKidsMvc.Controllers
{
    public class UserKidsController : Controller
    {

        private readonly UserKidsRepository _userKidsRepository = new UserKidsRepository();

        // GET: UserKids
        public ActionResult Index()
        {
            var userkidsViewModel = Mapper.Map<IEnumerable<UserKids>, IEnumerable<UserKidsViewModel>>(_userKidsRepository.GetAll());
            return View(userkidsViewModel);
        }

        // GET: UserKids/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserKids/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserKids/Create
        [HttpPost]
        public ActionResult Create(UserKidsViewModel userKidsViewModel)
        {
            try
            {
                // TODO: Add insert logic here

                var userkids = Mapper.Map<UserKidsViewModel,UserKids>(userKidsViewModel);
                
                _userKidsRepository.Add(userkids);

                if (userkids.Tipo.Equals("professor"))
                {
                    Professor prof = new Professor();
                    prof.Id = userkids.Id;
                    
                    _userKidsRepository.AddProfessor(prof);
                }

                //if (userkids.Tipo.Equals("crianca"))
                //{
                //    Crianca crianca = new Crianca(userkids.Id, userkids.Nome, userkids.HorarioKids ,userkids.Senib,userkids.Kids, userkids.Matricula
                //        , userkids.Tag, userkids.Tipo);
                //    _userKidsRepository.AddCrianca(crianca);
                //}

                return RedirectToAction("Index");
            }
            catch
            {
                return View(userKidsViewModel);
            }
        }

        // GET: UserKids/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserKids/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserKids/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserKids/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
