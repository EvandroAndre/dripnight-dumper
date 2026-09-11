using GCommon;
using proto;

namespace COW;

public class UIFlashStoreActivityItemController : UIBaseController
{
	private const string ON_START_ANIM_NAME = "UIFlashStoreActivityItem_In";

	private uint m_ActivityID;

	private string m_ClickLogIdentifier;

	private EventLogger.ClickType m_ClickType;

	private ClientActivityDesc m_ActivityDesc;

	private UIFlashStoreActivityItemView m_View;

	private bool IsReady => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void AddEventDelegate()
	{
	}

	private void OnClaimBtnClick()
	{
	}

	private void OnGoBtnClick()
	{
	}

	private void SetStartAnimToFirstFrame()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void LoadStaticContent()
	{
	}

	private void RefreshBtnWithActivityState(EActivity.State state)
	{
	}

	private void RefreshDynamicContent()
	{
	}

	public UIFlashStoreActivityItemController SetViewData(uint activityID, EventLogger.ClickType clickType, string logIdentifier)
	{
		return null;
	}

	public void PlayStartAnim()
	{
	}

	public void SkipStartAnimToLastFrame()
	{
	}

	public void OnUpdateActivityInfo()
	{
	}

	public uint GetActivityID()
	{
		return 0u;
	}

	public UIWidget GetWidgetForGuide()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
