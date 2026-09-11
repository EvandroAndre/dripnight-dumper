using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchWarmUpView : UIBaseView
{
	public UINetworkTexture BGCDNTexture;

	public UIButton BtnClose;

	public UILabel WarmUpTitle;

	public UINetworkTexture TitleCDNTexture;

	public UIButton BtnCupMatch;

	public UILabel BtnCupMatchLabel;

	public UILabel LabelStatus;

	public UILabel LabelSeason;

	public UICountDownLabel LabelCountDown;

	public UIButton BtnArena;

	public UINetworkTexture DefaultBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
