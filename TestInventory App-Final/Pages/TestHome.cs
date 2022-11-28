using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Inventory_App_Final.Pages;
using Inventory_App_Final.InventoryApp;
using Inventory_App_Final.ECommerce;
using Inventory_App_Final.ECommerce1;

namespace TestInventory_App_Final
{
	public class TestHome
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbPieChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new InventoryAppService(mockHttpClient));
			ctx.Services.AddSingleton(new ECommerceService(mockHttpClient));
			ctx.Services.AddSingleton(new ECommerce1Service(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Home>();
			Assert.NotNull(componentUnderTest);
		}
	}
}