using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudInvUpgradeInfoPanelController : UIBaseController
{
	private const int MAX_COMPLETE_GEM_COUNT = 3;

	private const int MAX_FRAG_GEM_COUNT = 2;

	private const int MAX_UPGRADE_LEVEL_COUNT = 5;

	private UIHudInvUpgradeInfoPanelView m_View;

	private InGameLevelUpgradeManager m_InGameLevelUpgradeManager;

	private List<UISprite> m_CompleteGemSpriteList;

	private List<UIButton> m_CompleteGemButtonList;

	private List<UISprite> m_FragGemSpriteList;

	private List<UIButton> m_FragGemButtonList;

	private List<UIHudInvUpgradeItemController> m_UpgradeItemControllers;

	private bool m_BRUpgradeSysOpen;

	private bool m_HasShowTutorial;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void CheckAndShowTutorial()
	{
	}

	private void InitUpgradeSource()
	{
	}

	private void OnCompleteGemButtonClicked()
	{
	}

	private void OnFragGemButtonClicked()
	{
	}

	private void InitUpgradeLine()
	{
	}

	private void OnUpgradeLevelChanged(int level)
	{
	}

	private void OnUpgradeCurLevelGenChanged(int gen)
	{
	}

	private void _003CCheckAndShowTutorial_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
