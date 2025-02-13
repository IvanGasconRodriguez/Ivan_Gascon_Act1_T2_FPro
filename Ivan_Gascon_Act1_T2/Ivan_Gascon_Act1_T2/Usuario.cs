
public class Usuario{

private string? nombre;
private string? mail;
private string? contrasenia;

//public Dictionary<string  , string> listaUsuarios= new Dictionary<string ,string>();
public static  List<Usuario> listaUsuarios = new List<Usuario>();



    public Usuario(){}
public Usuario ( string nombre,string mail, string contrasenia){
    this.nombre= nombre;
    this.mail=mail;
    this.contrasenia=contrasenia;
    
}
public void CrearUsuario(Usuario usuario){
    listaUsuarios.Add(usuario);
}
public void Logear(Usuario usuario, string mail, string contrasenia){
    if(usuario.GetMail()==mail && usuario.GetContrasenia()==contrasenia){
        System.Console.WriteLine("Credenciales correctos");

    }else{
        System.Console.WriteLine("Credenciales incorrectos");
    }
}
public void BuscarUsuario(String mail){
    foreach (var item in listaUsuarios)
    {
        if(item.GetMail()==this.mail){
            System.Console.WriteLine("Introduzca contraseña");
            string contrasenia= Console.ReadLine();
            if(item.GetContrasenia()==contrasenia){
                System.Console.WriteLine("Ha sido logeado");
                break;
            }
        }
    }
}
public string GetMail(){
    return this.mail;
}
public void SetMail(string mail){
    this.mail=mail;
}
public string GetContrasenia(){
    return this.contrasenia;
}
public void SetContrasenia(string contrasenia){
    this.contrasenia=contrasenia;
}

}