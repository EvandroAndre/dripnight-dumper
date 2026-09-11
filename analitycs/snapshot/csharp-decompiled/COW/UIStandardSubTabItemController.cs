using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIStandardSubTabItemController : UIBaseController, ITipsDelegate
{
	protected UIStandardSubTabItemView m_View;

	protected StandardSubTabItemViewData m_Data;

	private int m_Index;

	public UIStandardTabItemController mainTab;

	private List<int> tipList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public virtual void SetViewData(StandardSubTabItemViewData data, int data_index)
	{
	}

	public void RefreshTabName(string tabName)
	{
	}

	public object GetExtraPara()
	{
		return null;
	}

	public virtual void SetExtraView(bool isLast)
	{
	}

	private void OnItemBtnSelect()
	{
	}

	public void UpdateSelectState(bool isSelect)
	{
	}

	public void ExecuteBtnTabItemClick()
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	public bool CanShow()
	{
		return false;
	}

	public bool CanClick(bool notify = false)
	{
		return false;
	}

	public virtual void CheckTagState()
	{
	}

	public virtual void CheckTipButton()
	{
	}

	public void SetLock(bool b)
	{
	}

	public void RegistTipEvent(ETipsType tipType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
