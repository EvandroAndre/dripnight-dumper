using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIMatchNpc_RewardBoxPrePopWnd : UIPopupWindowController, IBigEventTemplateIdentifier
{
	private UIMatchNpc_RewardBoxPrePopWndView m_View;

	private List<UIStandardItemMiniController> m_rewardCtrlList;

	private UIModelBigEvent_MatchNPC m_ModelMatchNpc;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnSetNavigationController()
	{
	}

	private void RefreshCloseBtnShowState()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void InitRewardBoxPreShow()
	{
	}

	public void SetViewData(uint num_need, List<BaseItemInfo> show_rewardList)
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}
}
