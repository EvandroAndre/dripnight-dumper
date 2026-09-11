using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIModelVBadgeBroadcast : UIBaseModel
{
	public class VBadgeBroadcastData
	{
		public uint PlayerID;

		public string PlayerName;

		public uint BadgeType;

		public uint BadgeSubType;

		public uint LikeCount;

		public float ReceiveTime;

		public uint Role;
	}

	public const uint PropID_PlayerLikeCountUpdated = 4u;

	public const uint PropID_CurrentBroadcastChanged = 8u;

	private Dictionary<uint, VBadgeBroadcastData> m_VBadgePlayerDict;

	private VBadgeBroadcastData m_CurrentBroadcast;

	private const float BROADCAST_DISPLAY_DURATION = 4f;

	public VBadgeBroadcastData CurrentBroadcast => null;

	public float BroadcastDuration => 0f;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	protected override void OnSceneChange(object[] data)
	{
	}

	public void OnReceiveVBadgeBroadcast(uint playerID, string playerName, uint role, uint badgeType, uint badgeSubType)
	{
	}

	public void ClearCurrentBroadcast()
	{
	}

	private void ClearAllData()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSceneChange(object[] P0)
	{
	}
}
