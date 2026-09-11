using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class UIHudSeafoodLittleGirlMapMark : MonoBehaviour
{
	private LevelSeafoodLittleGirl m_littleGirl;

	public float BaseSize;

	public UISprite m_Icon;

	public GameObject m_range;

	public GameObject m_startScanEffect;

	public void SetViewData(LevelSeafoodLittleGirl girl, float scale)
	{
	}

	private void StateChangeCallback()
	{
	}

	private void OnDestroy()
	{
	}
}
