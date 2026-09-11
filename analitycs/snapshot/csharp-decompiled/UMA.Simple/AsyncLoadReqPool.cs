namespace UMA.Simple;

public class AsyncLoadReqPool : ListPoolWithIndexedObjects<AsyncLoadReq>
{
	protected override AsyncLoadReq Create()
	{
		return null;
	}

	protected override void OnAllocate(AsyncLoadReq r)
	{
	}

	protected override void OnRelease(AsyncLoadReq r)
	{
	}
}
