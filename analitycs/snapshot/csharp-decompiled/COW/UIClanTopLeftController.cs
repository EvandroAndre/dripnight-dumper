using GCommon;
using proto;

namespace COW;

internal class UIClanTopLeftController : UIBaseController, IUIModelDataChangeObserver
{
	private UIClanTopLeftView m_View;

	private UIModelClanTrend m_ModelClanTrend;

	private UIModelClan m_ModelClan;

	private UIModelChat m_ModelChat;

	private EClan.HighLightType m_HLMsgType;

	private uint m_NoticeContinueShowTime;

	private uint m_DelayCallMessageShow;

	private int m_MessageLabelOrigWidth;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void RefreshTopBarShowState()
	{
	}

	private void RefreshClanMainPageTopBarShowState(bool showNoticeVFX = false)
	{
	}

	private EClanTopLeftMainShowState CheckTopLeftShowState()
	{
		return EClanTopLeftMainShowState.None;
	}

	private bool CheckShowClanNoticeInfo()
	{
		return false;
	}

	private bool CheckShowHLMember()
	{
		return false;
	}

	private bool CheckHasNewClanTrend()
	{
		return false;
	}

	private bool CheckHasNewMessage()
	{
		return false;
	}

	private void InitHLMemberState()
	{
	}

	private void InitNewTrendState()
	{
	}

	private void InitMessageState()
	{
	}

	private void OnScrollFinish()
	{
	}

	private void InitTrendBtnShowState()
	{
	}

	public override void Hide()
	{
	}

	private void OnClanNoticeBtnClick()
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

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
