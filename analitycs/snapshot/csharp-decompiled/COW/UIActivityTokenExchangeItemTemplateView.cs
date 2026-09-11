using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityTokenExchangeItemTemplateView : UIBaseView
{
	public UIWidget UIActivityTokenExchangeItemTemplate;

	public UIButton Operation;

	public Animation ButtonAnimation;

	public GameObject IncompleteBtnBg;

	public GameObject ClaimBtnBg;

	public GameObject GainedBg;

	public UILabel GainedLabel;

	public UILabel Title;

	public UIToggle RedTipsOnOff;

	public GameObject ProgressIcon;

	public UILabel ProgressTips;

	public GameObject PlusSprite;

	public GameObject OrLabel;

	public UITable ItemTable;

	public Transform Arrow;

	public UITable ExchangeItemTable;

	public GameObject RedTipLabel;

	public GameObject main;

	public UINetworkTexture ClaimBtnCdn;

	public UINetworkTexture IncompleteBtnCdn;

	public GameObject MissionBg;

	public UINetworkTexture MissionBgCnd;

	public UINetworkTexture BigPrizeCnd;

	public GameObject TimeLockIcon;

	public UILabel TimeCountTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
