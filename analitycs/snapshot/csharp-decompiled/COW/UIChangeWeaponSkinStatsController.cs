using System;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIChangeWeaponSkinStatsController : UIBaseController
{
	private UIChangeWeaponSkinStatsView m_View;

	private uint m_ItemID;

	public BLAMIMLKPKG Config;

	public BLAMIMLKPKG NextSkinData;

	public BLAMIMLKPKG ThirdSkinData;

	private EWeaponSkinAppearance m_CurrentState;

	private Action m_FirstBtnClickCallback;

	private Action m_SecondBtnClickCallback;

	private Action m_ThirdBtnClickCallback;

	private uint m_OriginID;

	private const float UNSELECT_ICON_DEFAULT_ALPHA = 0.59f;

	private bool HasSecondSkin => false;

	private bool HasThirdSkin => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnFirstBtnClick()
	{
	}

	private void OnSecondBtnClick()
	{
	}

	private void OnThirdBtnClick()
	{
	}

	public void SetViewData(uint itemID, Action first, Action second, Action third = null)
	{
	}

	public void SetViewData(BLAMIMLKPKG cData, Action first, Action second, Action third)
	{
	}

	public EWeaponSkinAppearance GetCurrentSelectedAppearance()
	{
		return EWeaponSkinAppearance.None;
	}

	public uint GetCurrentSelectedSkinID()
	{
		return 0u;
	}

	public void SetFirstSelected()
	{
	}

	public void SetSecondSelected()
	{
	}

	public void SetThirdSelected()
	{
	}

	public bool IsAllUnSelected()
	{
		return false;
	}

	private void RefreshBG()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
