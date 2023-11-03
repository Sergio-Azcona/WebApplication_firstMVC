namespace WebApplication_firstMVC.Services
{
    public class MovieService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public MovieService(HttpClient httpClient)
        {
            //httpClient.BaseAddress("hhtp//go.com")
        }


    }
}
