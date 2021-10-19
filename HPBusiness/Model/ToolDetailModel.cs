
using System;
namespace HP.Model
{
	public class ToolDetailModel : BaseModel
	{
		private int iD;
		private string workerName;
		private string partCode;
		private DateTime? createDate;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public string WorkerName
		{
			get { return workerName; }
			set { workerName = value; }
		}
	
		public string PartCode
		{
			get { return partCode; }
			set { partCode = value; }
		}
	
		public DateTime? CreateDate
		{
			get { return createDate; }
			set { createDate = value; }
		}
	
	}
}
	