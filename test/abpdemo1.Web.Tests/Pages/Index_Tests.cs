using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace abpdemo1.Pages
{
    public class Index_Tests : abpdemo1WebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
