using Microsoft.AspNetCore.Mvc;
using System;
using AniversariantesMVCRee.Data;
using AniversariantesMVCRee.Models;
using System.Linq;
using System.Collections.Generic;

namespace AniversariantesMVCRee.Controllers
{
    public class AmigosController : Controller
    {
        public AmigosController(BancoDeDados bancoDeDados)
        {
            BancoDeDados = bancoDeDados;
        }

        public BancoDeDados BancoDeDados { get; set; }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Listar()
        {
            // lista de amigos 
            var amigos = BancoDeDados.Amigo
                .OrderByDescending(x => x.Nascimento)   // ordenando
                .ToList();

            var dia = DateTime.Now.Day; // dia atual
            var mes = DateTime.Now.Month; // mes atual

            var aniversariantes = BancoDeDados.Amigo.Where(x => x.Nascimento.Day == dia && x.Nascimento.Month == mes).ToList(); // apenas aniversariantes do dia

            Resposta resposta = new Resposta();
            resposta.Amigos = amigos;
            resposta.Aniversariante = aniversariantes;

            return View(resposta);
        }

        [HttpGet]
        public List<Amigo> Buscar(string nome)
        {
            // lista de amigos 
            var amigos = BancoDeDados.Amigo
                .Where(x => x.Nome.Contains(nome) || x.Sobrenome.Contains(nome))   // ordenando
                .ToList();

            return amigos;
        }

        [HttpPost]
        public ActionResult Cadastro(string nome, string sobrenome, DateTime nascimento)
        {
            var amigo = new Amigo();
            amigo.Nome = nome;
            amigo.Sobrenome = sobrenome;
            amigo.Nascimento = nascimento;

            BancoDeDados.Amigo.Add(amigo);
            BancoDeDados.SaveChanges();

            return Redirect("Listar");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var amigo = BancoDeDados.Amigo.Find(id);
            return View(amigo);
        }

        [HttpPost]
        public ActionResult Editar(int id, string nome, string sobrenome, DateTime nascimento)
        {

            var amigoAnterior = BancoDeDados.Amigo.First(p => p.Id == id);
            amigoAnterior.Nome = nome;
            amigoAnterior.Sobrenome = sobrenome;
            amigoAnterior.Nascimento = nascimento;

            BancoDeDados.SaveChanges();
            return Redirect("Listar");
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            var amigo = BancoDeDados.Amigo.Find(id);
            BancoDeDados.Remove(amigo);
            BancoDeDados.SaveChanges();

            return Redirect("Listar");

        }

    }    
}
