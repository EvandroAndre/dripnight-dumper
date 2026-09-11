using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_Template_LobbyIconWndView : UIBaseView
{
	public UINetworkTexture IconTexture;

	public UILabel IconLabel;

	public Transform IconEffectContainer;

	public Animation main;

	public Transform FlyEffectContainer;

	public UISprite IconSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
