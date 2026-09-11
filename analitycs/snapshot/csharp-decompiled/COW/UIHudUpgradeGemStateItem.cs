using UnityEngine;

namespace COW;

public class UIHudUpgradeGemStateItem : MonoBehaviour
{
	public UISprite[] GemIcon1;

	public UISprite[] GemIcon2;

	public UISprite[] GemIcon3;

	private UISprite[] m_CurrentGemIconGroup;

	private uint m_CurrentExpCnt;

	public void SetCurrentGemIconGroup(uint expCnt)
	{
	}

	public void SetGemIconState(byte completeCnt, byte fragment)
	{
	}
}
