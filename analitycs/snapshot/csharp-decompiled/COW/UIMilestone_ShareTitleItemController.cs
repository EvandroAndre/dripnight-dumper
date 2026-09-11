using GCommon;
using UnityEngine;

namespace COW;

public class UIMilestone_ShareTitleItemController : UIBaseController, IBigEventTemplateIdentifier
{
	private UIMilestone_ShareTitleItemView m_View;

	private UIModelBigEvent_Milestone m_ModelMilestone;

	private UIMilestone_SharePopupWndController m_ParentController;

	private Vector2 minBound;

	private Vector2 maxBound;

	private Vector2 bound;

	private float ratio;

	private Vector3 localPosition;

	private bool _003CisReady_003Ek__BackingField;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public bool isReady
	{
		get
		{
			return _003CisReady_003Ek__BackingField;
		}
		private set
		{
			_003CisReady_003Ek__BackingField = value;
		}
	}

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

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	private Vector3 LimitBound(Vector3 position)
	{
		return default(Vector3);
	}

	private void OnDragEvent(GameObject gameObject, Vector2 delta)
	{
	}

	private void OnEndDragEvent(GameObject gameObject)
	{
	}

	public void SetTitleCdn(uint cdn_id)
	{
	}

	public void OnNetworkTextureDown()
	{
	}

	public void OnScreenShotCallback(bool result)
	{
	}

	public EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
