using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPopMenuSmallControler : UIBaseController, UIPopMenuInterface
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<PopMenuData> _003C_003E9__40_0;

		internal bool _003CSetPopViewData_003Eb__40_0(PopMenuData item)
		{
			return false;
		}
	}

	protected UIPopMenuSmallView m_View;

	public Action DataInject;

	private Action m_OnPopMenuCloseCallback;

	private Action m_OnPopMenuOpenCallback;

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

	private NGUIText.Alignment m_Alignment;

	private bool m_AdjustDepthOnShow;

	private const uint DefaultLabelColor = 707736063u;

	protected const uint DefaultOpenBtnSpriteColor = 4294967218u;

	protected const uint DefaultArrBgColor = 3654866687u;

	protected bool m_HasSubMenu;

	protected bool m_AnsweredBySubMenu;

	protected UIPopMenuSmallControler m_CascadeCtrl;

	protected uint m_SubMenuSelected;

	private float m_TitlePicScale;

	private bool isAdjusted;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public virtual void InitPopMenu(Action injectDataListAction, ResourceID spriteRes, string Text, PopUpStyle style = PopUpStyle.Down, int cellWidth = 260, float maxShowCount = 4.5f, bool enable = true, string openBtnSpriteOverride = "", string arrUpSpriteOverride = "", string arrDownSpriteOverride = "", bool useOverrideColor = false, uint labelColor = 707736063u, UILabel.Modifier modifier = UILabel.Modifier.ToUppercase, string arrBgSpriteOverrid = "", string arrColorOverride = "", int popMenuItemWidth = 0, NGUIText.Alignment alignment = NGUIText.Alignment.Automatic, string spriteName = "", uint arrBgColorOverride = 3654866687u, uint openBtnSpriteColorOverride = 4294967218u, bool changePosOnlyInFirstTime = false)
	{
	}

	public virtual void SetPanelDepth(int depth)
	{
	}

	public void SetPanelDepth(int depth, int deltaDepth)
	{
	}

	public virtual int GetPanelDepth()
	{
		return 0;
	}

	public virtual void SetEnable(bool enable)
	{
	}

	public virtual void SetOpenBtnEnable(bool enable)
	{
	}

	public virtual void UpdateSelectDataInfo(ResourceID spriteRes, string Text = "", string spritename = "")
	{
	}

	public void SetTitleIconScale(float scale)
	{
	}

	protected virtual void SetStyle(PopUpStyle style, int cellWidth = 260, int popMenuItemWidth = 0, string openBtnSpriteOverride = "", string arrUpSpriteOverride = "", string arrDownSpriteOverride = "", bool useOverrideColor = false, uint labelColor = 707736063u, string arrBgSpriteOverride = "", string arrColor = "", uint arrBgColor = 3654866687u, uint openBtnSpriteColorOverride = 4294967218u, bool changePosOnlyInFirstTime = false)
	{
	}

	private void OverrideSprite(UISprite sprite, string name)
	{
	}

	protected virtual void AdjustScrollView(bool changePosOnlyInFirstTime = false)
	{
	}

	public virtual void SetPopViewData(List<PopMenuData> dataList)
	{
	}

	protected void GenerateSubMenuData()
	{
	}

	public UIWidget GetBGPanel()
	{
		return null;
	}

	public virtual void OnParentSelect(object obj)
	{
	}

	public void SetPosition(Vector3 itemPos)
	{
	}

	public void HideMainPart()
	{
	}

	protected virtual bool CallDataInject()
	{
		return false;
	}

	public virtual void ShowPopUpItem()
	{
	}

	public void Retract()
	{
	}

	public virtual void OnClickeMenuItem(PopMenuData data)
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

	public void RefreshArrDownType(bool enable)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetOnPopMenuOpenCallback(Action callback)
	{
	}

	public void SetOnPopMenuCloseCallback(Action callback)
	{
	}

	protected virtual void OnPopMenuClose()
	{
	}

	public void SetTitleAutoScroll(int width)
	{
	}

	public void SetAutoScrollPanelDepth(int depth)
	{
	}

	public void SetAdjustDepthOnShow(bool isAdjustDepthOnShow)
	{
	}

	public void CloseArrBG()
	{
	}

	public void UpdatePopupStyle(PopUpStyle style)
	{
	}

	public void SetTypeIcon(Color color, bool isShowTypeIcon = false, int titleLeftAnchor = 0)
	{
	}

	private bool _003CGenerateSubMenuData_003Eb__41_0(PopMenuData temp)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
