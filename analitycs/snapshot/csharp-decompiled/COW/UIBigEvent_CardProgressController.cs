using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CardProgressController : UIBaseController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private UIBigEvent_CardProgressView m_View;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private List<UIBigEvent_CardProgressNodeController> mlist_nodeCtrl;

	private uint m_MaxFloor;

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

	public Vector3 GetProgressThumbPosition()
	{
		return default(Vector3);
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

	protected override void OnUIDestory()
	{
	}

	private void CreateEffectVFX()
	{
	}

	private void InitCDN()
	{
	}

	private void RefershProgressNodeList()
	{
	}

	private void RefershProgressValue()
	{
	}

	private void RefershCardProgressBox()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
