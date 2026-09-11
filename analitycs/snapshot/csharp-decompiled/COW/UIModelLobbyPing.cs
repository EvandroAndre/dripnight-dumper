using System.Collections.Generic;
using GCommon;
using tcp;

namespace COW;

public class UIModelLobbyPing : UIBaseModel, PlatformUtility.INetworkCallback
{
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public UIFrontEndScene frontEndScene;

		internal void _003CGroupInfoChanged_003Eb__0()
		{
		}
	}

	public const uint PropID_LobbyPingBack = 2u;

	public bool HighPingTipsBoxHasPopedUp;

	private int HIGH_PING_THRESHOLD;

	private int MIDDLE_PING_THRESHILD;

	private uint m_IpRegionHighPingMinValue;

	private uint m_AutoPingDelayCallID;

	private string m_GroupIDC;

	private Dictionary<string, IDCNode> m_DictIDCPing;

	private bool m_IsSolo;

	private bool m_IsGroupLeader;

	private Queue<string> m_PingWork;

	private bool m_LobbyPingHasWork;

	private float m_LobbyPingWorkStartTime;

	private List<string> m_PingAddress;

	private List<string> m_PingIDCName;

	private int PING_INTERVAL;

	private int m_MultiplePingCount;

	private float m_LastIngamePingTime;

	private bool NeedPingAll => false;

	public bool LobbyPingHasWorked
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void InitLobbyPing(object[] data)
	{
	}

	public void SetFakeGSIDCPing()
	{
	}

	public override void Logout(object[] data)
	{
	}

	protected override void OnSceneChange(object[] data)
	{
	}

	public void ClearAutoPing()
	{
	}

	public LobbyNetworkQuality GetPingState()
	{
		return LobbyNetworkQuality.White;
	}

	public void GroupInfoChanged(GroupInfo BeforeChangedGroupInfo, GroupInfo AfterChangedGroupInfo)
	{
	}

	public bool IsInHighPing()
	{
		return false;
	}

	public void SetIDCPing(string IDCName, int ping, bool loss = false, bool needNotify = true)
	{
	}

	public void StartAutoPing()
	{
	}

	public LobbyNetworkQuality GetPingStateByPing(int ping)
	{
		return LobbyNetworkQuality.White;
	}

	public List<LobbyPingDesc> GetAllDescAfterPingBack()
	{
		return null;
	}

	public string GetGroupState()
	{
		return null;
	}

	public void InitParam()
	{
	}

	public void OnNetworkCallback(PlatformUtility.NetworkCallbackStatus before, PlatformUtility.NetworkCallbackStatus after)
	{
	}

	public void InitIpRegionHighPingWarningMinValue(uint pingValue)
	{
	}

	private void ClearAll()
	{
	}

	private void ClearBuffer()
	{
	}

	private void AutoPingBack(List<NetDetectionResult> results, object extra_data)
	{
	}

	private void MultipleAutoPingBack(List<NetDetectionResult> results, object extra_data)
	{
	}

	private void TrySyncToBackend(string idcName)
	{
	}

	private void ePingAllIDC()
	{
	}

	private void MultiplePingAllIDC()
	{
	}

	private void RefreshCurrentPingWork()
	{
	}

	private bool IsInvalidPing(int pingValue)
	{
		return false;
	}

	private bool CheckCurrentCanPing()
	{
		return false;
	}

	private void RefreshIDCNodeAddress()
	{
	}

	private void RefreshIDCNodeName()
	{
	}

	private bool PlayerIsReady(GroupInfo groupInfo)
	{
		return false;
	}

	private void TryAutoPingOnce()
	{
	}

	public void IngamePingOnce()
	{
	}

	private void _003CePingAllIDC_003Eb__44_0(List<NetDetectionResult> results, object extra_data)
	{
	}

	private void _003CMultiplePingAllIDC_003Eb__45_0(List<NetDetectionResult> results, object extra_data)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSceneChange(object[] P0)
	{
	}
}
