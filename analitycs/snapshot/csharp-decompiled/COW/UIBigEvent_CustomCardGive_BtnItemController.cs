using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCardGive_BtnItemController : UIBaseController, IBigEventTemplateIdentifier, IUIModelDataChangeObserver
{
	private UIBigEvent_CustomCardGive_BtnItemView m_View;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private UIModelBigEvent_CustomCard m_ModelCustomCard;

	private ResourceID m_EffectVFXResID;

	private GameObject m_EffectVFXGO;

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

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	private void InitBtn()
	{
	}

	private void OnClickEntranceBtn()
	{
	}

	private void OnRedPointCallback(object[] data)
	{
	}

	public bool GetGuide(out UIWidget targetWidget, out UIButton finishButton)
	{
		targetWidget = null;
		finishButton = null;
		return false;
	}

	private void CalculateBubble()
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
