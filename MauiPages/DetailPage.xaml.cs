using MauiPages.ViewModel;

namespace MauiPages;

public partial class DetailPage : ContentPage
{
	public DetailPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}