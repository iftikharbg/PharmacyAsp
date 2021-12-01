using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.ViewsModels
{
    public class DrugViewModel
    {
        public List<Drug> Drugs { get; set; }

        public List<DrugType> DrugTypes { get; set; }
    }
}
