using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIMatchNpc_RewardWndController : UIPopupWindowController, IBigEventTemplateIdentifier
{
	private UIMatchNpc_RewardWndView m_View;

	private List<UIStandardItemMAXBController> m_RewardItemCtrl;

	private UIModelBigEvent_MatchNPC m_ModelMatchNpc;

	private BigEventMatchNpcRewardBoxClass m_RewardBoxInfo;

	private uint m_RewardProcessAmount;

	private bool m_ClaimedRepeat;

	private const int MAX_ITEM_COUNT = 5;

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

	private void InitTitleAndBGCdn()
	{
	}

	public void InitRewardItem(AutoOpenIntegrationData autoOpenIntegrationData, uint process_amount = 0u, bool claimSpecial = false)
	{
	}

	private void OnClaimBtnClick()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
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

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
