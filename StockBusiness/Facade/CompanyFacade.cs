
using System.Collections;
using ST.Model;
namespace ST.Facade
{
	
	public class CompanyFacade : BaseFacade
	{
		protected static CompanyFacade instance = new CompanyFacade(new CompanyModel());
		protected CompanyFacade(CompanyModel model) : base(model)
		{
		}
		public static CompanyFacade Instance
		{
			get { return instance; }
		}
		protected CompanyFacade():base() 
		{ 
		} 
	
	}
}
	