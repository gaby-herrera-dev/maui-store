using EjercicioMauiAppBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EjercicioMauiAppBlazor.Services
{
	/// <summary>
	/// Implementala interfaz IProductoService para recuperar una lista de productos desde una fuente remota
	/// </summary>
	internal class ProductoService : IProductoService
    {
		/// <summary>
		/// URL de la fuente de datos que proporciona una lista de productos
		/// </summary>
		const string URL = "https://api.escuelajs.co/api/v1/products?offset=0&limit=10";
		/// <summary>
		/// Obtiene una lista de productos desde la fuente remota
		/// </summary>
		/// <returns>Una lista de objetos de tipo Producto</returns>
		public async Task<List<Producto>> Get()
        {
            var httClient = new HttpClient();
            var response = await httClient.GetAsync(URL);
            var content = await response.Content.ReadAsStringAsync();
            var Lista = JsonSerializer.Deserialize<List<Producto>>(content);
            return Lista;
        }
    }
}
