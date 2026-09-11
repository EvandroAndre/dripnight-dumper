using GCommon;

namespace COW;

public class UIEVOGunShareBannerController : UIBaseController
{
	private UIEVOGunShareBannerView m_View;

	private MessageInfo m_Data;

	private UIEvoGunKillCountController m_EvoGunKillCountCtrl;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private int m_WeaponSkinId;

	private string m_Name;

	private int m_Counter;

	private bool m_HasKillCountRight;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnBtnDetailsClick()
	{
	}

	public void SetUIData(MessageInfo info)
	{
	}

	public void UpdateUI()
	{
	}

	public void SetKillCountPanelDepth(int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
