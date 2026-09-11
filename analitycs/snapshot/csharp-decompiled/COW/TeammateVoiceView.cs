using COW.GamePlay;
using UnityEngine;

namespace COW;

public class TeammateVoiceView : MonoBehaviour
{
	public GameObject MuteQuickChatGo;

	public GameObject UnMuteQuickChatGo;

	public UIButton MuteQuickChatBtn;

	public UISprite IndexBg;

	public UILabel NameLabel;

	public UILabel IndexLabel;

	public UIButton MuteToggleBtn;

	public UISprite MutedSprite;

	public UISprite NotMuteSprite;

	public UISprite ReportMuteSprite;

	public UIButton ReportBtn;

	public UISprite ReportedSprite;

	public UISprite CanReportSprite;

	public UISlider VolumeBar;

	public GameObject ReportBtnGroup;

	private TweenAlpha NoiceTween;

	public Vector2 ViewSize;

	private string Bind_UserID;

	private ulong m_UserID;

	private string m_ClientVersion;

	private uint m_ClientType;

	private BHGGAEEHJCO m_PlayerID;

	private bool m_IsMute;

	private UISprite m_FillBar;

	private static readonly Color volumeBarGray;

	private static readonly Color volumeBarYellow;

	public static bool IsReportBtnOn;

	public static bool IsVolumeControlOn;

	private bool m_RecoverVolume;

	private float m_VolumeBarValue;

	private uint m_delayID;

	private bool m_IngameHud;

	public string BindID => null;

	private bool m_IsReportedSuccess => false;

	public bool IsMute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetMute(bool isMute, bool skipBehaviorMuteChange = false)
	{
	}

	private void SendMuteChange()
	{
	}

	public void SetMuteRoom()
	{
	}

	public void Init(int team_index, ulong user_id, string nick_name, BHGGAEEHJCO playerID)
	{
	}

	public void InitWithoutPlayer(int team_index, ulong user_id, string nick_name)
	{
	}

	private void InitData(int team_index, ulong user_id, string nick_name, bool cur_mute_flag)
	{
	}

	private void OnMuteToggle()
	{
	}

	private void OnMuteQuickChatBtnClicked()
	{
	}

	private void RefreshMuteQuickChatBtn()
	{
	}

	private void OnReortClick()
	{
	}

	private void TryReportToGs()
	{
	}

	public void OnMuteStateChange(object[] data)
	{
	}

	private void OnChannelResume(object[] data)
	{
	}

	public void SwitchReport()
	{
	}

	private void RefreshView(bool isMute, bool isInit = false)
	{
	}

	private void SetTeamateVolume()
	{
	}

	private void ResetViewOnDisableVolumeBar()
	{
	}

	private void OnVoiceStateChange(object[] data)
	{
	}

	private void OnOwnPlayerChange(object[] data)
	{
	}

	private void ResetVoice()
	{
	}

	public void SetInGame(bool value)
	{
	}
}
