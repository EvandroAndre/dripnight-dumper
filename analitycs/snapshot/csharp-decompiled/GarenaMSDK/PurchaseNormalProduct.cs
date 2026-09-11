using System;

namespace GarenaMSDK;

internal class PurchaseNormalProduct : PurchaseTaskInstance
{
	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, string, int> OnSuccess;

	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> OnFailure;

	public override SDKIAPTask Task => SDKIAPTask.None;

	public PurchaseNormalProduct(SDKIAPTaskInfo info)
		: base(null)
	{
	}

	internal override string IdentifySelf()
	{
		return null;
	}

	protected override void Start()
	{
	}

	private void OnPaymentProcessedOrException(SDKIAP_Android.TransactionInfo transactionInfo)
	{
	}

	protected override void Succeed()
	{
	}

	protected override void Fail()
	{
	}

	protected override void Destroy()
	{
	}

	public SDKIAPTask _003C_003EiFixBaseProxy_get_Task()
	{
		return SDKIAPTask.None;
	}

	public string _003C_003EiFixBaseProxy_IdentifySelf()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_Start()
	{
	}

	public void _003C_003EiFixBaseProxy_Succeed()
	{
	}

	public void _003C_003EiFixBaseProxy_Fail()
	{
	}

	public new void _003C_003EiFixBaseProxy_Destroy()
	{
	}
}
