using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIModelInvitation : UIBaseModel
{
	private Dictionary<ulong, ulong> m_IgnorePlayerDict;

	private Dictionary<ulong, ulong> m_HalfwayJoinIgnoreDict;

	public Queue<object[]> InvitationDataQueue;

	public Queue<ulong> InvitationTimeQueue;

	public Queue<ulong> InvitationIDQueue;

	private ulong m_InvitationID;

	public ulong NowTopInvitationID;

	private List<CachedInvitationData> m_CachedInvitations;

	private bool _003CIsBlockAllInvitation_003Ek__BackingField;

	public bool IsBlockAllInvitation
	{
		get
		{
			return _003CIsBlockAllInvitation_003Ek__BackingField;
		}
		private set
		{
			_003CIsBlockAllInvitation_003Ek__BackingField = value;
		}
	}

	public bool HasCachedInvitations => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void ClearData()
	{
	}

	public void CacheInvitations(List<CachedInvitationData> displayingInvitations)
	{
	}

	public void RestoreCachedInvitations()
	{
	}

	public void AddInvitationData(object[] args)
	{
	}

	public void AddIgnorePlayer(ulong accountId)
	{
	}

	public void RemoveIgnorePlayer(ulong accountId)
	{
	}

	public bool CheckIsInIgnoreList(ulong accountId)
	{
		return false;
	}

	public void AddHalfwayJoinIgnorePlayer(ulong accountId)
	{
	}

	public bool CheckIsInHalfwayJoinIgnoreList(ulong accountId)
	{
		return false;
	}

	public void StartBlockAll()
	{
	}

	public void CancelBlockAll()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
