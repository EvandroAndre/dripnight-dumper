using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditOfflineModeMainView : UIBaseView
{
	public UIButton CloseBtn;

	public UIButton HelpBtn;

	public UITable UGCTable;

	public UIScrollView ScrollView;

	public UIButton TrainingGround;

	public UIButton More;

	public UITable UGCMapsTable;

	public UILabel MapNameTxt;

	public UILabel MapModeTxt;

	public UILabel LikeLabel;

	public UILabel LabelSubscribeCount;

	public UINetworkTexture CDNMapIcon;

	public UISprite MapIcon;

	public UIPanel miniMapPanel;

	public GameObject GameMap;

	public UITexture GameMapBg;

	public UITexture GameBitMap;

	public UITexture GameBitOutLineMap;

	public UISprite IconItemSpite;

	public Transform FilledMap;

	public Transform Minor;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
