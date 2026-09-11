using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UISparkPetDialogueLobbyController : UIBaseController
{
	private UISparkPetDialogueLobbyView m_View;

	private Action m_CallBack;

	private ESparkPetDialogueType m_DialogueType;

	private UIModelSparkPet m_ModelSparkPet;

	private const string BG_ACTIVE = "FF_ui_SparkPet_login_01";

	private const string BG_DORMANT = "FF_ui_SparkPet_login_02";

	private const string BG_EXTINGUISHED = "FF_ui_SparkPet_login_03";

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(ESparkPetDialogueType type, string customDialogueText = null)
	{
	}

	public void SetPos(UISparkPetAvatar sparkPet, Camera uiCamera, float screenToUIRatio)
	{
	}

	private Vector3 GetDialogueTopCenterWorld()
	{
		return default(Vector3);
	}

	private Vector3 GetDialogueBottomCenterWorld()
	{
		return default(Vector3);
	}

	private bool HasHorizontalSpaceForCenter(Vector3 worldPosition, Camera uiCamera, float screenToUIRatio)
	{
		return false;
	}

	private bool HasVerticalSpaceAbove(Vector3 worldPosition, Camera uiCamera, float screenToUIRatio)
	{
		return false;
	}

	private void SetDialogueAnchorPosition(Vector3 targetWorldPos, Vector3 currentAnchorWorldPos, Camera uiCamera)
	{
	}

	private void HideAllArrows()
	{
	}

	public void SetCloseAction(Action callBack)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
