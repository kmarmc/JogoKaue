namespace JogoKaue;
 public class Personagem
 {
   public double fome;
   public double sede;
   public double sono;
   public string NomeDaFoto;
   public string PersonagemMorto;
   public bool Morto;


   public Personagem()
   {
      fome = 0;
      sede = 0;
      sono = 0;
      NomeDaFoto = "";
   }      
   public string GetNomeDaFoto()
    {
      if (Morto)
      return PersonagemMorto;
      else 
        return NomeDaFoto; 
    }
    public bool GetMorto()
    {
      return Morto;
    }
   public void SetFome (double f)
   {
      if (f >= 0 && f <= 1)
      fome = f; 
      else if (f > 1)
      fome = 1; 
      else if (f <= 0)
      {
      fome = 0;
      Morto= true;
      }
   }
   public double GetFome()
    {
        return fome; 
    }
  public void SetSede (double s)
   {
      if (s >= 0 && s <= 1)
        sede = s;
      else if (s > 1)
        sede = 1; 
      else if (s <= 0)
      {
        sede = 0;
        Morto= true;
      }
   }
   public double GetSede()
    {
        return sede; 
    }
   public void SetSono (double p)
   {
      if (p >= 0 && p <= 1)
      sono = p; 
      else if (p > 1)
      sono = 1; 
      else if (p <= 0)
      {
      sono = 0;
      Morto= true;
      }

   }
   public double GetSono()
    {
        return sono; 
    }
 }