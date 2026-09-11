using GCommon;
using proto;

namespace COW;

public class UIUGCBigEvent_GlobalProgress_BarItemController : UIBaseController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private UIUGCBigEvent_GlobalProgress_BarItemView m_View;

	public CustomEventProcessSettingDesc Data;

	private UIUGCModelBigEvent_GlobalProgress m_UIModelBigEvent_GlobalProgress;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIStandardItemMiniController m_StandardItemCtrl;

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

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetData(CustomEventProcessSettingDesc data)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshTextureRewardBg()
	{
	}

	private void ShowRewardItemInfo()
	{
	}

	private void OnClickBtnAward()
	{
	}

	private EActivity.State GetRewardState()
	{
		return EActivity.State.State_RECEIVED;
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

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
