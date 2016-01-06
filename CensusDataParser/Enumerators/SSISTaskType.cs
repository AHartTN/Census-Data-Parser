using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusDataParser.Enumerators
{
	public enum SSISTaskType
	{
		ActiveXScriptTask,
		BulkInsertTask,
		ExecuteProcessTask,
		ExecutePackageTask,
		Exec80PackageTask,
		FileSystemTask,
		FTPTask,
		MSMQTask,
		PipelineTask,
		ScriptTask,
		SendMailTask,
		SQLTask,
		TransferStoredProceduresTask,
		TransferLoginsTask,
		TransferErrorMessagesTask,
		TransferJobsTask,
		TransferObjectsTask,
		TransferDatabaseTask,
		WebServiceTask,
		WmiDataReaderTask,
		WmiEventWatcherTask,
		XMLTask
	}
}
