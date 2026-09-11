using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponDetailPopController : UIPopupWindowController
{
	private UIWeaponDetailPopView m_View;

	private uint m_WeaponId;

	private uint m_SkinId;

	private WeaponSpecialMode m_WeaponSpecialMode;

	private List<UIWeaponPropertyToggleController> m_ToggleCtrls;

	private List<UIFrontEndPreviewWeaponPropertyItemController> m_pvpPropertyItems;

	private List<WeaponScoreName> m_SortedScoreNames;

	private Dictionary<uint, float> m_DicScoreIDToProperty;

	private const int GOTO_HEIGHT = 30;

	private const int TOPBTN_HEIGHT = 62;

	private const int ORI_BG_WIDTH = 508;

	private const int EXPAND_BG_WIDTH = 840;

	private Vector3 EXPAND_BG_MOVE_DISTANCE;

	private Vector3 CENTER_MOVE_POS;

	private const int EXPAND_LINE_WIDTH = 804;

	private bool m_ShowLeftTable;

	private const float m_HeightSpace = 40f;

	private int m_AdjustWidthDiff;

	private UIRoot m_UIRoot;

	public bool ShowLeftTable => false;

	public uint WeaponId => 0u;

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

	public void SetUIData(uint weaponID)
	{
	}

	private void OnMasteryBtnClick()
	{
	}

	private void OnGloryLeaderBoardBtnClick()
	{
	}

	private void GotoWeaponPractice()
	{
	}

	private void InitUIData()
	{
	}

	private void InitGloryAndMastery()
	{
	}

	private bool RefreshBtnJmpToLadderLeaderboardView()
	{
		return false;
	}

	private void InitInformation()
	{
	}

	private void InitWeaponTag()
	{
	}

	private void InitUpdateHistory()
	{
	}

	private void InitGotoBtn()
	{
	}

	private void InitWeaponProperty()
	{
	}

	private void RefreshSpecialPropertyLabel(WeaponSpecialMode weaponSpecialMode)
	{
	}

	private void InitPvpItems()
	{
	}

	public void ChangeToggleState(uint weaponID)
	{
	}

	public void RefreshWeaponProperty(uint weaponID, uint level = 0u)
	{
	}

	private void RefreshBgAndPos()
	{
	}

	public void SetPositionWithOutLeftTab(Vector3 itemPos)
	{
	}

	public void SetPositionCenter()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
