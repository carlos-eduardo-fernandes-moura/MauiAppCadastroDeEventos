
using MauiAppCadastroDeEventos.Models;

namespace MauiAppCadastroDeEventos.Views;

public partial class telaCadastro : ContentPage
{
	App PropriedadesApp;
	public telaCadastro()
	{
        
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;
        pck_localEvento.ItemsSource = PropriedadesApp.locaisDisponiveis;
        pck_bebidaAlcolica.ItemsSource = PropriedadesApp.opcoesBebidasAlcolicas;

        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_inicio.MaximumDate = DateTime.Now.AddDays(7);
        dtpck_final.MinimumDate = DateTime.Now.AddDays(1);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Picker localEscolhido = pck_localEvento;
        int indiceLocalEscolhido=-1;
        int qnt_convidados=0;
        Eventos evento = new Eventos();


        if (localEscolhido.SelectedIndex==-1)
        {
            DisplayAlert("Ops", "Escolha um local para o evento", "Ok");

        }else
        {
            indiceLocalEscolhido = localEscolhido.SelectedIndex;

            try
            {
                 qnt_convidados = int.Parse(txt_quantidadeConvidados.Text);

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Digite um número válido");
            }
            if (qnt_convidados > PropriedadesApp.locaisDisponiveis[indiceLocalEscolhido].capacidadeMaxima)
            {
                DisplayAlert("Ops", "Quantidade máxima de pessoas excedida", "Ok");
            }else
            {
                evento.nome = txt_nomeEvento.Text;
                evento.local = PropriedadesApp.locaisDisponiveis[indiceLocalEscolhido];
                evento.qnt_dias = ((DateTime)dtpck_final.Date).Subtract((DateTime)dtpck_inicio.Date).Days;
                evento.temBebidaAlcolica = "Sim";
                try
                {
                    await Navigation.PushAsync(new TelaFinal()
                    {
                        BindingContext = evento
                    });
                }catch(Exception ex)
                {
                    DisplayAlert("Ops", ex.Message, "Ok");
                }
            }
        }

        
    }

    private void txt_quantidadeConvidados_TextChanged(object sender, TextChangedEventArgs e)
    {
        
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        dtpck_final.MinimumDate = dtpck_inicio.Date;
        dtpck_final.MaximumDate = dtpck_inicio.Date.AddDays(10);
    }
}