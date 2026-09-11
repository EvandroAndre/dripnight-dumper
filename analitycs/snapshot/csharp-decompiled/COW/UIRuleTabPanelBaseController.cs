using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIRuleTabPanelBaseController : UIBaseController
{
	protected Dictionary<int, IUIRuleBindVar> m_ID2VarBindCtrl;

	protected List<UIEcoSettingShopPanelController> m_UIEcoSettingCtrls;

	public Dictionary<int, IUIRuleBindVar> ID2VarBindCtrl => null;

	public List<UIEcoSettingShopPanelController> UIEcoSettingCtrls => null;

	private void CacheTargetBindCtrl(List<UIBaseController> ctrls)
	{
	}

	public bool ContainsTargetModeVariable(int id)
	{
		return false;
	}

	public virtual void ScrollToTargetUIRuleCtrl(int id)
	{
	}

	public virtual void ScrollToTargetShopCtrl(string shopID)
	{
	}

	public virtual int GetTabIndex()
	{
		return 0;
	}
}
