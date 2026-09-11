using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudMapThrowerUseBtnController : UIBaseController
{
	public static float MapThrowerMaxDragDis;

	private static float MapThrowerMaxDragDisSquare;

	private static float MapThrowerQuickDragDis;

	private static float MapThrowerQuickDragDisSquare;

	private static float MapThrowerCancelRadius;

	private static float MapThrowerCancelRadiusSquare;

	private UIHudMapThrowerUseBtnView m_View;

	private EMapThrowerInteracteType m_InteracteType;

	private CIJPLNEAIIH m_LastPhase;

	private VisualInstanceHolder m_UIFXHolder;

	private float m_OfffsetX;

	private bool m_IsPressed;

	private float m_PressTime;

	private Vector3 m_MapThrowerBtnOriginalPos;

	private Vector3 m_MapThrowerBtnStartPos;

	private Vector3 m_MapThrowerBtnPressPos;

	private Vector3 m_CurDirection;

	private Camera m_Camera;

	private bool m_GlobalTouchEnd;

	private List<GameObject> m_CircleList;

	private List<UISprite> m_ItemSpriteList;

	private Dictionary<uint, int> m_ItemIdToIndex;

	private int m_SelectedCircleIndex;

	private uint m_QuickUseMapThrowerItemId;

	private GEventMapThrowerRouletteCtrl m_GEventMapThrowerRouletteCtrl;

	private bool m_CanShowByJoinEmoteFlag;

	private bool m_CanShowByActionBtnFlag;

	private bool m_CanShowByCSShopBtnFlag;

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

	private void Update()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void UpdateAxisTouchingThroughArea()
	{
	}

	private void RefreshTouchThroughAreaEnable()
	{
	}

	private void OnRouletteGlobalTouchEnd(object[] data)
	{
	}

	private void UpdateMapThrowerRoulette()
	{
	}

	private int GetSectorIndexFromDirection(Vector3 direction)
	{
		return 0;
	}

	private void UpdateCircleHighlight(int index)
	{
	}

	private void InitQuickUseMapThrowerItemId()
	{
	}

	private void OnMapThrowerChoose(uint itemId)
	{
	}

	private void RefreshSelectedCircleIndex()
	{
	}

	private void OnMapThrowerBtnClick()
	{
	}

	private void OnQuickUseMapThrower()
	{
	}

	private void OnNewPhaseStarted(object[] data)
	{
	}

	private void RefreshBtnType()
	{
	}

	private void RefreshVisibility()
	{
	}

	private void OnTogetherCsShopConflictShow(bool canShow)
	{
	}

	private void OnActionBtnVisibleChange(bool visible)
	{
	}

	private void OnCSShopBtnVisibleChange(object[] data)
	{
	}

	private void SetJoinEmoteFlagVisibility(bool v)
	{
	}

	private void SetActionBtnFlagVisibility(bool v)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
