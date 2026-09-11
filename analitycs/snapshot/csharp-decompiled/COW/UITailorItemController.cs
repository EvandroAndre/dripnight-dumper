using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UITailorItemController : UIBaseController
{
	private UITailorItemView m_View;

	private UIStandardItemMidController m_MidCtrl;

	private TailorItemInfo m_TailorItemInfo;

	private UIModelTailor m_ModelTailor;

	private uint m_TailorID;

	private TailorSettingDesc m_TailorSettingDesc;

	private List<TailorItemCondition> m_TailorConditionItemList;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetData(TailorItemInfo info, uint tailorID, bool hideHighLight = false)
	{
	}

	private void RefreshView(bool hideHighLight)
	{
	}

	private void HideAllUI(bool hideHighLight)
	{
	}

	private void ShowBaseItemView()
	{
	}

	private void ShowToken()
	{
	}

	private void ShowProgress()
	{
	}

	private void ShowEquip()
	{
	}

	private void ShowTips()
	{
	}

	private void OnBtnClick()
	{
	}

	private void OnTailorItemClick(object[] data)
	{
	}

	private void OnTailorEquipCloth(object[] data)
	{
	}

	private void OnShowUnlockEffect(object[] data)
	{
	}

	public void ShowGuideEffect()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
