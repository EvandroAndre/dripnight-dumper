using System;

namespace GarenaMSDK;

internal class ScanIAPInventory : SDKIAPTaskInstance
{
	private SDKIAP.ScanIAPInventoryResult[] _results;

	private SDKIAP.ScanIAPInventoryResult[] _pendingResults;

	public bool CollectPendingPurchases;

	public Action<SDKIAPTaskInfo, SDKIAP.ScanIAPInventoryResult[], SDKIAP.ScanIAPInventoryResult[]> OnScanned;

	public override SDKIAPTask Task => SDKIAPTask.None;

	public ScanIAPInventory(SDKIAPTaskInfo info)
		: base(null)
	{
	}

	public override bool IsGoodToGo()
	{
		return false;
	}

	protected override void Start()
	{
	}

	private void OnScanIAPInventoryResultWithPending(SDKIAP.ScanIAPInventoryResultWithPending results)
	{
	}

	protected override void Succeed()
	{
	}

	protected override void Destroy()
	{
	}

	internal override string IdentifySelf()
	{
		return null;
	}

	private void _003CSucceed_003Eb__10_0(ScanIAPInventory i)
	{
	}

	public SDKIAPTask _003C_003EiFixBaseProxy_get_Task()
	{
		return SDKIAPTask.None;
	}

	public bool _003C_003EiFixBaseProxy_IsGoodToGo()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Start()
	{
	}

	public void _003C_003EiFixBaseProxy_Succeed()
	{
	}

	public void _003C_003EiFixBaseProxy_Destroy()
	{
	}

	public string _003C_003EiFixBaseProxy_IdentifySelf()
	{
		return null;
	}
}
