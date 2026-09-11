using System.Collections.Generic;
using GCommon;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCDatabaseModule : IUGCDatabaseModule, IUGCModule
{
	private UGCRuntime m_UGCRuntime;

	private UniqueIDGenerator m_ReqIDGen;

	private Dictionary<uint, UGCDatabaseOperationRequest> m_Operations;

	private UGCObjectPool<UGCDatabaseOperationRequest> m_OperationPool;

	private UGCDatabaseServer m_Server;

	public IUGCModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void Destroy()
	{
	}

	public bool CheckRequestFinished(UGCDatabaseOperationRequest request)
	{
		return false;
	}

	public void ReleaseOperationRequest(UGCDatabaseOperationRequest request)
	{
	}

	public UGCDatabaseOperationRequest GetValueRequest(string tableName, string accountId, string key, string workshopCode)
	{
		return null;
	}

	public UGCDatabaseOperationRequest SetValueRequest(string tableName, string accountId, string key, object value, string workshopCode)
	{
		return null;
	}

	public UGCDatabaseOperationRequest DeleteValueRequest(string tableName, string accountId, string key, string workshopCode)
	{
		return null;
	}

	public UGCDatabaseOperationRequest GetValueByColumnIndexRequest(string tableName, string accountId, string key, int columnIndex, string workshopCode)
	{
		return null;
	}

	private UGCDatabaseOperationRequest CreateOperationRequest(uint id, EUGCDatabaseOperationType operationType)
	{
		return null;
	}

	private void OnRecvNormalData(uint reqId, BEPEOKLEMIP value)
	{
	}

	private string FixWorkshopCode(string workshopCode)
	{
		return null;
	}

	private string CurrentWorkshopCode()
	{
		return null;
	}
}
