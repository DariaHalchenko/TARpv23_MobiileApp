namespace TARpv23_MobiileApp;

public partial class StartPage : ContentPage
{
	public List<ContentPage> lehed=new List<ContentPage>() { new TextPage(), new FigurePage()};
	public List<string> tekstid = new List<string> { "Tee lahti TekstPage", "Tee lahti FigurePage" };
	ScrollView sv;
	VerticalStackLayout vsl;
	public StartPage()
	{
		Title = "Avaleht";
		vsl = new VerticalStackLayout { BackgroundColor=Color.FromArgb("#FFC0CB") };
		for(int i = 0; i < tekstid.Count; i++)
		{
			Button nupp = new Button
			{
				Text = tekstid[i],
                BackgroundColor = Color.FromArgb("#EE82EE"),
				TextColor = Color.FromArgb("#FF00FF"),
				BorderWidth = 10,
				ZIndex= i,
				FontFamily= "Luckymoon 400",
				FontSize = 30
            };
			vsl.Add(nupp);
            nupp.Clicked += Lehte_avamine;
		}
		sv = new ScrollView { Content = vsl };
		Content = sv;

	}

    private async void Lehte_avamine(object? sender, EventArgs e)
    {
        Button btn = (Button)sender;
		await Navigation.PushAsync(lehed[btn.ZIndex]);
    }
}