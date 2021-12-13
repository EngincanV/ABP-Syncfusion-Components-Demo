using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace SyncfusionComponentsDemo.Pages
{
    public class Index_Tests : SyncfusionComponentsDemoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
