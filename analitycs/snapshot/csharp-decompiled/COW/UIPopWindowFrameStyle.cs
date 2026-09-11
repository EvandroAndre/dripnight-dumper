using GCommon;
using UnityEngine;

namespace COW;

public class UIPopWindowFrameStyle : MonoBehaviour
{
	public UIPopupWindowController parentPopupWindow;

	public UIFrameSize frameSize;

	public string titleKey;

	public bool unuseCloseBtn;

	public UIPopWindowFrameController frameController;

	public void InitStyle(GameObject framePrefab, UIBaseController parentController)
	{
	}

	public static ResourceID GetFrameResourceId(UIFrameSize size)
	{
		return default(ResourceID);
	}

	public void UpdateFrameTitleKey(string newKey)
	{
	}

	public void UpdateCloseBtnView(bool isShow)
	{
	}
}
