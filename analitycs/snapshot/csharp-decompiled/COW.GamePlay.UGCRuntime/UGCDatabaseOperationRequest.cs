using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCDatabaseOperationRequest : IUGCObjectPoolItem
{
	public uint ReqId;

	public bool IsDone;

	public EUGCDatabaseOperationType OperationType;

	public ADFCFJBKADI ErrorCode;

	public object Result;

	public void Init(uint reqId, EUGCDatabaseOperationType operationType)
	{
	}

	public void Reset()
	{
	}

	public UGCSimpleValue ToValue()
	{
		return null;
	}

	public List<object> SerializeList(BEPEOKLEMIP data)
	{
		return null;
	}

	public BEPEOKLEMIP ConvertToUGCDatabaseData(object value)
	{
		return null;
	}

	private UGCSimpleValue UGCDatabaseDataToSimpleValue(BEPEOKLEMIP data)
	{
		return null;
	}
}
