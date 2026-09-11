using System;

namespace GarenaMSDK;

internal class ObtainPendingTransactions : SDKIAPTaskInstance
{
	private SDKIAP.ObtainPendingTransactionsResult _result;

	public Action<SDKIAPTaskInfo, SDKIAP.ObtainPendingTransactionsResult> OnObtained;

	public override SDKIAPTask Task => SDKIAPTask.None;

	public ObtainPendingTransactions(SDKIAPTaskInfo info)
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

	private void OnObtainPendingTransactionsResult(SDKIAP.ObtainPendingTransactionsResult result)
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

	internal override string IdentifySelf()
	{
		return null;
	}

	private void _003CSucceed_003Eb__8_0(ObtainPendingTransactions i)
	{
	}

	private void _003CFail_003Eb__9_0(ObtainPendingTransactions i)
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

	public void _003C_003EiFixBaseProxy_Fail()
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
