using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMilestone_SharePopupWndController : UIPopupWindowController, IBigEventTemplateIdentifier, IUIModelDataChangeObserver
{
	private enum ShareStatus
	{
		Sharing = 1,
		Submit = 2,
		Receive = 4
	}

	private UIMilestone_SharePopupWndView m_View;

	private UIModelBigEvent_Milestone m_ModelMilestone;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private CustomMilestoneShareDesc m_ShareDesc;

	private int m_DownCount;

	private UIMilestone_ShareTitleItemController m_ShareTitleItemController;

	private UINetworkTextureExt[] m_TabTitleTextures;

	private GameObject[] m_TabGos;

	private Vector3 m_TitlePosition;

	private int m_CurrentSelectedIndex;

	private uint m_ShareStatus;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public bool isReady => false;

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

	protected override void OnSetNavigationController()
	{
	}

	public void SetShareData(CustomMilestoneShareDesc desc)
	{
	}

	public void OnNetworkTextureDown()
	{
	}

	public void AddNetworkTextureDown()
	{
	}

	public void WriteTitlePosition(Vector3 localPosition)
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void OnClickShareBtn()
	{
	}

	private void OnClickTab1()
	{
	}

	private void OnClickTab2()
	{
	}

	private void OnClickTab3()
	{
	}

	private void RefershShareView()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public override void OnShare(bool success, int platform)
	{
	}

	public override void OnCopyShareLink(bool success)
	{
	}

	public override void OnSaveSharePhoto(bool success)
	{
	}

	private void SubmitShareActivity()
	{
	}

	private void RefershShareGiftGo()
	{
	}

	public EBigEventTemplateType GetTemplateType()
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

	private void _003COnClickShareBtn_003Eb__23_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCopyShareLink(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSaveSharePhoto(bool P0)
	{
	}
}
