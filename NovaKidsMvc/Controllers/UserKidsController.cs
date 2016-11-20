using AutoMapper;
using NovaKids.Application;
using NovaKids.Application.Interface;
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
        private readonly IUserKidsAppService _userKidsAppService;

        public UserKidsController(IUserKidsAppService userAppService)
        {
            _userKidsAppService = userAppService;
        }

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
                
                

                if (userkids.Tipo.Equals("professor"))
                {
                    Professor prof = new Professor();
                    prof.Nome = userkids.Nome;
                    prof.Senib = userkids.Senib;
                    prof.Matricula = userkids.Matricula;
                    prof.Tag = userkids.Tag;
                    prof.HorarioKids = userkids.HorarioKids;
                    prof.Kids = userkids.Kids;
                    prof.Tipo = userkids.Tipo;
                    _userKidsAppService.Add(userkids);
                }

                if (userkids.Tipo.Equals("crianca"))
                {
                    Crianca crianca = new Crianca();
                    crianca.Nome = userkids.Nome;
                    crianca.Senib = userkids.Senib;
                    crianca.Matricula = userkids.Matricula;
                    crianca.Tag = userkids.Tag;
                    crianca.HorarioKids = userkids.HorarioKids;
                    crianca.Kids = userkids.Kids;
                    crianca.Tipo = userkids.Tipo;
                    _userKidsAppService.Add(userkids);
                }

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
