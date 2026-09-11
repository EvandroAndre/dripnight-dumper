using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSkillGrowthController : UIPopupWindowController
{
	private UIHudSkillGrowthView m_View;

	private uint m_Skill2Learn;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void CloseUI(object[] args)
	{
	}

	private PlayerZombieBR GetLocalZombiePlayer()
	{
		return null;
	}

	private void SetView()
	{
	}

	private void SetPlayerLevel()
	{
	}

	private void SetRerandomView()
	{
	}

	private void OnItemSelect(object[] data)
	{
	}

	private void OnPlayerLevelChanged(object[] data)
	{
	}

	private void OnMatchEndV()
	{
	}

	private void OnBtnConfirmClick()
	{
	}

	private void OnBtnRerandomClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
