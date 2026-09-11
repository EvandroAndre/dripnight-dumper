using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_Template_RewardWndController : CommonRewardWindowStyleBaseController
{
	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private uint m_TemplateUseType;

	private UINetworkTexture Background;

	private UINetworkTexture RepurchaseBtnTexture;

	private UINetworkTexture OKBtnTexture;

	private UILabel OKBtnLabel;

	private UINetworkTexture CancelBtnTexture;

	private UILabel CancelBtnLabel;

	private UINetworkTexture OpenBtnTexture;

	private UILabel OpenBtnLabel;

	private UINetworkTexture FastEquipDisableTexture;

	private UINetworkTexture FastEquipNormalTexture;

	private UILabel FastEquipBtnLabel;

	private UINetworkTexture ChooseBtnTexture;

	private UILabel ChooseBtnLabel;

	private UINetworkTexture ExchangeBtnTexture;

	private UILabel ExchangeBtnLabel;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override string GetGuideBtnSpriteName()
	{
		return null;
	}

	protected override string GetNormalBtnSpriteName()
	{
		return null;
	}

	private Color GetGuideBtnLabelColor()
	{
		return default(Color);
	}

	private Color GetNormalBtnLabelColor()
	{
		return default(Color);
	}

	public override Color GetFastEquipDisableColor()
	{
		return default(Color);
	}

	public override void AdjustBtnStyle(bool GuideOnLeft = false)
	{
	}

	private void OnTemplateUIInit()
	{
	}

	private void HideOldBgAndCreateNewBg()
	{
	}

	private void FindLabel()
	{
	}

	private void ReplayUIComponent()
	{
	}

	private UINetworkTexture CopyUISpriteToUINetworkTexture(GameObject go, int width = 0, int height = 0, int depth = 0)
	{
		return null;
	}

	private UINetworkTexture CreateUINetworkTexture(string name, Transform parent, int width = 0, int height = 0, int depth = 0)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public string _003C_003EiFixBaseProxy_GetGuideBtnSpriteName()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetNormalBtnSpriteName()
	{
		return null;
	}

	public Color _003C_003EiFixBaseProxy_GetFastEquipDisableColor()
	{
		return default(Color);
	}

	public void _003C_003EiFixBaseProxy_AdjustBtnStyle(bool P0)
	{
	}
}
