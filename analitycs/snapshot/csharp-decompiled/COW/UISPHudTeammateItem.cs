using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class UISPHudTeammateItem : UIHudTeammateItem
{
	public UISprite WeaponIcon;

	public GameObject FiringGo;

	public UILabel killCount;

	public GameObject ReviveGo;

	public GameObject GoGradeLv1;

	public GameObject GoGradeLv2;

	public GameObject GoGradeLv3;

	public GameObject GoGradeAwaken;

	public GameObject QualityMark1;

	public GameObject QualityMark2;

	public GameObject QualityMark3;

	public GameObject SkyGo;

	public GameObject BuyItemContainer;

	public UISprite BuyItemSprite;

	public Animation BuyItemAnim;

	public GameObject TeamIndexBG;

	public GameObject BG;

	public UITexture CustomTeamIndexBG;

	public UITexture CustomBG;

	public GameObject SamoAI;

	private const string CUSTOM_TEAM_INFO_BG_NAME = "TeamPlayerBackground";

	private const string CUSTOM_TEAM_INDEX_BG_NAME = "TeamPlayer";

	private List<uint> m_ItemIds;

	private float m_NextPlayAnimTime;

	private uint m_InterruptFrameNum;

	private int weapon_origin_width;

	private int weapon_origin_height;

	private uint m_SwitchSkyDelayCall;

	private Player m_Player;
}
