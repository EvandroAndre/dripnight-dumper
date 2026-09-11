using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIRecruitPopMenuController : UIPopMenuSmallControler
{
	private new UIRecruitPopMenuView m_View;

	public Action MaskClickAction;

	private List<UIRecruitPopMenuItemController> m_UIRecruitPopMenuItemControllerList;

	private UIBRRankIconController m_BRRankIconController;

	private const uint DefaultLabelColor = 707736063u;

	private int m_SelectBRRank;

	private bool m_IsBR;

	private bool m_IsCSPeak;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void InitPopMenu(Action injectDataListAction, ResourceID spriteRes, string Text, PopUpStyle style = PopUpStyle.Down, int cellWidth = 260, float maxShowCount = 4.5f, bool enable = true, string openBtnSpriteOverride = "", string arrUpSpriteOverride = "", string arrDownSpriteOverride = "", bool useOverrideColor = false, uint labelColor = 707736063u, UILabel.Modifier modifier = UILabel.Modifier.ToUppercase, string arrBgSpriteOverrid = "", string arrColorOverride = "", int popMenuItemWidth = 0, NGUIText.Alignment alignment = NGUIText.Alignment.Automatic, string spriteName = "", uint arrBgColor = 3654866687u, uint openBtnSpriteColorOverride = 4294967218u, bool changePosOnlyInFirstTime = false)
	{
	}

	public void SetGreyState(bool set)
	{
	}

	public void SetSelectBRRank(int rank, bool isBR = false, bool isCSPeak = false)
	{
	}

	public override void UpdateSelectDataInfo(ResourceID spriteRes, string Text = "", string spritename = "")
	{
	}

	protected override void SetStyle(PopUpStyle style, int cellWidth = 260, int popMenuItemWidth = 0, string openBtnSpriteOverride = "", string arrUpSpriteOverride = "", string arrDownSpriteOverride = "", bool useOverrideColor = false, uint labelColor = 707736063u, string arrBgSpriteOverride = "", string arrColor = "", uint arrBgColor = 3654866687u, uint openBtnSpriteColorOverride = 4294967218u, bool changePosOnlyInFirstTime = false)
	{
	}

	private void OverrideSprite(UISprite sprite, string name)
	{
	}

	public void OnMaskClick()
	{
	}

	public override void ShowPopUpItem()
	{
	}

	public override void OnClickeMenuItem(PopMenuData data)
	{
	}

	public override void SetCurrentSelectData(PopMenuData data)
	{
	}

	protected override void OnPopMenuClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitPopMenu(Action P0, ResourceID P1, string P2, PopUpStyle P3, int P4, float P5, bool P6, string P7, string P8, string P9, bool P10, uint P11, UILabel.Modifier P12, string P13, string P14, int P15, NGUIText.Alignment P16, string P17, uint P18, uint P19, bool P20)
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateSelectDataInfo(ResourceID P0, string P1, string P2)
	{
	}

	public void _003C_003EiFixBaseProxy_SetStyle(PopUpStyle P0, int P1, int P2, string P3, string P4, string P5, bool P6, uint P7, string P8, string P9, uint P10, uint P11, bool P12)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowPopUpItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickeMenuItem(PopMenuData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetCurrentSelectData(PopMenuData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopMenuClose()
	{
	}
}
