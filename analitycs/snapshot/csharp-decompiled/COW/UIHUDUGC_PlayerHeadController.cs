using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGC_PlayerHeadController : UIHudNameBaseController, IUIHUDBaseController
{
	private UIUGCHudHeadView m_View;

	private string m_UGCEntityID;

	private UGCPlayerHeadHudRepItem m_HeadHudRepItem;

	private UGCEntityRepItem m_EntityRepItem;

	private Transform m_TrackObject;

	private Vector3 m_OffsetPos;

	private List<object> m_VisiblePlayers;

	private bool m_ActiveSelf;

	private int m_BarWidth;

	private int m_BarBgWidth;

	private int m_TotalHp;

	private int m_CurrHp;

	private bool m_IsOpenTween;

	private bool m_IsLocalPos;

	private TweenWidth m_HpBarTween;

	private TweenWidth m_AniHpBarTween;

	private Color m_RestoreHpColor;

	private Color m_LoseHpColor;

	private List<GameObject> m_SpacingLines;

	private int m_SpacingHpValue;

	private List<UIWidget> m_MainColorWidgets;

	private List<UIWidget> m_BgColorWidgets;

	private UIRect[] m_AnthorsRects;

	private string m_FollowEntityID;

	private int m_BgAndHpBgWidth;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetEntityID(string entityID)
	{
	}

	public void DestroyEntity()
	{
	}

	private void OnShowStateChangeHandler(bool value)
	{
	}

	private void OnLevelChangeHandler(int value)
	{
	}

	private void RefreshHpBgPos()
	{
	}

	private void OnVisiblePlayersChangeHandler(List<object> list)
	{
	}

	private void OnIsLocalPosHandler(bool value)
	{
	}

	private void OnIsOpenTweenChangeHandler(bool value)
	{
	}

	private void OnCurrentHpChangeHandler(int value)
	{
	}

	private void OnTotalHpChangeHandler(int value)
	{
	}

	private void OnRefreshHPBar(int value, int currHp)
	{
	}

	private float GetTweenDuration(int width)
	{
		return 0f;
	}

	private void OnLineSpacingChangeHandler(int value)
	{
	}

	private void OnOffsetChangeHandler(Vector3 vector)
	{
	}

	private void OnGameObjectAdd(GameObject obj)
	{
	}

	private void OnFollowTargetChangeHandler(string value)
	{
	}

	private void OnWidthChangeHandler(int value)
	{
	}

	private void OnPlayerNameChangeHandler(string value)
	{
	}

	private void OnScaleChangeHandler(Vector3 vector)
	{
	}

	private void OnAlphaChangeHandler(float value)
	{
	}

	private void OnBackGrColorChangeHandler(int value)
	{
	}

	private void OnRestoreHpColorChangeHandler(int value)
	{
	}

	private void OnLoseHpColorChangeHandler(int value)
	{
	}

	private void OnMainColorChangeHandler(int value)
	{
	}

	private void OnRefreshSpacingLine()
	{
	}

	private void OnRefreshActive()
	{
	}

	private bool IsVisiblePlayer(BHGGAEEHJCO playerID)
	{
		return false;
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}
}
