using System;
using System.Collections.Generic;
using proto;

namespace COW;

public class AttendaceItemInfo : IComparable<AttendaceItemInfo>
{
	public enum EAttendanceSignState
	{
		UnSigned,
		Signed,
		NeedSign,
		Claimed
	}

	private uint _003CAttendaceItemID_003Ek__BackingField;

	private uint _003CSignState_003Ek__BackingField;

	private List<AwardItemInfo> m_AwardInfoList;

	public uint AttendaceItemID
	{
		get
		{
			return _003CAttendaceItemID_003Ek__BackingField;
		}
		private set
		{
			_003CAttendaceItemID_003Ek__BackingField = value;
		}
	}

	public bool Signed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint SignState
	{
		get
		{
			return _003CSignState_003Ek__BackingField;
		}
		set
		{
			_003CSignState_003Ek__BackingField = value;
		}
	}

	public List<AwardItemInfo> AwardInfoList => null;

	public static implicit operator AttendaceItemInfo(AttendanceItem item)
	{
		return null;
	}

	public static implicit operator AttendaceItemInfo(NewPlayerRewardItem item)
	{
		return null;
	}

	public int CompareTo(AttendaceItemInfo other)
	{
		return 0;
	}
}
