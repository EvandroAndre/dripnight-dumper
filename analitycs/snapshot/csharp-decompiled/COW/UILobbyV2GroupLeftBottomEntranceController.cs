using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2GroupLeftBottomEntranceController : UIBaseController
{
	private UILobbyV2GroupLeftBottomEntranceView m_View;

	private UIModelUser m_ModelUser;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private string m_BuildIcon;

	private UITipsNormalController m_TeamWeaponSkinTipsCtrl;

	private UITipsNormalController m_TeamLabEntranceCtrl;

	private UITipsNormalController m_TeamBuildSystemTipsCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InjectComponentsFromView()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public void RefreshVaultView()
	{
	}

	public void RefreshWeaponSkinView()
	{
	}

	public void RefreshBuildView()
	{
	}

	private void UpdateLevelEntrance(uint entranceType)
	{
	}

	public void RefreshBuildIcon()
	{
	}

	public void RefreshLabEntranceView()
	{
	}

	private void OnVaultBtnClick()
	{
	}

	private void OnWeaponSkinBtnClick()
	{
	}

	private void OnBuildBtnClick()
	{
	}

	private void OnLabEntranceBtnClick()
	{
	}

	private void OnBtnClickLog(string log)
	{
	}

	public void InitTeamTipsCtrl(ETipsType type, int num)
	{
	}

	private void InitTipsCtrl(ref UITipsNormalController ctrl, Transform trans, TipsIconType iconType, ETipsType eTipsType = ETipsType.None)
	{
	}

	public void RefreshUnlockVFXEntrance(List<LevelEntranceData> list)
	{
	}

	public uint GetLeftButtonGroupActiveEntranceNumber()
	{
		return 0u;
	}

	private bool IsVaultEntranceVisible()
	{
		return false;
	}

	private bool IsWeaponEntranceVisible()
	{
		return false;
	}

	private bool IsBuildEntranceVisible()
	{
		return false;
	}

	private bool IsLabEntranceVisible()
	{
		return false;
	}

	public void SetBgScale(uint number)
	{
	}

	private void RefreshLeftBottomBtnSize()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
