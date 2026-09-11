using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCChatChannelRepItem
{
	public const int PROP_ID_CHANNELID = -109000;

	public const int PROP_ID_PLAYERS = -109001;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnChannelIDChangeEvent;

	public Action<List<object>> OnPlayersChangeEvent;

	private string _003CChannelID_003Ek__BackingField;

	private List<object> _003CPlayers_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string ChannelID
	{
		get
		{
			return _003CChannelID_003Ek__BackingField;
		}
		private set
		{
			_003CChannelID_003Ek__BackingField = value;
		}
	}

	public List<object> Players
	{
		get
		{
			return _003CPlayers_003Ek__BackingField;
		}
		private set
		{
			_003CPlayers_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCChatChannelRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
