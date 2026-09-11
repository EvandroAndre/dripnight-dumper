using COW.GamePlay;
using GCommon;
using GCommon.Audio;
using UnityEngine;

namespace COW;

public class UIHudLobbyLWPlayerStateController : UIHudNameBaseController
{
	private const uint VISIBILITY_STATE_CAMERA_MODE = 1073741824u;

	private UIHudLobbyLWPlayerStateView m_View;

	private BHGGAEEHJCO m_BindPlayerID;

	private Player m_BindPlayer;

	private UIHudLobbyLWStreakIconController m_StreakIconCtrl;

	private ELobbyLWPlayerHudState m_CurrentState;

	private AudioPlaybackParams_Unity m_PlayParam;

	private uint m_LastStreak;

	private const int HP_REFRESH_INTERVAL = 5;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override void LateUpdate()
	{
	}

	private void TryResolveBind()
	{
	}

	public void BindPlayer(BHGGAEEHJCO playerID)
	{
	}

	public void UnbindPlayer()
	{
	}

	public void RefreshAll()
	{
	}

	public void RefreshTeamBg()
	{
	}

	private uint GetWinStreak()
	{
		return 0u;
	}

	private void RefreshStateBySubGame()
	{
	}

	public void RefreshPlayerName()
	{
	}

	public void RefreshHP()
	{
	}

	public void RefreshStreak(uint streak)
	{
	}

	public void SetState(ELobbyLWPlayerHudState state)
	{
	}

	public ELobbyLWPlayerHudState GetState()
	{
		return ELobbyLWPlayerHudState.Observer;
	}

	private void OnCameraModeVisibilityStateChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_LateUpdate()
	{
	}
}
