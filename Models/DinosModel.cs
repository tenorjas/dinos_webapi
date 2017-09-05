using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dinos_webapi.Models
{
    public class DinosModel
    {
        [Key]
        public int DinoId {get; set;}
        public string DinoName {get; set;}
        public string DinoColor {get; set;}
        public string DinoSize {get; set;}
        public string DinoHabitats {get; set;}

        public DinosModel()
        {

        }

        public List<DinosModel> DinoListGetter()
        {
            var DinosList = new List<DinosModel>();
            var Triceratops = new DinosModel{
                DinoId = 1,
                DinoName = "Triceratops",
                DinoSize = "Medium-Large",
                DinoHabitats = "Plains"
            };

            var TRex = new DinosModel{
                DinoId = 2,
                DinoName = "T-Rex",
                DinoSize = "Large",
                DinoHabitats = "Plains"
            };

            var Stegosaurus = new DinosModel{
                DinoId = 3,
                DinoName = "Stegosaurus",
                DinoSize = "Medium-Large",
                DinoHabitats = "Plains"
            };
            DinosList.Add(Triceratops);
            DinosList.Add(TRex);
            DinosList.Add(Stegosaurus);
            return DinosList;
        }

        
    }
}