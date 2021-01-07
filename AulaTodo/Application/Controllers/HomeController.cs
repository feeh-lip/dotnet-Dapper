﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Models;
using ORM.Interfaces;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITodoRepository _todoRepository;

        public HomeController(ITodoRepository todoRepository, ILogger<HomeController> logger)
        {
            _logger = logger;
            _todoRepository = todoRepository;
        }

        public IActionResult Index()
        {
            return View(_todoRepository.GetAll());
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Entities.ToDo obj)
        {
            if (ModelState.IsValid)
            {
                _todoRepository.Add(obj);
                NotificationViewModel.Set(TempData, new Notificacao() { Mensagem = "A Tarefa foi cadastrada com sucesso", Tipo = TipoNotificacao.success });
                return View("Index", _todoRepository.GetAll());
            }
            else
            {
                NotificationViewModel.Set(TempData, new Notificacao() { Mensagem = "Não foi possível cadastrar essa tarefa", Tipo = TipoNotificacao.danger });
                return View();
            }
        }
        public IActionResult Editar(int id)
        {
            return View(_todoRepository.Get(id));
        }
        [HttpPost]
        public IActionResult Editar(Entities.ToDo obj)
        {
            if (ModelState.IsValid)
            {
                _todoRepository.Update(obj);
                NotificationViewModel.Set(TempData, new Notificacao() { Mensagem = "A Tarefa foi alterada com sucesso", Tipo = TipoNotificacao.success });
                return View("Index", _todoRepository.GetAll());
            }
            else
            {
                NotificationViewModel.Set(TempData, new Notificacao() { Mensagem = "Não foi possível editar essa tarefa", Tipo = TipoNotificacao.danger });
                return View();
            }

        }
        public IActionResult Remover(int id)
        {
            return View(_todoRepository.Get(id));
        }
        public IActionResult ConfirmaRemover(int id)
        {
            _todoRepository.Remove(_todoRepository.Get(id));
            return View("Index", _todoRepository.GetAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
