using GCommon;
using UnityEngine;

namespace COW;

public class UIModeEditEntranceWndView : UIBaseView
{
	public UIButton Classic;

	public GameObject ClassicDefaultIcon;

	public UINetworkTexture ClassicCDNIcon;

	public GameObject ClassicLastTime;

	public UIButton Custom;

	public GameObject CustomDefaultIcon;

	public UINetworkTexture CustomCDNIcon;

	public GameObject CustomLastTime;

	public UIButton CustomLock;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
