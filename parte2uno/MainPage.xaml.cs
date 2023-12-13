namespace parte2uno;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            float a = float.Parse(valor1.Text);
            float b = float.Parse(valor2.Text);
            float c;
            switch (operacion.SelectedItem.ToString())
            {
                case "Suma":
                    {
                        c = a + b;
                        resultado.Text = a + "+" + b + "=" + c;
                        break;
                    }
                case "Resta":
                    {
                        c = a - b;
                        resultado.Text = a + "-" + b + "=" + c;
                        break;
                    }
            }
        }
        catch
        {
            resultado.Text = "Error en la captura de datos";
        }
    }
}