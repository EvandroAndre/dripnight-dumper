using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchResultTaskItemView : UIBaseView
{
	public UILabel Desc;

	public UILabel ProcessLabel;

	public GameObject Gained;

	public GameObject Anim;

	public Animation Animation;

	public GameObject GainedIcon;

	public GameObject TaskInfo;

	public UISprite TaskTypeIcon;

	public UINetworkTexture TaskTypeIconNetTexture;

	public UITexture TaskTypeIconTexture;

	public UIGrid AwardItemGrid;

	public UIScrollView AwardItemScrollView;

	public BoxCollider Drag;

	public GameObject SpecialView;

	public UIGrid ProgressGrid;

	public UIButton specialBg;

	public UILabel specialProcessLabel;

	public GameObject specialIcon;

	public Transform CountDownTransForm;

	public UILabel CountDownLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
