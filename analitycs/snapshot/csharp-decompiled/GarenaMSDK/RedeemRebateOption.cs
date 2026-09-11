using System;

namespace GarenaMSDK;

internal class RedeemRebateOption : SDKIAPTaskInstance
{
	public int RebateID;

	private SDKIAP.RebateRedeemResult[] _results;

	public Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateRedeemResult[]> OnRedeemed;

	public override SDKIAPTask Task => SDKIAPTask.None;

	public RedeemRebateOption(SDKIAPTaskInfo info)
		: base(null)
	{
	}

	internal override string IdentifySelf()
	{
		return null;
	}

	public sealed override bool IsDuplicateOf(SDKIAPTaskInstance peer)
	{
		return false;
	}

	public sealed override bool CanFinishWith(SDKIAPTaskInstance peer)
	{
		return false;
	}

	protected override void Start()
	{
	}

	private void OnRedeemedRebateOptions(SDKIAP.RebateRedeemResult[] results, ErrorCode errorCode, string errorMessage)
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

	public bool _003C_003EiFixBaseProxy_IsDuplicateOf(SDKIAPTaskInstance P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_CanFinishWith(SDKIAPTaskInstance P0)
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
}
