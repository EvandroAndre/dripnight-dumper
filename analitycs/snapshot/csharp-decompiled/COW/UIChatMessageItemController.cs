using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIChatMessageItemController : UIBaseChatItemController, UITable2.IUITable2Item
{
	public UIChatMessageItemView m_View;

	private UILeaderBoardTitleSingleController m_TitleSingleCtrl;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	public const int POPMENU_POS_X = 800;

	public const int POPMENU_POS_Y = 190;

	private int m_DefaultCornerColor;

	private int m_DefaultNormalBannerColor;

	private int m_DefaultColorBGColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override EChannel.ChannelType GetParentChannelType()
	{
		return EChannel.ChannelType.ChannelType_GROUP;
	}

	public override void OpenIteractionPanel(InteractionPopUtil.UIInteractionPoptype PopType, string region)
	{
	}

	public override void SetUIData(MessageInfo info, Transform parent = null)
	{
	}

	private void CheckAndChangeColorWhenSpecialColorMessage(MessageInfo info, bool isSender)
	{
	}

	private void RefreshTitleSingleCtrl(bool isSender, LeaderBoardTitleShowingParams showParams)
	{
	}

	private void ChangeLeftLayoutBottomPosition(bool isUp)
	{
	}

	private void ChangeRightLayoutBottomPosition(bool isUp)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private EventLogger.BriefBoxClickData GetBriefBoxClickData(ulong accountId)
	{
		return null;
	}

	public void CheckUGCMapExposure(int index)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public EChannel.ChannelType _003C_003EiFixBaseProxy_GetParentChannelType()
	{
		return EChannel.ChannelType.ChannelType_GROUP;
	}

	public void _003C_003EiFixBaseProxy_OpenIteractionPanel(InteractionPopUtil.UIInteractionPoptype P0, string P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetUIData(MessageInfo P0, Transform P1)
	{
	}
}
