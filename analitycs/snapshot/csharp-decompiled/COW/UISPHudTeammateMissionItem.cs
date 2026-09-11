using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class UISPHudTeammateMissionItem : MonoBehaviour
{
	public GameObject ItemBG;

	public UISprite MissionIcon;

	public UIProgressBar Progress;

	public UILabel MissionLabel;

	public UILabel CompleteLabel;

	public UILabel FailedLabel;

	public UILabel TimeLabel;

	public Animation missionAnimation;

	public UISprite MissionIconBG;

	private float m_TimeCount;

	private bool m_HasTimeWaring;

	private IPLIFLLGADH m_GameMission;

	private bool m_MissionClosed;

	private uint m_DelayCallHideItemID;

	private uint m_DelayCallShowResultID;

	private uint m_DelayCallPlayOutAnimID;

	private uint m_DelayDestroyID;
}
