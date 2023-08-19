using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Race_Track.Models;

namespace Race_Track.ViewModels;

public class VehiculoIndexViewModel{
public List<Vehiculo> vehiculos {get; set; } = new List<Vehiculo>();

        public String? NameFilter { get; set; }

        public int VehiculoId { get; set; }

        [Required(ErrorMessage ="Debe ingresar el nombre del propietario")]
        [Display(Name = "Nombre Propietario")]
        public string? VehiculoNombre {get; set;}

        [Required(ErrorMessage ="Debe ingresar el apellido del propietario")]        
        [Display(Name = "Apellido Propietario")]
        public string? VehiculoApellido {get; set;}

        [Display(Name = "Tipo de vehiculo")]
        public string? VehiculoTipo {get; set;}

        // [Required(ErrorMessage ="Debe ingresar el Numero de matricula")]
        [Display(Name = "Matricula")]
        public string? VehiculoMatricula {get; set;}

        [Display(Name = "Modelo")]
        public DateTime VehiculoFabricacion {get;set;} 
        public ICollection<Piloto> PilotoList { get; set; } = new List<Piloto>();     

}