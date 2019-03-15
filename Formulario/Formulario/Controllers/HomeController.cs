using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers {
   public class HomeController : Controller {

      // GET: Home
      public ActionResult Index() {

         // inicializar valor inicial do ViewBag
         ViewBag.Resposta = "";

         return View();
      }


      [HttpPost]
      public ActionResult Index(string nome, int? idade) {

         // var auxiliar
         string resposta = "";


         if(nome != "") {
            // preparar a resposta a enviar para a View
            resposta = "você chama-se " + nome;
         }

         if(idade != null) {
            resposta += " e tem " + idade + " anos.";
         }

         // enviar a 'resposta' para a View
         ViewBag.Resposta = resposta;

         return View();
      }


   }
}