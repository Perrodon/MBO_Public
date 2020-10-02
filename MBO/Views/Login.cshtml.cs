using MBO.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBO.Views
{
    public class Login
    {

        [BindProperty] public User User { get; set; }

        public Login()
        {

        }

        protected IActionResult RenderPage()
        {
            return null;
        }

        protected IActionResult PostData()
        {
            //APPEL A UNE ROUTE API
            return null;
        }
    }
}
