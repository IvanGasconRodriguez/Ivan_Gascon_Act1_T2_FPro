public class Program{
    /*ToDo
    1.Mejorar cw menus opciones
    2.Mejorar aspecto, emojis
    3.Cambiar usuario como entrenamiento(registrarUsuario) sin tener que crear mas usuarios
    */
    public static void Main(string[]args){
        System.Console.WriteLine("Bienvenido al programa de registro de entrenamientos");
        bool pararInicio =false;
        do{
        System.Console.WriteLine("Introduzca el numero de la opcion deseada:");
        System.Console.WriteLine("1.Crear Usuario");
        System.Console.WriteLine("2.Logear");
        System.Console.WriteLine("3.Salir");
        int opcion =int.Parse(Console.ReadLine());
        switch(opcion){
            case 1:
            System.Console.WriteLine("Introduzca su nombre de usuario");
            string? nombre = Console.ReadLine();
            System.Console.WriteLine("Introduzca mail");
            string? mail = Console.ReadLine();
            System.Console.WriteLine("Introduzca contraseña");
            string? contrasenia= Console.ReadLine();
            Usuario user1 = new Usuario(nombre,mail,contrasenia);
            user1.CrearUsuario(user1);
            break;
            case 2:
            Usuario user2 = new Usuario();
             System.Console.WriteLine("Introduzca mail");
            mail = Console.ReadLine();
            
            foreach (var item in Usuario.listaUsuarios)
            {
                if(item.GetMail()==mail){
            System.Console.WriteLine("Introduzca contraseña");
            contrasenia= Console.ReadLine();
            if(item.GetContrasenia()==contrasenia){
                System.Console.WriteLine("Ha sido logeado");
                bool pararMenu=false;
                do{
                    System.Console.WriteLine("Bienvenido al menu de registro de Entrenamientos");
                    System.Console.WriteLine("Escoga una opcion");
                    System.Console.WriteLine("1.Registrar un entrenamiento");
                    System.Console.WriteLine("2.Listar entrenamientos");
                    System.Console.WriteLine("3.Vaciar entrenamientos");
                    System.Console.WriteLine("4.Cerrar sesion");
                    opcion=int.Parse(Console.ReadLine());
                    Entrenamiento entrenamiento1 = new Entrenamiento();
                    switch(opcion){
                        case 1:
                        System.Console.WriteLine("Introduzca un nombre para su entrenamiento");
                        string? nombreEntrenamiento = Console.ReadLine();
                        System.Console.WriteLine("Distancia");
                        int distancia= int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Tiempo");
                        int tiempo = int.Parse(Console.ReadLine());
                        Entrenamiento entrenamiento = new Entrenamiento(nombreEntrenamiento,distancia,tiempo);
                        entrenamiento.RegistrarEntrenamiento(entrenamiento);
                        break;
                        case 2:
                        Entrenamiento.ListarEntrenamientos();
                        break;
                        case 3:
                        entrenamiento1.VaciarEntrenamientos();
                        break;
                        case 4:
                        System.Console.WriteLine("Cerrando Sesion");
                        pararMenu=true;
                        break;
                        default:
                        System.Console.WriteLine("Opcion no valida");
                        break;
                    }
                }while(!pararMenu);
            }
        }
                
            }
            break;
            case 3 :
            System.Console.WriteLine("Saliendo");
            pararInicio=true;
            break;
            default:
            System.Console.WriteLine("Opcion no valida");
            break;
            
            
        }
        }while(!pararInicio);


    }
}
