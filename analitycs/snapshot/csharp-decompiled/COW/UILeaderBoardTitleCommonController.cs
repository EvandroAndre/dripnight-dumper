using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILeaderBoardTitleCommonController : UIBaseController
{
	private UILeaderBoardTitleCommonView m_View;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private Action m_Action;

	private Vector3 m_IconScale;

	private UILeaderBoardTitleIconController m_IconCtrl;

	private UIHudBooyahBountyLeaderBoardTitleController m_BooyahBountyTitle;

	private Vector3 m_CommonBtnLocalPos;

	private Vector3 m_TitleCommonLocalPos;

	private const float SCROLL_SHOW_ITEM_TIME = 3f;

	private int m_CurrentScrollShowIndex;

	private uint m_DelayShowNextScrollItem;

	private GameObject m_TitleCommonVFX;

	private VisualInstanceHolder m_TitleCommonVFXHodler;

	private List<GameObject> m_ScrollShowItemList;

	private bool m_HasAddLeadboardAndCommonTitleToScroll;

	private bool m_IsLeaderboardTitle;

	private List<GameObject> ScrollShowItemList => null;

	public bool IsLeaderboardTitle => false;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

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

	private void OnLeaderBoardTitleCommonBtnClick()
	{
	}

	public void SetData(uint rank, string region, string name, ELeaderBoardTitleIconType iconType, Action actionEvent = null, ELeaderBoardTitleIconScale scaleType = ELeaderBoardTitleIconScale.None)
	{
	}

	public void SetData(LeaderBoardTitleShowingParams showParams, Action actionEvent = null, ELeaderBoardTitleIconScale scaleType = ELeaderBoardTitleIconScale.None)
	{
	}

	public void SetBooyahBountyData(string title)
	{
	}

	public void SetTitleData(uint titleId)
	{
	}

	public override void Hide()
	{
	}

	public void AdjustCommonBtnLocalPos()
	{
	}

	public Vector2 GetBGSize()
	{
		return default(Vector2);
	}

	public void SetVFXVisibility(bool isVisible)
	{
	}

	public void PlayLeaderboardCommonAnim()
	{
	}

	public float GetLeadrboardCommonAnimTime()
	{
		return 0f;
	}

	public float GetTitleCommonShowTime()
	{
		return 0f;
	}

	public UIButton GetClickButton()
	{
		return null;
	}

	public void SetView(UILeaderBoardTitleCommonView view)
	{
	}

	public void Init()
	{
	}

	public void SetDataAndIcon(LeaderBoardTitleShowingParams showParams, ELeaderBoardTitleIconScale scaleType = ELeaderBoardTitleIconScale.Icon90)
	{
	}

	private void InitScrollShowItemList()
	{
	}

	private void DelayShowNextScrollItem()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
