using GCommon;
using UnityEngine;

namespace COW;

internal class UIEvoGunKillCountController : UIBaseController
{
	private UIEvoGunKillCountView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private ResourceID m_VFXResId;

	private ResourceID m_KillCountVFXResId;

	private GameObject m_VFXObj;

	private GameObject m_KillCountVFX;

	private WeaponSetData m_WeaponSetData;

	private string m_TipsKey;

	private UIDetailTipsController m_TipsCtrl;

	private EKillCountDisplayType m_DisplayType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void ChangeLayer(Transform trans, string targetLayer)
	{
	}

	private void OnTipBtnClick()
	{
	}

	public void SetKillCountView(uint weaponSkinID, uint killCount, SkinOwnAndOpenInfo skinOwnAndOpenInfo = null)
	{
	}

	public void SetKillCountView(uint weaponSkinID, uint killCount, bool hasKillCountRight)
	{
	}

	private void UpdateKillCountView(EKillCountDisplayType displayType, uint killCount)
	{
	}

	public void SetKillCountDepth(int depth)
	{
	}

	private void InstantVFXObj()
	{
	}

	private void DestroyVFXObj()
	{
	}

	public void SetKillCounfVFX()
	{
	}

	private void ProcessKillCountVFX(ResourceID curKillCountVFXResID)
	{
	}

	private void DestroyKillCountVFX()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
