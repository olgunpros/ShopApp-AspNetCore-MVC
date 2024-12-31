using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.Data;

namespace shopapp.Components
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if(RouteData.Values["action"].ToString() == "list" )
            ViewBag.SelectedCategory = RouteData?.Values["id"];
             return View(CategoryRepository.Categories);
        }
    }
}
