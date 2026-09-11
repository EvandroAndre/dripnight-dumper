using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomTC_OpenPopupWndView : UIBaseView
{
	public GameObject UIBigEvent_CustomTC_OpenPopupWnd;

	public UIEventListener ClickMask;

	public Transform PrintEffect;

	public Transform SucessEffect;

	public UINetworkTexture BgTexture;

	public UINetworkTexture PrintTexture;

	public UINetworkTexture SuccessTexture;

	public UILabel SuccessLabel;

	public Animation OpenAniamtion;

	public Transform StartEffect;

	public UILabel PrintLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
