using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIRoomDuoPlayerWithTeamItemController : UIEasyListItemController
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public UIRoomDuoPlayerWithTeamItemController _003C_003E4__this;

		public int from;

		public int to;

		internal void _003COnInteractionBtnClick_003Eb__0()
		{
		}
	}

	private UIRoomDuoPlayerWithTeamItemView m_View;

	private List<RoomPlayerInfo> m_Members;

	private List<UIRoomPlayerItemController> m_PlayerCtrls;

	private new int m_Index;

	private UIModelCustomRoom m_Model;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ResetWidgetWidth()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void ResetTeamView()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnSelectedChanged(object[] data)
	{
	}

	private void OnInteractionBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
