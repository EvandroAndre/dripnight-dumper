using GCommon;

namespace COW;

public class UIMilestone_LoadingMaskPopupWndController : UIBigEvent_Template_LoadingMaskPopupWndBaseController, IUIModelDataChangeObserver
{
	private UIModelBigEvent_Milestone m_UIModelMilestone;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	protected override void OnUIInit()
	{
	}

	protected override void RefreshLoadingMaskNeedDownloadCdn()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public EBigEventTemplateType _003C_003EiFixBaseProxy_GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshLoadingMaskNeedDownloadCdn()
	{
	}
}
