using GarenaMSDK;

namespace COW;

public class PaymentAction
{
	public SDKIAPTaskInfo Info;

	public string ProductIdentifier;

	public bool IsFirstTime;

	public int Quantity;

	public long RebateID;

	public bool Event;

	public long EventId;

	public bool IsOfferPersonalized;
}
