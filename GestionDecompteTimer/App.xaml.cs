using GestionDecompteTimer.Vues;

namespace GestionDecompteTimer;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new GestionTimetVue();
	}
}
