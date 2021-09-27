using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {

        private string[] saludos = {"Buenos días", "Buenas tardes", "Buenas noches", "Hasta mañana"};

        public List<string> ListaSaludos {get;set;}


        //Este Método se ejecuta cuando se haga un llamado a la página list(cuando den click a la opción del menú)
        public void OnGet()
        {
            ListaSaludos = new List<string>();
            ListaSaludos.AddRange(saludos);
        }
    }
}
