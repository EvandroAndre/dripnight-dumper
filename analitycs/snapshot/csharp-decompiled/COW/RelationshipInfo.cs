using System;
using proto;

namespace COW;

public class RelationshipInfo
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__18_0;

		internal void _003CSetStateCountDown_003Eb__18_0()
		{
		}
	}

	public int OldIntimacy;

	private IntimacyState _003CIntimcyState_003Ek__BackingField;

	private uint m_DelayCall;

	public EFriend.SpecialFriendState CurrentRelationshipState
	{
		get
		{
			return EFriend.SpecialFriendState.SpecialFriendState_NONE;
		}
		set
		{
		}
	}

	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public IntimacyState IntimcyState
	{
		get
		{
			return _003CIntimcyState_003Ek__BackingField;
		}
		private set
		{
			_003CIntimcyState_003Ek__BackingField = value;
		}
	}

	public FriendAccountInfo CurrentTargetFriend
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static RelationshipInfo Createrelationship(IntimacyState state)
	{
		return null;
	}

	public void UpdateRelationshipState(EFriend.SpecialFriendState state)
	{
	}

	~RelationshipInfo()
	{
	}

	private void SetStateCountDown(float validTime)
	{
	}

	private void InitRelationshipState()
	{
	}
}
