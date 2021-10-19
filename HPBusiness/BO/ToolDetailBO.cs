
using System;
using System.Collections;
using HP.Facade;
using HP.Model;
namespace HP.Business
{
	
	public class ToolDetailBO : BaseBO
	{
		private ToolDetailFacade facade = ToolDetailFacade.Instance;
		protected static ToolDetailBO instance = new ToolDetailBO();

		protected ToolDetailBO()
		{
			this.baseFacade = facade;
		}

		public static ToolDetailBO Instance
		{
			get { return instance; }
		}
		
	
	}
}
	