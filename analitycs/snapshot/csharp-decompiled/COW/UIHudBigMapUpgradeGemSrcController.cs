using GCommon;

namespace COW;

internal class UIHudBigMapUpgradeGemSrcController : UIBaseController
{
	private const int MAX_COMPLETE_GEM_COUNT = 3;

	private const int MAX_FRAG_GEM_COUNT = 2;

	private const string DESC_LABEL_TEMPLATE = "{0}:[959595]{1}[-]";

	private UIHudBigMapUpgradeGemSrcView m_View;

	private InGameLevelUpgradeManager m_InGameLevelUpgradeManager;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitUI()
	{
	}

	private string GetDetailDesc(InGameLevelUpgradeSource gemSrcData)
	{
		return null;
	}

	private void InitState()
	{
	}

	private void OnShowBtnClick()
	{
	}

	private void OnHideBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
