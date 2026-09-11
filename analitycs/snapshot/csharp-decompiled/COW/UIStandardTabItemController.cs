using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardTabItemController : UIEasyListItemController
{
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public UIStandardTabItemController _003C_003E4__this;

		public int index;

		public bool isLock;

		internal void _003CSetSubTabLockState_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public UIStandardTabItemController _003C_003E4__this;

		public int subTabIndex;

		internal void _003CCheckSubTabTipsButton_003Eb__0()
		{
		}
	}

	public const string CLICK_ANIM_NAME = "UIStandardTabItemRemake_Click";

	public const string ENTER_ANIM_NAME = "UIStandardTabItemRemake_In";

	protected UIStandardTabItemView m_View;

	protected StandardTabItemViewData m_Data;

	protected List<UIStandardSubTabItemController> subTabList;

	protected int curSubTabIndex;

	protected int m_MainTabIndex;

	public bool isDrawerOpen;

	public bool isLastUpdateAnim;

	private bool m_NeedToPlayAnim;

	private GameObject m_Selected;

	private GameObject m_UnSelected;

	protected Color unselectArrowColor;

	protected Color selectAndFoldedArrowColor;

	protected Color selectAndUnfoldedArrowColor;

	private List<StandardSubTabItemViewData> m_SubTabDatas;

	private Transform m_Container;

	private Action m_OnSubTabCreated;

	private bool isSelected;

	protected bool m_IsAlwaysShowSubItemTab;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetLastUpdateAnimFlag(bool flag)
	{
	}

	private void Update()
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetFixRectState(bool value)
	{
	}

	public virtual void CheckTagState()
	{
	}

	protected void UpdateArrowState(bool value)
	{
	}

	public void SetSubTabData(List<StandardSubTabItemViewData> subTabDatas, Transform container)
	{
	}

	public void CreateSubTabByDataList()
	{
	}

	protected virtual UIStandardSubTabItemController CreateSubTabItem(Transform container, bool isLastSubTab)
	{
		return null;
	}

	private void UpdateSubTabState(bool value)
	{
	}

	private void InitAlwaysShowSubItemView()
	{
	}

	protected virtual void UpdateExtraSubTabView(bool value)
	{
	}

	public void SelectSubTabByIndex(int index)
	{
	}

	public void SetSubTabLockState(int index, bool isLock)
	{
	}

	public bool GetSubTabItemController(int index, ref UIStandardSubTabItemController ret)
	{
		return false;
	}

	public bool NeedCreateSubTab()
	{
		return false;
	}

	public override void OnItemBtnSelect()
	{
	}

	public virtual void CheckTipButton()
	{
	}

	public void CheckSubTabTipsButton(int subTabIndex)
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public UIButton GetButtonForGuide()
	{
		return null;
	}

	protected virtual void PlayDoubleExpAnim()
	{
	}

	public UIWidget GetWidgetForGuide()
	{
		return null;
	}

	public void InitDrawerTabItem()
	{
	}

	public void ClickGuideToInvokeButton()
	{
	}

	public void UpdateSelectState(bool isSelect, bool needUpdateSubTabState = true)
	{
	}

	public bool CanClick()
	{
		return false;
	}

	public void ExecuteBtnTabItemClick()
	{
	}

	private bool CheckCurSubTabCanClick()
	{
		return false;
	}

	public int GetFirstCanClickTab()
	{
		return 0;
	}

	private void SelectCurSubTabItem()
	{
	}

	protected virtual void OnDrawerTabItemSelect()
	{
	}

	public void SelectCurTabItemWhenSelectSubTab()
	{
	}

	public bool IsNoSubTabItem()
	{
		return false;
	}

	public int GetTabCount()
	{
		return 0;
	}

	public void UpdateLabelText(string text)
	{
	}

	protected virtual void PlayTabItemClickAnimation()
	{
	}

	protected virtual bool HasClickAnim()
	{
		return false;
	}

	public int GetCurSubTabIndex()
	{
		return 0;
	}

	public object GetItemExtrapara()
	{
		return null;
	}

	public virtual void SetCountDownContainer()
	{
	}

	public void StopClickAnimation()
	{
	}

	protected virtual string GetClickAniName()
	{
		return null;
	}

	public bool IsSelected()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
