using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudSceneEditHudTemplateSaveController : UIPopupWindowController
{
	public const string PREF_SKIP_HUD_TEMPLATE_SECOND_CONFIRM = "UGCHudTemplate_SkipSecondConfirm";

	private UIHudSceneEditHudTemplateSaveView m_View;

	private string m_Name;

	private Texture2D m_CoverTexture;

	private NLNAMPBAGDC m_HudData;

	private UISceneEditGameScene m_Scene;

	private UIModelUGCHudEdit m_Model;

	private UISecondConfirmContoller m_SecondConfirmCtrl;

	private bool m_SkipSecondConfirm;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(NLNAMPBAGDC hudData, Texture2D imageTexture)
	{
	}

	private void OnNameReset()
	{
	}

	private void OnNameSubmit()
	{
	}

	private void OnBtnCreate()
	{
	}

	private void ShowSecondConfirmDialog()
	{
	}

	private void OnSecondConfirmConfirm()
	{
	}

	private void OnSecondConfirmCancel()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
