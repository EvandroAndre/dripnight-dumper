using System;
using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIHUDUGC_SceneObjectEntityAttributeEditItemController : UIEasyListItemController
{
	private UIHUDUGC_SceneObjectEntityAttributeEditItemView m_View;

	private IPIFNFDIIKK m_AttributeItemData;

	private List<PopMenuData> m_BoolMenuDataList;

	private UIPopMenuSmallControler m_BoolMenu;

	private bool m_CurrentBoolValue;

	private new int m_Index;

	private string m_Type;

	private int m_BaseDepth;

	private Action m_TypeViewRefreshAction;

	private const string TRUE_KEY = "T_34_M_WS_TRUE";

	private const string FALSE_KEY = "T_34_M_WS_FALSE";

	protected override void OnUIInit()
	{
	}

	private void BindUIActionsOnEUGCTypeName(string typeName)
	{
	}

	private void BindRefreshActionsOnEUGCTypeName(string typeName)
	{
	}

	private void TrySetFloat(ref float field, string input, float defaultValue = 0f)
	{
	}

	private void OnVector2InputXSubmit()
	{
	}

	private void OnVector2InputYSubmit()
	{
	}

	private void OnVector3InputXSubmit()
	{
	}

	private void OnVector3InputYSubmit()
	{
	}

	private void OnVector3InputZSubmit()
	{
	}

	private void OnStandardValueUIInputSubmit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private string GetType(IPIFNFDIIKK data)
	{
		return null;
	}

	public void SetEntityType(string type)
	{
	}

	private void GenerateBoolMenuData()
	{
	}

	private void OnBoolMenuSelected(object obj)
	{
	}

	public void SetBaseDepth(int depth)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshContainer()
	{
	}

	private void _003CBindRefreshActionsOnEUGCTypeName_003Eb__13_0()
	{
	}

	private void _003CBindRefreshActionsOnEUGCTypeName_003Eb__13_1()
	{
	}

	private void _003CBindRefreshActionsOnEUGCTypeName_003Eb__13_2()
	{
	}

	private void _003CBindRefreshActionsOnEUGCTypeName_003Eb__13_3()
	{
	}

	private void _003CBindRefreshActionsOnEUGCTypeName_003Eb__13_4()
	{
	}

	private void _003CBindRefreshActionsOnEUGCTypeName_003Eb__13_5()
	{
	}

	private void _003CBindRefreshActionsOnEUGCTypeName_003Eb__13_6()
	{
	}

	private void _003CBindRefreshActionsOnEUGCTypeName_003Eb__13_7()
	{
	}

	private void _003CBindRefreshActionsOnEUGCTypeName_003Eb__13_8()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
