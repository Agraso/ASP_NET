using Portafolio.Models;
using System.Collections.Generic;

namespace Portafolio.Servicios
{

    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() { new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "E-Commerce realizado en ASP.NET Core",
                link = "https://www.amazon.com/",
                ImagenURL = "/imagenes/amazon.png"
            },

            new Proyecto
            {
                Titulo = "New York Times",
                Descripcion = "Página de noticias en React",
                link = "https://www.nytimes.com/",
                ImagenURL = "/imagenes/nyt.png"
            },

            new Proyecto
            {
                Titulo = "Reddit",
                Descripcion = "Red Social para compartir en comunidades",
                link = "https://www.reddit.com/",
                ImagenURL = "/imagenes/reddit.png"
            },

            new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Tienda en línea para comprar videojuegos",
                link = "https://store.steampowered.com/?l=spanish",
                ImagenURL = "/imagenes/steam.png"
            },
            };
        }

    }
}
