using Microsoft.Extensions.Caching.Memory;
using System;
using System.Linq;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Consultar();
            Borrado();
            Actualizacion();
            Insertar();




            static void Borrado()
            {
                var ctx = new Tareasdbcontext();
                var Usuarios = ctx.Usuarios.Where(i => i.UsuarioPK == 1).Single();
                ctx.Usuarios.Remove(Usuarios);
                ctx.SaveChanges();
                
                var Usuarioss = ctx.Usuarios.Where(i => i.UsuarioPK == 2).Single();
                ctx.Usuarios.Remove(Usuarios);

                var Usuariosss = ctx.Usuarios.Where(i => i.UsuarioPK == 3).Single();
                ctx.Usuarios.Remove(Usuarios);



            }

            static void Actualizacion()
            {
                var ctx = new Tareasdbcontext();
                var Usuarios = ctx.Usuarios.Where(i=> i.UsuarioPK == 1). Single();
                Usuarios.Nombre = "Gabriel";

                var Usuarios3 = ctx.Usuarios.Where(i => i.UsuarioPK == 3).Single();
                Usuarios.Nombre = "Tomas";

                var Usuarios4 = ctx.Usuarios.Where(i => i.UsuarioPK == 4).Single();
                Usuarios.Nombre = "lucas";

                var Usuarios2 = ctx.Usuarios.Where(i => i.UsuarioPK == 2).Single();
                if (Usuarios2 != null)
                {
                    Usuarios2.Nombre = "Prueba";

                }

                ctx.SaveChanges();

            }

            static void Consultar()
            {
                var ctx = new Tareasdbcontext();
                var lista = ctx.Usuarios.ToList();
                foreach (var item in lista)
                {
                    Console.WriteLine($"Nombre: {item.Nombre} ({item.UsuarioPK})");

                }


            }
            static void Insertar ()
            {

                var ctx = new Tareasdbcontext();

                ctx.Usuarios.Add(new Usuarios
                {
                    UsuarioPK = 1,
                    Nombre = "Gabriel",
                    Clave = "1234"
                });


                ctx.Usuarios.Add(new Usuarios
                {
                    UsuarioPK = 2,
                    Nombre = "Jorge",
                    Clave = "090909"
                });

                ctx.Usuarios.Add(new Usuarios
                {
                    UsuarioPK = 3,
                    Nombre = "martin",
                    Clave = "020909"
                });


                ctx.Usuarios.Add(new Usuarios
                {
                    UsuarioPK = 4,
                    Nombre = "Marcos",
                    Clave = "0909209"
                });

                ctx.SaveChanges();

            }
        }
    }
}
