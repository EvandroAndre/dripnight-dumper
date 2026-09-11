using GCommon;

namespace COW;

internal class UIActivityV2FriendReunionInviterController : UIActivityContentController, IUIModelDataChangeObserver
{
	public enum BottomUIType
	{
		None,
		Both,
		OnlyRecall,
		OnlyTeam
	}

	private UIActivityV2FriendReunionInviterView m_View;

	private UIActivityV2FriendReunionInviterProgressController m_V2FriendReunionInviterProgressController;

	private UIActivityV2FriendReunionInviterRecallController m_V2FriendReunionInviterRecallController;

	private UIActivityV2FriendReunionInviterTeamController m_V2FriendReunionInviterTeamController;

	private UIActivityV2FriendReunionTitleController m_RecallTitle;

	private UIActivityV2FriendReunionTitleController m_TeamTitle;

	private UIModelFriendReunion m_ModelFriendReunion;

	private float m_NormalTeamTitlePosX;

	private float m_BigTypeTeamTitlePosX;

	private float m_RecallConPosX;

	private float m_TeamConPosX;

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

	private void InitView()
	{
	}

	private void RefreshView()
	{
	}

	private void SetBottomUI(BottomUIType bottomUIType)
	{
	}

	private void SetBottomUIWithNone()
	{
	}

	private void SetBottomUIWithBoth()
	{
	}

	private void SetBottomUIWithRecall()
	{
	}

	private void SetBottomUIWithTeam()
	{
	}

	private void RefreshRecallConWithBigType(bool flag)
	{
	}

	private void RefreshTeamConWithBigType(bool flag)
	{
	}

	private void RefreshRecallTitleWithBigTypee(bool flag)
	{
	}

	private void RefreshRecallTeamTitleWithBigType(bool flag)
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
