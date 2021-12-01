using Microsoft.AspNetCore.Mvc;
using Pharmacy.Models;
using Pharmacy.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.Controllers
{
    public class PharmacyController : Controller
    {
        public IActionResult Drug()
        {
            List<Drug> drugs = new List<Drug>()
            {
                new Drug(){Name="Gliaton Forte",Price=28,Company="Fortex"},
                new Drug(){Name="Arko Krem",Price=2,Company="Eviap"},
                new Drug(){Name="Santa Farma",Price=3,Company="Alset"}
                
            };
            List<DrugType> types = new List<DrugType>()
            {
                new DrugType(){Type="Vitamin"},
                new DrugType(){Type="Krem"}
            };
            DrugViewModel model = new DrugViewModel()
            {
                Drugs = drugs,
                DrugTypes = types
            };
            return View(model); 
        }

        public IActionResult DrugType()
        {
            List<DrugType> types = new List<DrugType>()
            {
                new DrugType(){Type="Vitamin"},
                new DrugType(){Type="Krem"}
            };
            return View(types);
        }
    }
}
