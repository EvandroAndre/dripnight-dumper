using UnityEngine;

namespace COW;

public class UIHudMapThrowerItem : MonoBehaviour
{
	public UISprite ItemNormalBG;

	public UISprite ItemSelectBG;

	public UISprite ItemTxtBG;

	public float StartAngle1;

	public float EndAngle1;

	public float StartAngle2;

	public float EndAngle2;

	private uint m_ItemId;

	private bool m_IsSelect;

	private void SetGameObjectActive(GameObject go, bool flag)
	{
	}

	public void SetConfigData(uint itemId)
	{
	}

	public void SetSelectState(bool isSelect)
	{
	}

	public void SendMapThrowerRequest()
	{
	}
}
