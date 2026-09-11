using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using UnityEngine;

namespace COW;

public class UIMultiPopMenuController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static PopMenuDelegate _003C_003E9__20_0;

		public static PopMenuDelegate _003C_003E9__21_0;

		internal void _003COnChange_003Eb__20_0()
		{
		}

		internal void _003COnClickMenuItem_003Eb__21_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public int curLayer;

		public Predicate<MultiPopMenuListData> _003C_003E9__0;

		internal bool _003CSetData_003Eb__0(MultiPopMenuListData temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public UIMultiPopMenuController _003C_003E4__this;

		public int currentSelectCount;

		public Action<object> _003C_003E9__1;

		internal void _003COnChange_003Eb__1(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public UIMultiPopMenuController _003C_003E4__this;

		public int currentSelectCount;

		public Action<object> _003C_003E9__1;

		internal void _003COnClickMenuItem_003Eb__1(object obj)
		{
		}
	}

	private const float MAX_ITEM_COUNT = 4.5f;

	public const string DEFAULT_LABELSTRING = "TXT_BANNER_NAME_DEFAULT";

	private UIWidget m_Widget;

	private List<UIPopMenuController> m_SubMenus;

	private List<string> m_DecisionContents;

	private List<string> m_TempSelection;

	private Func<Transform, Vector3, UIPopMenuController> m_OnOpenMenu;

	private List<MultiPopMenuData> m_Contents;

	private Vector3 m_StartOffset;

	private Action<List<string>> m_OnChoose;

	private UIMultiPopMenuView m_View;

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickeMask()
	{
	}

	private void OnChoose()
	{
	}

	private void Clear()
	{
	}

	public void SetData(UIWidget widget, Action<List<string>> onChoose, List<MultiPopMenuListData> contents, Vector3 startOffset, [Optional][DefaultParameterValue(true)] bool needDefault, string[] defaultIDs)
	{
	}

	public void SetData(UIWidget widget, Action<List<string>> onChoose, List<MultiPopMenuData> contents, Vector3 startOffset, [Optional][DefaultParameterValue(true)] bool needDefault, string[] defaultIDs)
	{
	}

	private void ModifyStartPosition(Vector3 offset)
	{
	}

	private void OnChange()
	{
	}

	private void OnClickMenuItem(int parentIndex, object data)
	{
	}

	private bool IsInUse(string value)
	{
		return false;
	}

	private List<MultiPopMenuData> GetContent()
	{
		return null;
	}

	private List<string> GetDestString()
	{
		return null;
	}

	private UIPopMenuController _003CSetData_003Eb__18_0(Transform parent, Vector3 offset)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
