namespace COW.GamePlay.UGCRuntime;

public interface IUGCDatabaseModule : IUGCModule
{
	bool CheckRequestFinished(UGCDatabaseOperationRequest request);

	void ReleaseOperationRequest(UGCDatabaseOperationRequest request);

	UGCDatabaseOperationRequest GetValueRequest(string tableName, string accountId, string key, string workshopCode);

	UGCDatabaseOperationRequest SetValueRequest(string tableName, string accountId, string key, object value, string workshopCode);

	UGCDatabaseOperationRequest DeleteValueRequest(string tableName, string accountId, string key, string workshopCode);

	UGCDatabaseOperationRequest GetValueByColumnIndexRequest(string tableName, string accountId, string key, int columnIndex, string workshopCode);
}
