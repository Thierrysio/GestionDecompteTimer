using GestionDecompteTimer.VueModeles;

namespace GestionDecompteTimer.Vues;

public partial class GestionTimetVue : ContentPage
{
	GestionTimetVueModele vueModele;
    public GestionTimetVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new GestionTimetVueModele();
	}
}