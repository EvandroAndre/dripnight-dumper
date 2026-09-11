using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGameAssistantLobbyBubbleController : UIBaseController
{
	public Transform m_AvatarTransform;

	public bool IsInPetLobbyPanel;

	private UIModelGameAssistantIntroduction m_ModelGameAssistantIntroduction;

	private UIModelPet m_ModelPet;

	private UIModelRankingTips m_ModelRankingTips;

	private UIGameAssistantLobbyBubbleView m_View;

	private UIGameAssistantLobbyBubbleInGameView m_ViewInGame;

	private GameObject m_NoSpriteVFX;

	private Camera m_Camera;

	private Vector3 m_AvatarPos;

	private Vector3 m_CameraPos;

	private float m_CameraRotationY;

	private const float AMPLITUDE = 0.2f;

	private const float MIN_SCALE_DEGREE = 40f;

	private const float DEGREE_OFFSET = 140f;

	private static readonly float SCALE_OFFSET;

	private const string TODAY_BATTLE_REPORT_BUBBLE_LOC_KEY = "T_54_TSY_NEWHELPER_TIPS";

	private ELobbyAssistDataType m_CurAssistBubbleType;

	private ELobbyAssistDataType m_PrevAssistBubbleType;

	private ELobbyAssistDataType m_LastRenderedAssistBubbleType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void LateUpdate()
	{
	}

	private void InjectComponentsFromView()
	{
	}

	private void ShowAssistWnd()
	{
	}

	private void OnLobbyEntryClick()
	{
	}

	private void OnLobbyTextBubbleClick()
	{
	}

	private void OnPetPanelEntryClick()
	{
	}

	private void OnTodayBattleReportBubbleClick()
	{
	}

	public void SetViewData(ELobbyAssistDataType curBubbledata, bool needAdjustBubbleSprite)
	{
	}

	public void RefreshView()
	{
	}

	private void RefreshBubbleIcon()
	{
	}

	private bool ShouldKeepTodayBattleReportTextBubble()
	{
		return false;
	}

	private void LogBubbleShow(string style)
	{
	}

	private void LogTodayBattleReportBubbleClick()
	{
	}

	private string GetTodayBattleReportBubbleSourceName(TodayBattleReportBubbleSource source)
	{
		return null;
	}

	private void SetBubbleSprite(bool needAdjustBubbleSprite)
	{
	}

	public void UpdateTransform(Func<Vector3> getBubblePos = null)
	{
	}

	private void InitUIState()
	{
	}

	private void ProcessNoPetVFX()
	{
	}

	private static float CalculateScaleValue(float degree)
	{
		return 0f;
	}

	public void PlayNewMessageVFX()
	{
	}

	public void StopNewMessageVFX()
	{
	}

	public void PlayEntryVFX()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void ForceHide()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
