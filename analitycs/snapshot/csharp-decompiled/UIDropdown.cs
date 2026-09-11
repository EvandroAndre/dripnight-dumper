using System;
using System.Collections.Generic;
using UnityEngine;

public class UIDropdown : MonoBehaviour
{
	protected internal class UIDropdownItem : MonoBehaviour
	{
		public UILabel Label;

		public UIToggle Toggle;

		public Color SelectColor;

		public UISprite SelectSprite;
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public UIDropdownItem item;

		public int index;

		public UIDropdown _003C_003E4__this;

		internal void _003CShow_003Eb__0()
		{
		}
	}

	public Action<int> onValueChanged;

	private UILabel m_CaptionLabel;

	private UIButton m_Button;

	private GameObject m_ListRoot;

	private UIButton m_Block;

	private Transform m_ItemContent;

	private GameObject m_ItemTemplate;

	private UILabel m_ItemLabel;

	private int m_Value;

	private UISprite m_Arrow;

	private Transform m_ListBottom;

	private Transform m_ListTop;

	private UISprite m_ItemSprite;

	private bool m_ValidTemplate;

	private bool m_InitFinished;

	private bool m_IsExpand;

	private Quaternion m_ArrowInitRot;

	private List<string> m_Options;

	private List<UIDropdownItem> m_Items;

	private bool _003CNeedAdjustPosition_003Ek__BackingField;

	public int Value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool NeedAdjustPosition
	{
		get
		{
			return _003CNeedAdjustPosition_003Ek__BackingField;
		}
		set
		{
			_003CNeedAdjustPosition_003Ek__BackingField = value;
		}
	}

	public void SetOpentions(List<string> options)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void Awake()
	{
	}

	private void OnClickButton()
	{
	}

	private void RefreshShowValue()
	{
	}

	private void Init()
	{
	}

	private void RotateArrow()
	{
	}

	private void SetupTemplate()
	{
	}

	private void InitDropdownItems()
	{
	}
}
