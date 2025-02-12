public class Program{
    public static void Main(string[]args){
        System.Console.WriteLine("Bienvenido al programa de registro de entrenamientos");
        bool pararInicio =false;
        do{
        System.Console.WriteLine("Introduzca el numero de la opcion deseada:");
        System.Console.WriteLine("1.Crear Usuario");
        System.Console.WriteLine("2.Logear");
        System.Console.WriteLine("3.Salir");
        int opcion =Console.Read();
        switch(opcion){
            case 1:
            System.Console.WriteLine("Introduzca su nombre de usuario");
            string? nombre = Console.ReadLine();
            System.Console.WriteLine("Introduzca mail");
            string? mail = Console.ReadLine();
            System.Console.WriteLine("Introduzca contraseña");
            string? contrasenia= Console.ReadLine();
            Usuario user1 = new Usuario(nombre,mail,contrasenia);
            break;
            case 2:
            
        }
        }while(pararInicio);


    }
}
