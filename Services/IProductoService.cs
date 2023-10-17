using EjercicioMauiAppBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMauiAppBlazor.Services
{
	/// <summary>
	/// Interfaz que define operaciones para recuperar una lista de productos.
	/// </summary>
	internal interface IProductoService
    {
		/// <summary>
		/// Obtiene una lista de productos.
		/// </summary>
		/// <returns>Una lista de objetos de tipo Producto</returns>
		Task<List<Producto>> Get();
       
    }
}
