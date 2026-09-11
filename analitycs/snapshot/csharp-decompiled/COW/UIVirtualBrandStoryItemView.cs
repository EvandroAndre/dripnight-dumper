using GCommon;
using UnityEngine;

namespace COW;

public class UIVirtualBrandStoryItemView : UIBaseView
{
	public UISprite SelectedLogo;

	public GameObject Selected;

	public UIButton BtnSelect;

	public UISprite UnSelectedLogo;

	public GameObject Unselect;

	public Transform DownloadNode;

	public UISprite SelectedLogoName;

	public UISprite UnSelectedLogoName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
