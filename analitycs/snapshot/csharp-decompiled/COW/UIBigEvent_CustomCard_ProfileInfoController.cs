using GCommon;

namespace COW;

public class UIBigEvent_CustomCard_ProfileInfoController : UIBaseController, IBigEventTemplateIdentifier
{
	private UIBigEvent_CustomCard_ProfileInfoView m_View;

	private ulong m_AccountId;

	private uint m_Serial;

	private UIModelProfile m_UIModelProfile;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private UIBaseProfileInfoController m_BaseProfile;

	private float m_ShowTime;

	private readonly float Duration;

	private bool m_ShowStatus;

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

	public bool SetFriendData(ulong account_id, uint serial)
	{
		return false;
	}

	public bool RefershShowStatus(bool active)
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
