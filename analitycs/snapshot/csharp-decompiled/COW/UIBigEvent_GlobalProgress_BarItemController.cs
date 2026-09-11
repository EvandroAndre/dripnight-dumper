using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEvent_GlobalProgress_BarItemController : UIBaseController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private UIBigEvent_GlobalProgress_BarItemView m_View;

	public CustomEventProcessSettingDesc Data;

	private UIModelBigEvent_GlobalProgress m_UIModelBigEvent_GlobalProgress;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIStandardItemMiniController m_StandardItemCtrl;

	private ResourceID m_GPItemNumberVFXResID;

	private GameObject m_GPItemNumberVFXGO;

	private uint m_GPItemNumberDelayCallID;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	protected UICommonRewardWndController.WndStyleEnum WndStyle => UICommonRewardWndController.WndStyleEnum.COMMON;

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

	private bool LoadGPItemNumberVFX()
	{
		return false;
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

	private void _003CLoadGPItemNumberVFX_003Eb__18_0()
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
