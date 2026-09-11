using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIWeaponTTKGameController : UIPopupWindowController
{
	private UIWeaponTTKGameView m_View;

	private UIPopMenuSmallControler m_VestMenuCtr;

	private UIPopMenuSmallControler m_HelmetMenuCtr;

	private UIPopMenuSmallControler m_MoveTypeMenuCtr;

	private string m_VestLevel;

	private string m_HelmetLevel;

	private string m_MoveType;

	private Dictionary<string, uint> VestDict;

	private Dictionary<string, uint> HelmetDict;

	private bool isChangeTargetSkills;

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

	private void Update()
	{
	}

	private void StopRecord()
	{
	}

	private void Record()
	{
	}

	private void Replay()
	{
	}

	private void StartReplay()
	{
	}

	private void Return()
	{
	}

	public void ShowSettings(bool show)
	{
	}

	private void ReloadWeapon()
	{
	}

	private void ReloadWeaponSkin()
	{
	}

	private void ShowSkillBuild()
	{
	}

	private void ShowTargetSkillBuild()
	{
	}

	private void ShowAttackerSkillBuild()
	{
	}

	private void OnSkillIdsChanged(object[] data)
	{
	}

	private void Confirm()
	{
	}

	private void ResetPlayerAndTarget()
	{
	}

	private void Save()
	{
	}

	private void InitPopMenu()
	{
	}

	private void OnVestPopupClick()
	{
	}

	private void OnVestSelected(object obj)
	{
	}

	private void OnHelmetPopupClick()
	{
	}

	private void OnHelmetSelected(object obj)
	{
	}

	private void OnMoveTypePopupClick()
	{
	}

	private void OnMoveTypeSelected(object obj)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
