public class Entrenamiento{
    private string? nombre;
    private int distancia;
    private int tiempo;
    public  static List<Entrenamiento> listaEntrenamientos = new List<Entrenamiento>();

    public Entrenamiento(){}
    public Entrenamiento(string nombre, int distancia, int tiempo){
        this.nombre=nombre;
        this.distancia=distancia;
        this.tiempo=tiempo;
        
    }
    public void RegistrarEntrenamiento(Entrenamiento entrenamiento){
        
        listaEntrenamientos.Add(entrenamiento);
    }
    public static void ListarEntrenamientos(){
        foreach (var item in listaEntrenamientos)
        {
           System.Console.WriteLine(item.GetNombre()+": ");
           System.Console.WriteLine("-"+item.GetDistancia()); 
           System.Console.WriteLine("-"+item.GetTiempo());
        }
    }
    public void VaciarEntrenamientos(){
        listaEntrenamientos.Clear();
    }
    public string GetNombre(){
        return this.nombre;
    }
    public void SetNombre(string nombre){
        this.nombre=nombre;
    }
    public int GetDistancia(){
        return this.distancia;
    }
    public void SetDistancia(int distancia){
        this.distancia=distancia;
    }
    public int GetTiempo(){
        return this.tiempo;
    }
    public void SetTiempo(int tiempo){
        this.tiempo=tiempo;
    }
}