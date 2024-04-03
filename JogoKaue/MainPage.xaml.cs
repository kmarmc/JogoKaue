namespace JogoKaue;

public partial class MainPage : ContentPage
{

   Cachorro Scooby;
   Gato Miau;
   Tigre Tiger; 
   Personagem atual;
  
	public MainPage()
    {
		InitializeComponent();

		imgPersonagem.Source = "doguinho.jpg";
		Scooby = new Cachorro();
		Miau = new Gato();
		Tiger = new Tigre();

		atual = Scooby;

		imgPersonagem.Source = atual.GetNomeDaFoto();

    }
     void BotaoTrocar(object sender, EventArgs args)
     {
		if (atual == Scooby)
			atual = Miau;
		else if (atual == Miau)
				atual = Tiger;
		else if (atual == Tiger)
				atual = Scooby;

		imgPersonagem.Source= atual.GetNomeDaFoto();
     }


}

