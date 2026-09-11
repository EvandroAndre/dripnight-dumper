using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRouletteItem : MonoBehaviour
{
	public UISprite ItemNormalBG;

	public UISprite ItemSelectBG;

	public UISprite ItemTxtBG;

	public UILabel ItemTxt;

	public float StartAngle1;

	public float EndAngle1;

	public float StartAngle2;

	public float EndAngle2;

	private Color m_SelectedColor;

	private uint m_Id;

	private bool m_IsSelect;

	private void Awake()
	{
	}

	public void SetUIData(CSVBaseData data)
	{
	}

	public void SetState(bool isSelect)
	{
	}

	public void SendChatRequest()
	{
	}
}
