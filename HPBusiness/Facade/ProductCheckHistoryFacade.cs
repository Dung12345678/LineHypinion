
using System.Collections;
using HP.Model;
namespace HP.Facade
{
	
	public class ProductCheckHistoryFacade : BaseFacade
	{
		protected static ProductCheckHistoryFacade instance = new ProductCheckHistoryFacade(new ProductCheckHistoryModel());
		protected ProductCheckHistoryFacade(ProductCheckHistoryModel model) : base(model)
		{
		}
		public static ProductCheckHistoryFacade Instance
		{
			get { return instance; }
		}
		protected ProductCheckHistoryFacade():base() 
		{ 
		} 
	
	}
}
	