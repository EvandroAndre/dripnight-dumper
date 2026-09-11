using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIChatSquadContainerController : UIChatBaseContainerController, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public EChannel.ChannelType type;

		public ulong channelID;

		internal bool _003CGoToSquadChannel_003Eb__0(ChatChannelInfo channelInfo)
		{
			return false;
		}
	}

	private UIChatSquadContainerView m_View;

	private List<ChatChannelInfo> m_ChannelList;

	private UIModelChat m_ModelChat;

	private ChatChannelInfo m_CurrenChannel;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void InitWidget(Transform parent)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitChannelList()
	{
	}

	private void CreateTab()
	{
	}

	private void OnSquadItemClick(object[] param)
	{
	}

	public override GameObject GetContentNode()
	{
		return null;
	}

	public override GameObject GetEmptyNode()
	{
		return null;
	}

	public override UIScrollView GetMessageList()
	{
		return null;
	}

	public override UITable2 GetMessageListTable2()
	{
		return null;
	}

	public override void RefreshContentNode()
	{
	}

	public void GoToSquadChannel(EChannel.ChannelType type, ulong channelID)
	{
	}

	UIEasyListItemController IEasyList.OpenItemController(Transform parent)
	{
		return null;
	}

	void IEasyList.CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitWidget(Transform P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
