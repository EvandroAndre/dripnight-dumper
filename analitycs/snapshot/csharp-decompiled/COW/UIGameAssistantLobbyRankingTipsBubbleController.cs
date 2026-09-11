using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGameAssistantLobbyRankingTipsBubbleController : UIRankingTipsBaseController
{
	private UIGameAssistantLobbyRankingTipsBubbleView m_View;

	public Transform m_AvatarTransform;

	public bool IsInPetLobbyPanel;

	private Camera m_Camera;

	private Vector3 m_AvatarPos;

	private Vector3 m_CameraPos;

	private UIModelGroup m_ModelGroup;

	private UIModelPet m_ModelPet;

	private UIFrontEndScene m_CurrentScene;

	private GameObject m_NoPetVFX;

	private const string MAIN_ANIM_CLIP_DEFAULT = "UIFX_UIGameAssistantLobbyRankingTipsBubble_In_01";

	private const string MAIN_ANIM_CLIP_ACTIVITY_NOTICE = "UIFX_UIGameAssistantLobbyRankingTipsBubble_In_02_5S";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitCommonReference()
	{
	}

	protected override void PlayMainAnimation()
	{
	}

	protected override void SkipActivityNoticeAnimation()
	{
	}

	private void LateUpdate()
	{
	}

	private void RequestHideGameAssistantBubble()
	{
	}

	protected override void RequestRestoreGameAssistantBubble()
	{
	}

	public void UpdateTransform(Func<Vector3> getBubblePos = null)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_PlayMainAnimation()
	{
	}

	public void _003C_003EiFixBaseProxy_SkipActivityNoticeAnimation()
	{
	}

	public void _003C_003EiFixBaseProxy_RequestRestoreGameAssistantBubble()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
