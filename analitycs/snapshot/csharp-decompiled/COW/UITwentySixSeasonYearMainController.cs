using GCommon;
using UnityEngine;

namespace COW;

public class UITwentySixSeasonYearMainController : UISeasonYearMainBaseController
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public UITwentySixSeasonYearMainController _003C_003E4__this;

		public int animType;

		internal void _003COnPlayStartAnim_003Eb__0()
		{
		}
	}

	private UITwentySixSeasonYearMainView m_View;

	private uint m_MainAnimDelayCall;

	private uint m_AfterPopAnimDelayCall;

	private uint m_AfterHarkAnimDelayCall;

	private uint m_StandIdleAnimDelayCall;

	private Animation m_UifxBgAnim;

	private UIMaleAvatar m_PlayerAvatar;

	private GameObject m_KingChairObj;

	private GameObject m_AvatarCamera;

	private UIModelAvatar m_ModelAvatar;

	private const float CHAIR_DELAY_TIME = 0.05f;

	private const float ANIM_DELAY_OFFSET = 0.05f;

	private const float DEFAULT_ANIM_LENGTH = 1f;

	private const float ANIM_LENGTH_THRESHOLD = 1f;

	private const int AVATAR_CAMERA_DEPTH = 4;

	private static readonly Vector3 CAMERA_POSITION;

	private static readonly Vector3 AVATAR_POSITION;

	private static readonly Vector3 AVATAR_SCALE;

	private static readonly Vector3 CHAIR_POSITION;

	private static readonly Vector3 CHAIR_ROTATION;

	private static readonly Vector3 CHAIR_SCALE;

	private const int PROGRESS_NODE_COUNT = 4;

	private const int DEFAULT_CS_RANK_ID = 20;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override uint GetSeasonYearId()
	{
		return 0u;
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnPlayStartAnim(object[] data)
	{
	}

	protected override void OnPlaySwitchAnim(uint seasonYearId)
	{
	}

	protected override void InitProgressDict()
	{
	}

	private void InitView()
	{
	}

	private void SetCDN()
	{
	}

	protected override void SetHeroicCntAndProgressView()
	{
	}

	protected override void SetRewardView()
	{
	}

	protected override void SetPointView()
	{
	}

	protected override void SetBRHeroicPointsView()
	{
	}

	protected override void SetCSHeroicPointsView()
	{
	}

	public override void PlayMainAnim(int animType)
	{
	}

	private void PlayPageAndHawkAnim()
	{
	}

	private void OnHeroicCntClick()
	{
	}

	private void ShowSwitchYearGuide()
	{
	}

	private void InitAvatarCamera()
	{
	}

	private void InitChair()
	{
	}

	private void CreatePlayerAvatar()
	{
	}

	public void SetPlayerAvatarVisible(bool visible)
	{
	}

	private void _003CPlayPageAndHawkAnim_003Eb__39_0()
	{
	}

	private void _003CPlayPageAndHawkAnim_003Eb__39_1()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public uint _003C_003EiFixBaseProxy_GetSeasonYearId()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlayStartAnim(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlaySwitchAnim(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_InitProgressDict()
	{
	}

	public void _003C_003EiFixBaseProxy_SetHeroicCntAndProgressView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetRewardView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetPointView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetBRHeroicPointsView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetCSHeroicPointsView()
	{
	}

	public void _003C_003EiFixBaseProxy_PlayMainAnim(int P0)
	{
	}
}
