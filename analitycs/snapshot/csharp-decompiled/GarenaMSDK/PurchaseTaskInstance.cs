namespace GarenaMSDK;

internal class PurchaseTaskInstance : SDKIAPTaskInstance
{
	protected enum PendingPhase
	{
		Pending
	}

	public string ProductIdentifier;

	public int Quantity;

	protected PendingPhase Phase;

	public bool IsOfferPersonalized;

	protected SDKIAP_Android.TransactionInfo TransactionInfo;

	public PurchaseTaskInstance(SDKIAPTaskInfo info)
		: base(null)
	{
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

	protected static bool? GetAndroidPaymentResult(SDKIAP_Android.TransactionInfo transactionInfo, out ErrorCode errorCode, out string errorMessage)
	{
		errorCode = default(ErrorCode);
		errorMessage = null;
		return null;
	}

	protected override void Destroy()
	{
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

	public void _003C_003EiFixBaseProxy_Destroy()
	{
	}
}
