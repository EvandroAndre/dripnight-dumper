using GCommon;

namespace COW;

public class UIHUDVBadgeBroadcastCabinTopTipController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHUDVBadgeBroadcastCabinTopTipView m_View;

	private UIModelVBadgeBroadcast m_Model;

	private UIModelVBadgeBroadcast.VBadgeBroadcastData m_CurrentData;

	private uint m_HideDelayCallID;

	private bool m_IsShowing;

	private bool m_IsSuperEmotePlaying;

	private int m_LikeCount;

	private UIHudQuickChatThumbNodeController m_ThumbNodeController;

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

	protected override void OnUIDestory()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void ShowBroadcast(UIModelVBadgeBroadcast.VBadgeBroadcastData data)
	{
	}

	private void RefreshLabel(UIModelVBadgeBroadcast.VBadgeBroadcastData data)
	{
	}

	private void RefreshIcon(UIModelVBadgeBroadcast.VBadgeBroadcastData data)
	{
	}

	private void HideBanner()
	{
	}

	private void OnBroadcastTimeout()
	{
	}

	private void OnVBadgeLikeCountChange(int count)
	{
	}

	private void UpdateLikeLabel()
	{
	}

	private void CancelHideDelayCall()
	{
	}

	private void CancelAllDelayedCalls()
	{
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
