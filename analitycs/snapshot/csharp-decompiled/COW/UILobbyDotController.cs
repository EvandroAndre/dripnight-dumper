using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyDotController : UIBaseController
{
	protected UILobbyDotView m_View;

	public int DotIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetSelected(bool v)
	{
	}

	public void SetWidth(int width)
	{
	}

	public void SetHeight(int height)
	{
	}

	public void SetDepth(int depth)
	{
	}

	public void SetDotSpriteType(UIBasicSprite.Type type)
	{
	}

	public void SetDotSprite(string enable, string disable, bool makePixelPerfect = true)
	{
	}

	public void SetDotSprite(UISprite enable, UISprite disable, Vector3 scale)
	{
	}

	public void SetDotEnableBG(bool isShow)
	{
	}

	public void SetDotColor(Color enableColor, Color disableColor)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
