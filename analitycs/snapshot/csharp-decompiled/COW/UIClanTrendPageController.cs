using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIClanTrendPageController : UIBaseChatController
{
	private UIClanTrendPageView m_View;

	private ChatChannelInfo m_ChatChannelInfo;

	private UIModelClanTrend m_ModelClanTrend;

	private UIModelClan m_ModelClan;

	private UIModelChat m_ModelChat;

	private UICenterOnChild m_WrapCenter;

	private List<UIClanTrendHLContainerController> m_HLContainerList;

	private List<UIClanTrendMemberTrendController> m_MemberTrendList;

	private List<UIClanTrendHLDotController> m_DotsCtrl;

	private UIClanTrendReactEmoteConatinerController m_EmoteContainerCtrl;

	private int m_LastIndex;

	private uint m_AutoScrollDelayCallID;

	private const uint AUTOSCROLLTIME = 5u;

	private string m_DefaultClanNotice;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Hide()
	{
	}

	public override void Show()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void RefreshContentNode()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override ChatChannelInfo GetCurShowChannel()
	{
		return null;
	}

	public override void GetMessageList()
	{
	}

	protected override void InitView()
	{
	}

	private void OnBaseProfileUpdate(object[] data)
	{
	}

	private void OnInputFieldOnFocus()
	{
	}

	private void OnInputFieldLostFocus()
	{
	}

	private void RefreshClanBasicInfo()
	{
	}

	private void RefreshClanHLMember()
	{
	}

	private void GetCenterItem(GameObject centerGo)
	{
	}

	private void OnAutoScrollHLItem()
	{
	}

	private void RefreshMemberTrendInfo()
	{
	}

	public void RefreshViewData()
	{
	}

	public void ShowReactEmoteContainer(ulong msgId)
	{
	}

	public int GetMessageListDepth()
	{
		return 0;
	}

	public float GetMessageListPanelWidth()
	{
		return 0f;
	}

	public Transform GetBriefboxPosition()
	{
		return null;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContentNode()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public ChatChannelInfo _003C_003EiFixBaseProxy_GetCurShowChannel()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_GetMessageList()
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}
}
