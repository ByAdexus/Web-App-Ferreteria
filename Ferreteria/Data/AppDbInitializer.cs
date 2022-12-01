using Ferreteria.Data.Modelo;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Ferreteria.Data
{
    public class AppDbInitializer
    {
        //Metodo que agrega datos a nuestra BD
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if(!context.productos.Any())
                {
                    context.productos.AddRange(new producto()
                    {
                        Nombre = "Martillo",
                        Descripcion = "Es de acero",
                        CantidadProducto = 1,
                        Precio = 150
                    },
                    new producto()
                    {
                        Nombre = "Pinzas",
                        Descripcion = "Es de acero y plastico",
                        CantidadProducto = 2,
                        Precio = 130
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
