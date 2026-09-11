using System;
using System.Collections.Generic;

namespace GCommon;

internal class NetworkStats : SingletonModule<NetworkStats>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal int _003C_002Ecctor_003Eb__47_0(KeyValuePair<uint, uint> a, KeyValuePair<uint, uint> b)
		{
			return 0;
		}
	}

	private ulong _003CTotalPacketSent_003Ek__BackingField;

	private ulong _003CTotalRUDPPacketSent_003Ek__BackingField;

	private ulong _003CTotalRUDPPacketResent_003Ek__BackingField;

	private ulong _003CTotalPRIReceived_003Ek__BackingField;

	private ulong _003CTotalPRIHandled_003Ek__BackingField;

	private uint _003CPlayerStateSyncStallCount_003Ek__BackingField;

	private float _003CPlayerStateSyncStallTotalSec_003Ek__BackingField;

	private float m_LastPlayerStateSyncTime;

	private long m_StallPingSum;

	private const int MAX_TRACKED_CMDS = 128;

	private readonly Dictionary<uint, uint> m_ResentByCmd;

	private static readonly Comparison<KeyValuePair<uint, uint>> s_ResentDescComparer;

	public ulong TotalPacketSent
	{
		get
		{
			return _003CTotalPacketSent_003Ek__BackingField;
		}
		private set
		{
			_003CTotalPacketSent_003Ek__BackingField = value;
		}
	}

	public ulong TotalRUDPPacketSent
	{
		get
		{
			return _003CTotalRUDPPacketSent_003Ek__BackingField;
		}
		private set
		{
			_003CTotalRUDPPacketSent_003Ek__BackingField = value;
		}
	}

	public ulong TotalRUDPPacketResent
	{
		get
		{
			return _003CTotalRUDPPacketResent_003Ek__BackingField;
		}
		private set
		{
			_003CTotalRUDPPacketResent_003Ek__BackingField = value;
		}
	}

	public ulong TotalPRIReceived
	{
		get
		{
			return _003CTotalPRIReceived_003Ek__BackingField;
		}
		private set
		{
			_003CTotalPRIReceived_003Ek__BackingField = value;
		}
	}

	public ulong TotalPRIHandled
	{
		get
		{
			return _003CTotalPRIHandled_003Ek__BackingField;
		}
		private set
		{
			_003CTotalPRIHandled_003Ek__BackingField = value;
		}
	}

	public uint PlayerStateSyncStallCount
	{
		get
		{
			return _003CPlayerStateSyncStallCount_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerStateSyncStallCount_003Ek__BackingField = value;
		}
	}

	public float PlayerStateSyncStallTotalSec
	{
		get
		{
			return _003CPlayerStateSyncStallTotalSec_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerStateSyncStallTotalSec_003Ek__BackingField = value;
		}
	}

	public int PlayerStateSyncStallAvgPing => 0;

	public void PacketSent(bool isReliable)
	{
	}

	public void PacketResent()
	{
	}

	public void PacketResent(uint cmd)
	{
	}

	public void TryPlayerStateSyncBeacon(float now, int curPing, float thresholdSec)
	{
	}

	public uint ResentCountOfCmd(uint cmd)
	{
		return 0u;
	}

	public void GetTopResentCmds(int topN, List<KeyValuePair<uint, uint>> outList)
	{
	}

	public void PRIReceived()
	{
	}

	public void PRIHandled()
	{
	}

	public void Clear()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}
