
using System.Collections;
using HP.Model;
namespace HP.Facade
{
	
	public class ToolDetailFacade : BaseFacade
	{
		protected static ToolDetailFacade instance = new ToolDetailFacade(new ToolDetailModel());
		protected ToolDetailFacade(ToolDetailModel model) : base(model)
		{
		}
		public static ToolDetailFacade Instance
		{
			get { return instance; }
		}
		protected ToolDetailFacade():base() 
		{ 
		} 
	
	}
}
	