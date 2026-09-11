using UnityEngine;

namespace COW;

public class UIHudPlayerEPItem : MonoBehaviour
{
	public UISprite EPBarBG;

	public UISprite EPBar;

	public UISprite EPBarGradient;

	public UISprite MushRoomEPBar;

	public void Show(bool show)
	{
	}

	public void SetWidth(int width)
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public void SetEPValue(float EPRatio, bool isGradient, Color topColor, Color bottomColor, Color EPColor)
	{
	}

	public void RefreshMushroomEp(bool show, float mushroomEPRatio = 0f, float EPRatio = 0f)
	{
	}
}
