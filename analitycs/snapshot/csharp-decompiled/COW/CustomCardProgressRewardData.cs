using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class CustomCardProgressRewardData
{
	private uint _003Cid_003Ek__BackingField;

	private uint _003Ccondition_num_003Ek__BackingField;

	public List<AwardDesc> awards;

	private uint cdn_id;

	private uint open_cdn_id;

	private string open_effect_fbx;

	private byte _003CState_003Ek__BackingField;

	public uint id
	{
		get
		{
			return _003Cid_003Ek__BackingField;
		}
		private set
		{
			_003Cid_003Ek__BackingField = value;
		}
	}

	public uint condition_num
	{
		get
		{
			return _003Ccondition_num_003Ek__BackingField;
		}
		private set
		{
			_003Ccondition_num_003Ek__BackingField = value;
		}
	}

	public byte State
	{
		get
		{
			return _003CState_003Ek__BackingField;
		}
		private set
		{
			_003CState_003Ek__BackingField = value;
		}
	}

	public static implicit operator CustomCardProgressRewardData(CustomCardProgressDesc item)
	{
		return null;
	}

	public uint GetCdnUrl()
	{
		return 0u;
	}

	public ResourceID GetEffectResourceID()
	{
		return default(ResourceID);
	}

	public void SetFloor(uint floor)
	{
	}

	public bool SetState(uint id)
	{
		return false;
	}
}
