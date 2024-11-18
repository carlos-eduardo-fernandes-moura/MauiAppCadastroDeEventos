namespace MauiAppCadastroDeEventos.Views;

public partial class TelaFinal : ContentPage
{
	public TelaFinal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new telaCadastro());
    }
}