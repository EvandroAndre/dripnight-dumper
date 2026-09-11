using GCommon;
using UnityEngine;

namespace COW;

public class UIReplayListItemView : UIBaseView
{
	public UILabel Kill;

	public UIButton ItemBtn;

	public UIButton DelBtn;

	public UIButton PlayBtn;

	public UIButton SaveBtn;

	public UILabel Day;

	public UILabel Time;

	public UILabel GameModeLabel;

	public GameObject GroupHCN;

	public UILabel GroupNum;

	public UILabel DeltaRating;

	public UILabel Rating;

	public GameObject BGLight;

	public GameObject BGDark;

	public UISprite SpriteMvp;

	public UISprite SpriteSvp;

	public UITable Table;

	public UISprite AchievementIcon;

	public GameObject WinSprite;

	public UILabel Rank;

	public GameObject CSShow;

	public GameObject CS_V;

	public UILabel V;

	public GameObject CS_F;

	public UILabel F;

	public UITable RankTable;

	public UIPanel AchievementPanel;

	public UIScrollView AchievementScrollView;

	public UISprite BRCupSprite;

	public GameObject RatingContainer;

	public GameObject RankContainer;

	public GameObject DebugSelected;

	public GameObject DebugUnselected;

	public UIButton DebugUploadToggle;

	public GameObject Highlight;

	public GameObject HighlightLabelContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
