using GCommon;
using UnityEngine;

namespace COW;

public class UITailorEntranceItemView : UIBaseView
{
	public UINetworkTexture NetwrokTexture;

	public GameObject Lock;

	public GameObject UnLock;

	public UILabel Current;

	public UILabel All;

	public GameObject LimitedAndLock;

	public UISprite IPTag;

	public UILabel ThemeName;

	public UIButton EntranceBtn;

	public UIButton ObtainBtn;

	public GameObject Complete_C;

	public GameObject Progress_C;

	public Transform Container;

	public Transform Tips;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
