using GCommon;
using UnityEngine;

namespace COW;

public class UIEVOGunSharePreviewWindowController : UIPreviewPopUpWindowController
{
	private UIEVOGunSharePreviewWindowView m_View;

	private ulong m_AccountId;

	private int m_WeaponSkinId;

	private string m_Name;

	private int m_Counter;

	private bool m_HasKillCountRight;

	private UIBaseProfileInfoController m_ProfileCtrl;

	private UIEvoGunKillCountController m_EvoGunKillCountCtrl;

	private GameObject m_VFX;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public void SetUIData(ulong id, int skinId, string name, int counter, bool hasKillCountRight)
	{
	}

	public void UpdateUI()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void UpdateProfileInfo()
	{
	}

	private void OnRequestAccountInfoFinish(object[] data)
	{
	}

	private void RefreshView()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
