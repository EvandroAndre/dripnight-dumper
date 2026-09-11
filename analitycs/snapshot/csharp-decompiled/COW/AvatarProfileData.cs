using GCommon;
using proto;

namespace COW;

public class AvatarProfileData : CsvDataIndexedReading, IGetId
{
	private string _003CProfileTitle_003Ek__BackingField;

	private string occupationKey;

	private string _003CAge_003Ek__BackingField;

	private string _003CBirthday_003Ek__BackingField;

	private string hobbykey;

	private string relationship1Key;

	private string _003CRelationship2_003Ek__BackingField;

	private string _003CRelationship3_003Ek__BackingField;

	private uint _003CID_003Ek__BackingField;

	private EInventory.AwardType _003CRewardType_003Ek__BackingField;

	private uint _003CRewardId_003Ek__BackingField;

	private uint _003CRewardTime_003Ek__BackingField;

	private EInventory.AwardType _003CRewardType2_003Ek__BackingField;

	private uint _003CRewardId2_003Ek__BackingField;

	private uint _003CRewardTime2_003Ek__BackingField;

	private uint _003CDebrisID_003Ek__BackingField;

	private uint _003CDebrisCount_003Ek__BackingField;

	private uint _003CItemID_003Ek__BackingField;

	private uint _003CItemCount_003Ek__BackingField;

	public ResourceID RelationshipID1;

	public ResourceID RelationshipID2;

	public ResourceID RelationshipID3;

	public uint RelationshipRealID1;

	public uint RelationshipRealID2;

	public uint RelationshipRealID3;

	public string ProfileTitle
	{
		get
		{
			return _003CProfileTitle_003Ek__BackingField;
		}
		private set
		{
			_003CProfileTitle_003Ek__BackingField = value;
		}
	}

	public string Occupation
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public string Age
	{
		get
		{
			return _003CAge_003Ek__BackingField;
		}
		private set
		{
			_003CAge_003Ek__BackingField = value;
		}
	}

	public string Birthday
	{
		get
		{
			return _003CBirthday_003Ek__BackingField;
		}
		private set
		{
			_003CBirthday_003Ek__BackingField = value;
		}
	}

	public string Hobby
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public string Relationship1
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public string Relationship2
	{
		get
		{
			return _003CRelationship2_003Ek__BackingField;
		}
		private set
		{
			_003CRelationship2_003Ek__BackingField = value;
		}
	}

	public string Relationship3
	{
		get
		{
			return _003CRelationship3_003Ek__BackingField;
		}
		private set
		{
			_003CRelationship3_003Ek__BackingField = value;
		}
	}

	public uint ID
	{
		get
		{
			return _003CID_003Ek__BackingField;
		}
		private set
		{
			_003CID_003Ek__BackingField = value;
		}
	}

	public EInventory.AwardType RewardType
	{
		get
		{
			return _003CRewardType_003Ek__BackingField;
		}
		private set
		{
			_003CRewardType_003Ek__BackingField = value;
		}
	}

	public uint RewardId
	{
		get
		{
			return _003CRewardId_003Ek__BackingField;
		}
		private set
		{
			_003CRewardId_003Ek__BackingField = value;
		}
	}

	public uint RewardTime
	{
		get
		{
			return _003CRewardTime_003Ek__BackingField;
		}
		private set
		{
			_003CRewardTime_003Ek__BackingField = value;
		}
	}

	public EInventory.AwardType RewardType2
	{
		get
		{
			return _003CRewardType2_003Ek__BackingField;
		}
		private set
		{
			_003CRewardType2_003Ek__BackingField = value;
		}
	}

	public uint RewardId2
	{
		get
		{
			return _003CRewardId2_003Ek__BackingField;
		}
		private set
		{
			_003CRewardId2_003Ek__BackingField = value;
		}
	}

	public uint RewardTime2
	{
		get
		{
			return _003CRewardTime2_003Ek__BackingField;
		}
		private set
		{
			_003CRewardTime2_003Ek__BackingField = value;
		}
	}

	public uint DebrisID
	{
		get
		{
			return _003CDebrisID_003Ek__BackingField;
		}
		private set
		{
			_003CDebrisID_003Ek__BackingField = value;
		}
	}

	public uint DebrisCount
	{
		get
		{
			return _003CDebrisCount_003Ek__BackingField;
		}
		private set
		{
			_003CDebrisCount_003Ek__BackingField = value;
		}
	}

	public uint ItemID
	{
		get
		{
			return _003CItemID_003Ek__BackingField;
		}
		private set
		{
			_003CItemID_003Ek__BackingField = value;
		}
	}

	public uint ItemCount
	{
		get
		{
			return _003CItemCount_003Ek__BackingField;
		}
		private set
		{
			_003CItemCount_003Ek__BackingField = value;
		}
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override string[] GetHeadColNames()
	{
		return null;
	}

	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
