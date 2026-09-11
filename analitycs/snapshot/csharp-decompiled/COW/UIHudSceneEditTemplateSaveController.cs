using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTemplateSaveController : UIPopupWindowController
{
	private UIHudSceneEditTemplateSaveView m_View;

	private SceneEditObjectBase m_TemplateObj;

	private string m_Name;

	private List<byte[]> m_Reviews;

	private Texture2D m_CoverTexture;

	private UISceneEditGameScene m_Scene;

	private SceneEditFocus m_Focus;

	private HNDHJGJILHC m_Game;

	private List<string> m_TipsCombine;

	private SceneEditFocus Focus => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(SceneEditObjectBase editObj)
	{
	}

	private void RefreshCover()
	{
	}

	private void RefreshShow()
	{
	}

	private void OnBtnCover()
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

	private void LogExportTemplateBoundingBoxInfo()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnTipsCombineClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
