using UnityEngine;

namespace COW;

public class NewPlayerGrowPathBaseItemView : MonoBehaviour
{
	public GameObject Main;

	public UISlider Progress;

	public GameObject FirstNodeCon;

	public GameObject NextLevelCon;

	public GameObject UnLockCon;

	public UILabel LevelLabel;

	public Transform AwardItem;

	public UISprite Foreground;

	public UISprite Background;

	public UISprite BackgroundLeft;

	public UISprite BackgroundRight;

	public UISprite SystemIcon;

	public UILabel SystemLabel;

	public GameObject SystemLockBg;

	public GameObject SystemUnLockBg;

	public UIButton SelectBtn;

	public UIButton SelectSystemBtn;

	public GameObject SelectCon;

	public GameObject Arrow;

	public GameObject RewardCon;

	public Animation SystemUnLockAnim;

	public TweenAlpha SystemUnLockBGTween;
}
