using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using message;

namespace COW;

public class UIHudSceneEditTemplateUploadController : UIPopupWindowController
{
	private UIHudSceneEditTemplateUploadView m_View;

	private KCJDEKIJAKH m_Data;

	private Action m_Callback;

	private string m_Name;

	private string m_Desc;

	private string m_Path;

	private EShopMainCategory m_MainCategory;

	private int m_CategoryId;

	private List<string> m_TipsPublic;

	private List<string> m_TipsModification;

	private UIPopMenuSmallControler m_CategoryMenuCtrl;

	private List<PopMenuData> m_CategoryDataList;

	private const int OBJECT_CATEGORY = 10001;

	private const int DROP_LIST_WIDTH = 428;

	private const int NAME_MIN_LENGTH = 3;

	private const int NAME_MAX_LENGTH = 20;

	private HNDHJGJILHC m_Game;

	private UISceneEditGameScene m_Scene;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(KCJDEKIJAKH templateData, string templateFilePath, Action action = null)
	{
	}

	private void RefreshEditState(LLOFDJACPEJ templateType)
	{
	}

	private void GenerateCategoryMenuData()
	{
	}

	private void OnCategorySelected(object obj)
	{
	}

	private void OnNameReset()
	{
	}

	private void OnNameSubmit()
	{
	}

	private void OnDescReset()
	{
	}

	private void OnDescSubmit()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnBtnUploadClick()
	{
	}

	private void OnTipsPublicClick()
	{
	}

	private void OnTipsModificationClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
