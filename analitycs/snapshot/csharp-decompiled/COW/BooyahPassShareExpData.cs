using System;
using proto;

namespace COW;

public class BooyahPassShareExpData : IComparable
{
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public ulong accoutnID;

		public ulong otherAccountID;

		internal bool _003CCompareTo_003Eb__0(TeamMemberWithAccountInfo e)
		{
			return false;
		}

		internal bool _003CCompareTo_003Eb__1(TeamMemberWithAccountInfo e)
		{
			return false;
		}
	}

	private uint m_Level;

	private uint m_ReceiveTimes;

	private bool m_CanClaim;

	private bool m_CanSend;

	private BooyahPassShareExpStatus m_Status;

	private ulong m_AccoutnID;

	private FriendAccountInfo m_AccountInfo;

	private BooyahPassStatusType m_CurrentPassStatus;

	private BooyahPassFriendType m_FrinedType;

	private bool m_IsSameVersion;

	public FriendAccountInfo AccountInfo => null;

	public uint Level => 0u;

	public uint ReceiveTimes => 0u;

	public BooyahPassShareExpStatus Status => BooyahPassShareExpStatus.None;

	public ulong AccountID => 0uL;

	public BooyahPassStatusType CurrentPassStatus => BooyahPassStatusType.FreePass;

	public uint FriendType => 0u;

	public bool IsSameVersion => false;

	public BooyahPassShareExpData(uint level, FriendAccountInfo accountInfo, ulong id, BooyahPassStatusType currentPassStatus)
	{
	}

	public void SetReceiveTimes(uint receiveTimes)
	{
	}

	public void SetClaimData(bool canclaim)
	{
	}

	private void SetReleaseVersion()
	{
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public void SetSharedExpClaimed()
	{
	}

	public void SetSharedExpSended()
	{
	}

	public void SetCurrentPassStatus(BooyahPassStatusType statusType)
	{
	}

	public void SetStatus()
	{
	}

	private void SetFriendType()
	{
	}

	public void SetAccountInfo(FriendAccountInfo info)
	{
	}
}
