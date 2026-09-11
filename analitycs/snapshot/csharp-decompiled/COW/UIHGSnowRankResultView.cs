using GCommon;
using UnityEngine;

namespace COW;

public class UIHGSnowRankResultView : UIBaseView
{
	public UILabel LabelRank;

	public UILabel LabeModeName;

	public UIGrid AwardGrid;

	public UIButton BtnConfirm;

	public Animation MainAnim;

	public GameObject HighRank;

	public GameObject MidRank;

	public GameObject LowRank;

	public UINetworkTexture CDN;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
