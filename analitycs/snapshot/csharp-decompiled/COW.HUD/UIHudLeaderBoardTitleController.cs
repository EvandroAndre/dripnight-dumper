using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

public class UIHudLeaderBoardTitleController : UIHudNameBaseController
{
	private UILeaderBoardTitleCommonView m_View;

	private UILeaderBoardTitleIconController m_IconCtrl;

	private UIPanel m_Panel;

	private bool m_IsAutoShow;

	private bool m_IsLeaderboardTitle;

	private bool m_Alive;

	private BHGGAEEHJCO m_PlayerID;

	private bool m_IsLocalPlayer;

	private Vector3 m_IconOffset;

	private Vector3 m_LeaderBoardTitleCommonBtnLocalPos;

	private Vector3 m_TitleCommonLocalPos;

	private Vector3 m_IconScale;

	private const int m_RegionFontSize = 20;

	private const UILabel.Overflow m_RegionFontOverfolwMethod = UILabel.Overflow.ShrinkContent;

	private UIHudBooyahBountyLeaderBoardTitleController m_BooyahBountyTitle;

	private const float SCROLL_SHOW_ITEM_TIME = 3f;

	private int m_CurrentScrollShowIndex;

	private uint m_DelayShowNextScrollItem;

	private GameObject m_TitleCommonVFX;

	private VisualInstanceHolder m_TitleCommonVFXHodler;

	private List<GameObject> m_ScrollShowItemList;

	private bool m_HasAddLeadboardAndCommonTitleToScroll;

	private List<GameObject> ScrollShowItemList => null;

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

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	private Vector3 GetOffset()
	{
		return default(Vector3);
	}

	private Vector3 GetRefPos(Player p)
	{
		return default(Vector3);
	}

	private void RecycleUI()
	{
	}

	private void SetData(InGameLeaderBoardTitleInfo info, TitleAccountParams titleAccountParams, ELeaderboardTitleShowOrder order)
	{
	}

	private void SetTitleData(uint titleId)
	{
	}

	private void SetBooyahBountyData(string title)
	{
	}

	private void InitScrollShowItemList()
	{
	}

	private void DelayShowNextScrollItem()
	{
	}

	public void BindTarget(BHGGAEEHJCO pId, bool isAutoShow = true, bool isLeaderboardTitle = true)
	{
	}

	public void UnBindTarget()
	{
	}

	public void SetPanelDepth(int depth)
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

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}
}
