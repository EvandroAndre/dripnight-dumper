using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIModeSettingAttributeItemController : UIEasyListItemController
{
	public delegate void EditDel(int index);

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public UIModeSettingAttributeItemController _003C_003E4__this;

		public string name;

		internal void _003COnNameInputSubmit_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_1
	{
		public string originalName;

		public _003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals1;

		internal void _003COnNameInputSubmit_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public UIModeSettingAttributeItemController _003C_003E4__this;

		public MHJLOKOOGNB valueType;

		internal void _003COnMenuSelected_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_1
	{
		public MHJLOKOOGNB originalType;

		public _003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals1;

		internal void _003COnMenuSelected_003Eb__1()
		{
		}
	}

	private UIModeSettingAttributeItemView m_View;

	private IBILCDHHNHM m_AttributeItemData;

	private AOKBGKNKKLJ m_EntityAttributeData;

	private UIPopMenuSmallControlerForScrollPanel m_AttributeTypeMenu;

	private UIPopMenuSmallControlerForScrollPanel m_BoolMenu;

	private List<PopMenuData> m_TypeMenuDataList;

	private Dictionary<int, Action> m_ValueTypeInitActions;

	private Dictionary<string, Action> m_TypeViewRefreshActions;

	private List<PopMenuData> m_BoolMenuDataList;

	private MHJLOKOOGNB m_CurTypeMenu;

	private bool m_CurrentBoolValue;

	private int m_BaseDepth;

	private int m_Width;

	private const int m_OffsetDepth = 10;

	private new int m_Index;

	private const string INPUT_NAME_EMPTY_TIP_KEY = "T_34_M_WS_ENTERNAME";

	private const string INPUT_STRING_EMPTY_TIP_KEY = "T_34_M_WS_PLAESEENTERCONTENT";

	private const string TRUE_KEY = "T_34_M_WS_TRUE";

	private const string FALSE_KEY = "T_34_M_WS_FALSE";

	public EditDel Redefine;

	protected override void OnUIInit()
	{
	}

	private void BindActions()
	{
	}

	private void OnClickDel()
	{
	}

	private void OnNameInputSubmit()
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

	public override void SetViewData(object data, int data_index)
	{
	}

	private void GenerateMenuData()
	{
	}

	private void AddTypeMenuData(MHJLOKOOGNB type)
	{
	}

	private void RegisterInitAction(int type, Action onSelectAction)
	{
	}

	private void RegisterRefreshAction(string type, Action onRefreshAction)
	{
	}

	private void GenerateBoolMenuData()
	{
	}

	private string GetLabelByValueType(MHJLOKOOGNB type)
	{
		return null;
	}

	private void OnMenuSelected(object obj)
	{
	}

	private void OnBoolMenuSelected(object obj)
	{
	}

	public void SetEntityAttribute(AOKBGKNKKLJ data)
	{
	}

	public void SetDepth(int depth)
	{
	}

	public void SetWidth(int width)
	{
	}

	public void SetScrollViewRoot(Transform root)
	{
	}

	private void RefreshContainer()
	{
	}

	private void RefreshView()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnAutoSaveToggleClick()
	{
	}

	private bool IsPlayerComponent()
	{
		return false;
	}

	private int GetCurrentAutoSaveCount()
	{
		return 0;
	}

	private void OnDataChange()
	{
	}

	private void _003CBindActions_003Eb__22_0()
	{
	}

	private void _003CBindActions_003Eb__22_1()
	{
	}

	private void _003CBindActions_003Eb__22_2()
	{
	}

	private void _003CBindActions_003Eb__22_3()
	{
	}

	private void _003CBindActions_003Eb__22_4()
	{
	}

	private void _003CBindActions_003Eb__22_5()
	{
	}

	private void _003CBindActions_003Eb__22_6()
	{
	}

	private void _003CBindActions_003Eb__22_7()
	{
	}

	private void _003CBindActions_003Eb__22_8()
	{
	}

	private void _003CBindActions_003Eb__22_9()
	{
	}

	private void _003CBindActions_003Eb__22_10()
	{
	}

	private void _003CBindActions_003Eb__22_11()
	{
	}

	private void _003CBindActions_003Eb__22_12()
	{
	}

	private void _003CBindActions_003Eb__22_13()
	{
	}

	private void _003CBindActions_003Eb__22_14()
	{
	}

	private void _003CBindActions_003Eb__22_15()
	{
	}

	private void _003CBindActions_003Eb__22_16()
	{
	}

	private void _003CBindActions_003Eb__22_17()
	{
	}

	private void _003CBindActions_003Eb__22_18()
	{
	}

	private void _003CBindActions_003Eb__22_19()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
