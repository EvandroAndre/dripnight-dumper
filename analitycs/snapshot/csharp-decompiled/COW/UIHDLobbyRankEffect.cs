using UnityEngine;
using tcp;

namespace COW;

public class UIHDLobbyRankEffect : MonoBehaviour
{
	public enum EHDShowRank
	{
		BR = 1,
		CS
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public GroupInfo groupInfo;

		internal bool _003COnLadderRankChange_003Eb__0(GroupMemberInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public GroupInfo groupInfo;

		internal bool _003COnCSRankChange_003Eb__0(GroupMemberInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public ulong captainId;

		internal bool _003CRecordCaptainInfo_003Eb__0(GroupMemberInfo x)
		{
			return false;
		}
	}

	public GameObject m_MeshRoot;

	public ParticleSystem m_ChangeVFX;

	public UISprite m_BRRank;

	public UISprite m_CSRank;

	public UILabel m_GrandMasterRankLabel;

	public Transform BRRankIconRoot;

	public Transform CSRankIconRoot;

	private int m_fingerIndex;

	private bool m_HasBRRank;

	private bool m_HasCSRank;

	private UICSRankIconController m_CSRankIconController;

	private UIBRRankIconController m_BRRankIconController;

	public const string HDSHOWRANKTYPE = "HDSHOWRANKTYPE_";

	private EHDShowRank m_CurrentType;

	private Vector3 m_deltaPosition;

	private UIModelGroup m_ModelGroup;

	private ulong m_captainId;

	private bool showCaptainLobby;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLadderRankChange(object[] data)
	{
	}

	private void OnCSRankChange(object[] data)
	{
	}

	private void TryRefreshCSCrossModeView()
	{
	}

	private void TryRefreshBRCrossModeView()
	{
	}

	private void TryCreateBRRankIconController()
	{
	}

	private void TryCreateCSRankIconController()
	{
	}

	public void OnEnable()
	{
	}

	public void OnRankIconClick()
	{
	}

	private void OnInitShowRank()
	{
	}

	private void RefreshRankIconView()
	{
	}

	private void ShowRankIcon(bool isBR)
	{
	}

	private bool InCaptainLobbyGroupState()
	{
		return false;
	}

	private bool InGroupState()
	{
		return false;
	}

	private void ShowCaptainHighLadder(object[] data)
	{
	}

	private void RecordCaptainInfo(ulong captainId)
	{
	}

	private void LeaveGroup(object[] data)
	{
	}
}
