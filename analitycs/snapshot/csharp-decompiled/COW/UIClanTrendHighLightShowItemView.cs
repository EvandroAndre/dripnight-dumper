using GCommon;
using UnityEngine;

namespace COW;

public class UIClanTrendHighLightShowItemView : UIBaseView
{
	public UILabel PlayerName;

	public UILabel PlayerHonor;

	public UIButton ProfileInfoBtn;

	public UINetworkTextureExt PlayerHeadTexture;

	public GameObject PlayerFakeHeadImage;

	public UILabel StreakTxt;

	public GameObject PlayerRankIcon;

	public GameObject WinStreak;

	public GameObject UIBRRankIcon;

	public GameObject UICSRankIcon;

	public UIEffectSprite PlayerHeadPic;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
