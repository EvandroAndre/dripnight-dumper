using GCommon;
using proto;

namespace COW;

public class UIBigEventTokenMatchResultRewardController : UIBaseController
{
	private UIBigEventTokenMatchResultRewardView m_View;

	private UIModelBigEvent m_ModelBigEvent;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(IngameDropItemInfo dropItemInfo)
	{
	}

	private void ShowTokenState(IngameDropItemInfo dropItemInfo, UISprite tokenSprite, UILabel nameLabel, UILabel addCountLabel, UILabel dailyLabel)
	{
	}

	protected string OnShowHitText(IngameDropItemInfo dropItemInfo, CSSharedItemData shareDesc)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
