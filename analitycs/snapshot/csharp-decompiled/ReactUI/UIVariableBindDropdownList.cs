using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using UnityEngine;

namespace ReactUI;

public class UIVariableBindDropdownList : UIEventBind
{
	private string paramBinds;

	private string paramCurrentSelected;

	private string paramShowDropDwon;

	private UIVariable m_bindVariable;

	private UIVariable m_curSelVariable;

	private UIVariable m_showDropDownVariable;

	private string eventOnSelectName;

	private SignalDelegateList m_delegateList;

	private List<object> m_allItemData;

	public UIButton BtnShowDropdown;

	public GameObject DropdownPanel;

	public GameObject CurrentItem;

	public GameObject ItemTemplate;

	public UISprite SVBG;

	public UIScrollView ScrollView;

	public UIGrid ItemGrid;

	private bool IsShowing;

	private List<GameObject> m_itemObjects;

	private UIClickMask m_ClickMask;

	private UIWidget m_Widget;

	private ValueData m_ValueData;

	public Transform Transform => null;

	public Vector2 Size => default(Vector2);

	public UIWidget Widget => null;

	public ValueData ValueData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void BindVariables()
	{
	}

	protected override void UnbindVariables()
	{
	}

	private SignalDelegateList GetDelegateList()
	{
		return null;
	}

	protected override void RefreshBind()
	{
	}

	private void RefreshList()
	{
	}

	public int GetCurrentSelectIndex()
	{
		return 0;
	}

	private void HideDropPanel()
	{
	}

	private void RefreshSelect()
	{
	}

	private void OnVariableInit()
	{
	}

	private void RefreshListInfinite()
	{
	}

	private new void Awake()
	{
	}

	private void Start()
	{
	}

	private new void OnDestroy()
	{
	}

	public void BuildDropdownUI()
	{
	}

	private void ShowOptsData()
	{
	}

	private void HideDropDownItems()
	{
	}

	public void OnSelectItem(int dataIndex)
	{
	}

	private void SetHLItem()
	{
	}

	public void SetValue(string value)
	{
	}

	private void UpdateWidgetSize()
	{
	}
}
