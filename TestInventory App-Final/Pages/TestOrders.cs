using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Inventory_App_Final.Pages;

namespace TestInventory_App_Final
{
	public class TestOrders
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor();
			var componentUnderTest = ctx.RenderComponent<Orders>();
			Assert.NotNull(componentUnderTest);
		}
	}
}