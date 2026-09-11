using GCommon;
using UnityEngine;

namespace COW;

internal class UI2dCommonController : UIBaseController
{
	private UI2dItemView m_View;

	public bool left;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetAnchorInspector(UIWidget item, GameObject go, int left, int right, int bottom, int top, float leftOri = 0f, float rightOri = 1f, float bottomOri = 0f, float topOri = 1f)
	{
	}

	protected override void OnUIInit()
	{
	}

	public void SetCommonDepth(int depth)
	{
	}

	public void setUIdata(CSSharedItemData info, EFrontendUIType type)
	{
	}

	private void SetSPSpriteWithInfo(BaseItemInfo itemInfo, UISprite iconSprite, bool isBigIcon = false)
	{
	}

	private void SetSpriteWithInfo(CSSharedItemData itemInfo, UISprite iconSprite, bool isBigIcon = false)
	{
	}

	private void SetComposeIcon(UISprite iconSprite, UISprite sprite)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
