using System;
using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIHUDUGC_ObjectEntityAttributeEditItemController : UIEasyListItemController
{
	public delegate void EditDel(int index);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__21_12;

		internal void _003CBindActions_003Eb__21_12()
		{
		}
	}

	private UIHUDUGC_ObjectEntityAttributeEditItemView m_View;

	private IBILCDHHNHM m_AttributeItemData;

	private AOKBGKNKKLJ m_EntityAttributeData;

	private UIPopMenuSmallControler m_AttributeTypeMenu;

	private UIPopMenuSmallControler m_BoolMenu;

	private Dictionary<int, Action> m_ValueTypeInitActions;

	private Dictionary<string, Action> m_TypeViewRefreshActions;

	private List<PopMenuData> m_TypeMenuDataList;

	private List<PopMenuData> m_BoolMenuDataList;

	private MHJLOKOOGNB m_CurTypeMenu;

	private bool m_CurrentBoolValue;

	public EditDel m_Redefine;

	private int m_BaseDepth;

	private const int m_OffsetDepth = 20;

	private new int m_Index;

	private const string INPUT_NAME_EMPTY_TIP_KEY = "T_34_M_WS_ENTERNAME";

	private const string TRUE_KEY = "T_34_M_WS_TRUE";

	private const string FALSE_KEY = "T_34_M_WS_FALSE";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void BindActions()
	{
	}

	private void RegisterInitAction(int type, Action onSelectAction)
	{
	}

	private void RegisterRefreshAction(string type, Action onRefreshAction)
	{
	}

	public void SetData(AOKBGKNKKLJ data)
	{
	}

	public void SetBaseDepth(int depth)
	{
	}

	private void OnStandardValueUIInputSubmit()
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

	private void OnNameInputSubmit()
	{
	}

	private void GenerateMenuData()
	{
	}

	private void AddTypeMenuData(MHJLOKOOGNB type)
	{
	}

	private void GenerateBoolMenuData()
	{
	}

	private void OnMenuSelected(object obj)
	{
	}

	private void OnBoolMenuSelected(object obj)
	{
	}

	private void RefreshContainer()
	{
	}

	private void RefreshView()
	{
	}

	private void OnClickDel()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private string GetKeyByValueType(MHJLOKOOGNB type)
	{
		return null;
	}

	private void OnDataChange()
	{
	}

	private void _003CBindActions_003Eb__21_0()
	{
	}

	private void _003CBindActions_003Eb__21_1()
	{
	}

	private void _003CBindActions_003Eb__21_2()
	{
	}

	private void _003CBindActions_003Eb__21_3()
	{
	}

	private void _003CBindActions_003Eb__21_4()
	{
	}

	private void _003CBindActions_003Eb__21_5()
	{
	}

	private void _003CBindActions_003Eb__21_6()
	{
	}

	private void _003CBindActions_003Eb__21_7()
	{
	}

	private void _003CBindActions_003Eb__21_8()
	{
	}

	private void _003CBindActions_003Eb__21_9()
	{
	}

	private void _003CBindActions_003Eb__21_10()
	{
	}

	private void _003CBindActions_003Eb__21_11()
	{
	}

	private void _003CBindActions_003Eb__21_13()
	{
	}

	private void _003CBindActions_003Eb__21_14()
	{
	}

	private void _003CBindActions_003Eb__21_15()
	{
	}

	private void _003CBindActions_003Eb__21_16()
	{
	}

	private void _003CBindActions_003Eb__21_17()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
