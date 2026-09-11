using GCommon;
using proto;

namespace COW;

internal class UIActivityV2FriendReunionInviterProgressItemController : UIBaseController, IUIModelDataChangeObserver
{
	private enum InviterAwardType
	{
		Normal,
		Finished,
		Claimed
	}

	private UIActivityV2FriendReunionInviterProgressItemView m_View;

	private CallbackProcessDesc m_Data;

	private UIStandardItemMiniController m_StandardItemMiniController;

	private UIActivityV2FriendReunionInviterProgressController m_ParentCtrl;

	private UIModelFriendReunion m_ModelFriendReunion;

	private int m_Index;

	private InviterAwardType m_InviterAwardType;

	private UIActivityV2FriendReunionInviterProgressController ParentCtrlProgress => null;

	public bool CheckNeedShowDetailPop => false;

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

	private void InitUIView()
	{
	}

	private void InitScoreNum()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshNormalClaimState()
	{
	}

	private void RefreshRedTip()
	{
	}

	public void SetViewData(CallbackProcessDesc data, int index)
	{
	}

	private void ProcessAwardUI()
	{
	}

	private void RefreshBigRewardClaimState()
	{
	}

	private void ProcessAwardType()
	{
	}

	private void OnBtnItemClicked()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
