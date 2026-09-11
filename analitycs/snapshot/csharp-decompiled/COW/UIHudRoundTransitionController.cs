using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudRoundTransitionController : UIBaseController
{
	private UIHudRoundTransitionView m_View;

	private UIModelMatch m_ModelMatch;

	private List<GameObject> m_BonusItemList;

	private IJEECINPHFI mGame;

	private int m_ScoreCached;

	private float m_Time;

	private bool m_ScoreAnimTick;

	private bool m_IsSetSelfTeamInfo;

	private bool m_IsSetOppoTeamInfo;

	private int m_LocalPlayerTeamId;

	private Vector3 m_DefaultBonusLableOffset;

	private uint m_DelayCallFeedbackIcon;

	private uint m_DelayCallFeedbackIconHide;

	private const float FEEDBACK_ICON_DEALYLONG = 1.8f;

	private const float FEEDBACK_ICON_DEALY = 0.1f;

	private VictoryPlayState m_PlayStatev;

	private bool m_ShowMedals;

	private uint[] m_GroupMedals;

	private List<UIHUDFeedbackGroupItemController> m_ItemPool;

	private List<string> feedbackItems;

	private Color m_baseColor;

	private UIHudFeedbackPopOverController m_PopOverCtrl;

	private GameObject m_TreasureHuntGiftTip;

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

	private void DebugLog(string msg)
	{
	}

	private void onStackFeedbackShowHide(bool value)
	{
	}

	private void PlayVictoryFeedback()
	{
	}

	private void StartPlayDelay()
	{
	}

	private void DelayShowFeedback()
	{
	}

	private void SetFeedbackView()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void HideVicotryRoot()
	{
	}

	private void Update()
	{
	}

	private void OnEarnedCoinChanged(object[] data)
	{
	}

	private void SetUIData()
	{
	}

	public void SetBonusDetailsView(FHCKGNCNMCA res)
	{
	}

	private string GetDescriptionOfBonusType(NALFNCKIBNP bonusType)
	{
		return null;
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private void ShowScores()
	{
	}

	private void ResetScoreAnimation()
	{
	}

	private void OnLocalPlayerJoin(object[] data)
	{
	}

	private void OnFactionIDChanged(object[] data)
	{
	}

	private void OnNewPhaseEnter(object[] data)
	{
	}

	private void RfreshChangeSideNode()
	{
	}

	private void OnMatchPoint(object[] data)
	{
	}

	private void RefreshMatchPointNode()
	{
	}

	private void OnAnimEventGridReposition(object[] data)
	{
	}

	private void OnAnimEventShowMatchPoint(object[] data)
	{
	}

	private void OnAnimEventShowLastRound(object[] data)
	{
	}

	private void OnTransitionAppear(object[] data)
	{
	}

	private void OnShowRound(object[] data)
	{
	}

	private void OnGameZoneIndexChanged(object[] data)
	{
	}

	private void OnPlayerJoin(object[] data)
	{
	}

	private void OnObserveredPlayerJoin(BHGGAEEHJCO playerID)
	{
	}

	private bool IsTeamOnLeft(BHGGAEEHJCO pId)
	{
		return false;
	}

	private void ShowGroupMedals(List<byte> groupMedals)
	{
	}

	private UIHUDFeedbackGroupItemController GetFeedBackItem()
	{
		return null;
	}

	private void OnItemShow(int index)
	{
	}

	private void OnItemFinish()
	{
	}

	private void SetVictoryStyle(bool value)
	{
	}

	private void OnShowFeedbackEndIcon()
	{
	}

	private void OnMatchEndV()
	{
	}

	private void RefreshUISkinChange()
	{
	}

	private void OnShowTreasureHuntGiftTip()
	{
	}

	private void _003CDelayShowFeedback_003Eb__24_0()
	{
	}

	private void _003COnItemFinish_003Eb__57_0()
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
