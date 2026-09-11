using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UISceneEditItemAttributePopMenuV2 : UISceneEditItemAttributeControllerBase, IUISceneEditItemAttributeRefreshView, UIPopMenuInterface
{
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public string selectedStr;

		internal bool _003COnItemSelect_003Eb__0(string x)
		{
			return false;
		}
	}

	private UISceneEditItemAttributePopMenuView m_View;

	public Action DataInject;

	protected PopUpStyle m_Style;

	protected List<PopMenuData> m_DataList;

	protected List<UIPopMenuItemSmallController> m_UIPopMenuItemSmallControllerList;

	protected bool isShowing;

	protected int m_CellWidth;

	protected float m_MaxShowCount;

	protected PopMenuData m_CurrentSelectData;

	protected bool m_Enable;

	public const float SPLITLINE = 0.2f;

	public const int SMALLCELLHEIGHT = 38;

	protected UIClickMask m_UIClickMask;

	private UILabel.Modifier m_Modifier;

	private float withButtonPos;

	private float noButtonPos;

	private float withButtonPopContainerPos;

	private float noButtonPopContainerPos;

	private const uint DefaultLabelColor = 707736063u;

	private List<PopMenuData> m_PopMenuData;

	private string m_TipTxtKey;

	private List<string> m_OptionTxtKey;

	private List<MutableValue> m_OptionValues;

	private int m_CurOptionIndex;

	private Action<int> m_ButtonCallBack;

	private int CurOptionIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitPopMenu(Action injectDataListAction, ResourceID spriteRes, string Text, PopUpStyle style = PopUpStyle.Down)
	{
	}

	public virtual void SetPanelDepth(int depth)
	{
	}

	public virtual int GetPanelDepth()
	{
		return 0;
	}

	public virtual void SetEnable(bool enable)
	{
	}

	public virtual void UpdateSelectDataInfo(ResourceID spriteRes, string Text = "", string spritename = "")
	{
	}

	private void SetStyle(PopUpStyle style)
	{
	}

	public void SetPopViewData(List<PopMenuData> dataList)
	{
	}

	protected virtual bool CallDataInject()
	{
		return false;
	}

	public virtual void ShowPopUpItem()
	{
	}

	private void ShowTips()
	{
	}

	public void OnClickeMenuItem(PopMenuData data)
	{
	}

	private void SetSelectedDataAndClose(object[] data)
	{
	}

	private void SetSelectedParent(object[] data)
	{
	}

	public virtual void SetCurrentSelectData(PopMenuData data)
	{
	}

	public PopMenuData GetCurrentSelectData()
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual void OnPopMenuClose()
	{
	}

	public override void InitShowData(ItemEditAttributeUIData_V2 data)
	{
	}

	private void GeneratePopMenuData()
	{
	}

	private void OnItemSelect(object item)
	{
	}

	private void OnClickFunctionButton()
	{
	}

	public void RefreshView(ItemEditAttributeUIData_V2 data)
	{
	}

	public void SetEditMode(UISceneEditItemAttributeEditMode mode)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_InitShowData(ItemEditAttributeUIData_V2 P0)
	{
	}
}
