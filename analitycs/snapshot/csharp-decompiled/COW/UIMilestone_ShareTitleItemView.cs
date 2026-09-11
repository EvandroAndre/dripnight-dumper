using GCommon;
using UnityEngine;

namespace COW;

public class UIMilestone_ShareTitleItemView : UIBaseView
{
	public UIEventListener ShareItemEventListener;

	public UIWidget ShareItemWidget;

	public UINetworkTextureExt TitleTexture;

	public GameObject DragGo;

	public UINetworkTextureExt DragTexture;

	public UINetworkTextureExt DragFlagTexture;

	public UILabel TitleLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
