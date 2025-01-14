using System.Threading.Tasks;

namespace GenderizeApi__Midterm.Models
{
    public class Gender
    {
        public string name { get; set; }
        public string gender { get; set; }
        public float probablility { get; set; }
        public int count { get; set; }
        public string countryId { get; set; }
    }

    class Program
    {

        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }


        private static async Task ProcessRepositories()
        {
        }

        static HttpClient client = new HttpClient();

    }
}
