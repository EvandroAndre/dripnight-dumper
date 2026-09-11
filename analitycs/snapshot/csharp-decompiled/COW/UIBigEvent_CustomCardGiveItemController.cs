using GCommon;

namespace COW;

public class UIBigEvent_CustomCardGiveItemController : UIBigEvent_CustomCardBaseItemController
{
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override string GetCdnUrl(CustomCard_CardData card_data)
	{
		return null;
	}

	protected override void OnClickComfirmBtn()
	{
	}

	protected override void OnPlayerOnlineStateCallback(BaseProfileInfo account_info)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public string _003C_003EiFixBaseProxy_GetCdnUrl(CustomCard_CardData P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnClickComfirmBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlayerOnlineStateCallback(BaseProfileInfo P0)
	{
	}
}
