
using System.Collections;
using HP.Model;
namespace HP.Facade
{
	
	public class MotorHistoryImExFacade : BaseFacade
	{
		protected static MotorHistoryImExFacade instance = new MotorHistoryImExFacade(new MotorHistoryImExModel());
		protected MotorHistoryImExFacade(MotorHistoryImExModel model) : base(model)
		{
		}
		public static MotorHistoryImExFacade Instance
		{
			get { return instance; }
		}
		protected MotorHistoryImExFacade():base() 
		{ 
		} 
	
	}
}
	