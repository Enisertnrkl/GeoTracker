using GeoTrackerClient;
using Microsoft.Data.SqlClient;

namespace TrackerClient;

public partial class Login : ContentPage
{
	string connectionString = "Server=10.147.17.3;User Id=enis.ertnrkl;Password=402624;Database=GeoTracker;TrustServerCertificate=True";
	public Login()
	{
		InitializeComponent();
	}
	private async void login_Clicked(object sender, EventArgs e)
	{
		string user = username.Text;
		string pass = password.Text;
		using (SqlConnection conn = new SqlConnection(connectionString))
		{
			conn.Open();
			string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@username", user);
				cmd.Parameters.AddWithValue ("@password", pass);
				int affectedRows = (int)cmd.ExecuteScalar();
				if (affectedRows > 0)
				{
					await SecureStorage.SetAsync("username",user);
					DisplayAlert("Login Successful", "Successfully logged in.", "OK");
					MainPage mainPage = new MainPage();
					await Navigation.PushAsync(mainPage);
				}
				else
				{
					DisplayAlert("Login Failed", "Wrong username or password.", "OK");
				}
			}
		}

	}
}