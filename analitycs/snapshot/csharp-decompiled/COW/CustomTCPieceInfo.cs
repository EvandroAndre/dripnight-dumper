using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class CustomTCPieceInfo
{
	public enum TCPieceState
	{
		Locked,
		InProgress,
		CanClaim,
		Opended
	}

	private UIModelBigEvent_CustomTC m_Model;

	private uint normal_cdnid;

	private uint open_cdnid;

	private string effect_fbx;

	private uint _003CPieceId_003Ek__BackingField;

	private List<AwardDesc> _003CAwards_003Ek__BackingField;

	private uint _003CProgress_003Ek__BackingField;

	private uint _003CConsume_003Ek__BackingField;

	private uint _003CLockCdnId_003Ek__BackingField;

	public uint PieceId
	{
		get
		{
			return _003CPieceId_003Ek__BackingField;
		}
		private set
		{
			_003CPieceId_003Ek__BackingField = value;
		}
	}

	public List<AwardDesc> Awards
	{
		get
		{
			return _003CAwards_003Ek__BackingField;
		}
		private set
		{
			_003CAwards_003Ek__BackingField = value;
		}
	}

	public uint Progress
	{
		get
		{
			return _003CProgress_003Ek__BackingField;
		}
		private set
		{
			_003CProgress_003Ek__BackingField = value;
		}
	}

	public uint Consume
	{
		get
		{
			return _003CConsume_003Ek__BackingField;
		}
		private set
		{
			_003CConsume_003Ek__BackingField = value;
		}
	}

	public uint LockCdnId
	{
		get
		{
			return _003CLockCdnId_003Ek__BackingField;
		}
		private set
		{
			_003CLockCdnId_003Ek__BackingField = value;
		}
	}

	public bool IsCirculateBox => false;

	public TCPieceState State => TCPieceState.Locked;

	public CustomTCPieceInfo(CustomTCRewardDesc item)
	{
	}

	public uint GetCDNId()
	{
		return 0u;
	}

	private bool IsUnclaimed()
	{
		return false;
	}

	public void SetPieceInfo(CustomTCPieceDesc pieceDesc)
	{
	}

	public void SetProgress(uint progress)
	{
	}

	public ResourceID GetVFXResourceID()
	{
		return default(ResourceID);
	}
}
