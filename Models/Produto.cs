namespace API.Models;

        

public class Produto{

   public Produto(){

   }

   public Produto (string nome,string descricao,double valor){
      Nome = nome;
      Descricao = descricao;
      Valor = valor;
      Id = Guid.NewGuid().ToString();
      CriadoEm =DateTime.Now; 
   }

    public string ?Id {get; set;}
    public string ?Nome {get; set;}
    public string ?Descricao {get; set;}
    public double Valor {get; set;}
    public DateTime CriadoEm {get; set;}
}
   
   