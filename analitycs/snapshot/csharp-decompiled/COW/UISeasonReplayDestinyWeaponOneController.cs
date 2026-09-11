using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonReplayDestinyWeaponOneController : UIBaseController, IUISeasonReplayItem
{
	private UISeasonReplayDestinyWeaponOneView m_View;

	private UIModelSeasonReplay m_ModelSeasonReplay;

	private UIModelLeaderBoardTitle m_ModelLeaderboardTitle;

	private List<DestinyWeaponData> m_WeaponDatas;

	private UISeasonReplayDestinyWeaponItemController m_ItemCtrl;

	private GameObject m_ItemCameraGo;

	private Camera m_ItemCamera;

	private bool m_IsBR;

	private float m_PreviewItemPosX;

	private uint m_Ticket_SEASONREPLAYDESTINYWEAPONONETITLE_VFX;

	private const string InAnimClip = "UIFX_UISeasonReplayDestinyWeapon_One_In";

	private const string OutAnimClip = "UIFX_UISeasonReplayDestinyWeapon_One_Out";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnAsyncLoadResFinished(uint ticket, bool success, Object obj)
	{
	}

	private void InitInput()
	{
	}

	public void Init(bool isBR)
	{
	}

	public void Selected(bool isFirstEnter)
	{
	}

	public void UnSelected()
	{
	}

	public void HidePreview()
	{
	}

	public void RecoverPreview()
	{
	}

	public void HideView()
	{
	}

	public CombineScreenshotData BeforeCombineShare()
	{
		return default(CombineScreenshotData);
	}

	public void AfterCombineShare()
	{
	}

	public void PrepareControllerBeforeScreenshot()
	{
	}

	public void PlayAnim()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	private void SetUIView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
