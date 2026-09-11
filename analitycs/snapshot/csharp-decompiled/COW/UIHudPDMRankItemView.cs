using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPDMRankItemView : UIBaseView
{
	public GameObject SelfLight;

	public GameObject UpRoot;

	public GameObject DownRoot;

	public UILabel RankLabel;

	public UILabel PlayerNameLabel;

	public UILabel KillNumLabel;

	public GameObject FirstRankSprite;

	public UISprite KillIcon;

	public Animation UIHudPDMRankItem;

	public GameObject UIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
