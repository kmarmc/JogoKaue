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

		var timer =
		Application.Current.Dispatcher.CreateTimer();
		timer.Interval =
		TimeSpan.FromSeconds(5);
		timer.Tick += (s,e) =>
		PassouTempo();
		timer.Start();

		imgPersonagem.Source = "doguinho.jpg";
		Scooby = new Cachorro();
		Miau = new Gato();
		Tiger = new Tigre();

		atual = Scooby;

		imgPersonagem.Source = atual.GetNomeDaFoto();
		 AdicionarVida();
    }

	void PassouTempo()
	{
			var estavaMorto=atual.GetMorto();
			atual.SetSono(atual.GetSono()-0.2);
			atual.SetSede(atual.GetSede()-0.2);
			atual.SetFome(atual.GetFome()-0.2);
			AdicionarVida();
			if(estavaMorto!=atual.GetMorto())
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
		AdicionarVida();
     }
	 void AdicionarVida()
	{
		linhaBar.Progress=atual.GetFome();
		linhaBar1.Progress=atual.GetSede();
		linhaBar2.Progress=atual.GetSono();
	}
	void RecuperarEnergia(object sender, EventArgs args)
	{
		atual.SetSono(atual.GetSono()+0.2);
		 AdicionarVida();
	}
	void BeberAgua(object sender, EventArgs args)
	{
		atual.SetSede(atual.GetSede()+0.2);
		 AdicionarVida();
	}
	void SeAlimentar(object sender, EventArgs args)
	{
		atual.SetFome(atual.GetFome()+0.2);
		 AdicionarVida();
	}
}

