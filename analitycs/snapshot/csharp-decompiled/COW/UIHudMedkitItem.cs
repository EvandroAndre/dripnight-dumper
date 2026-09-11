using UnityEngine;

namespace COW;

public class UIHudMedkitItem : MonoBehaviour
{
	public UISprite ItemNormalBG;

	public UISprite ItemSelectBG;

	public UISprite ItemTxtBG;

	public UILabel ItemTxt;

	public UISprite ItemDisable;

	public float StartAngle1;

	public float EndAngle1;

	public float StartAngle2;

	public float EndAngle2;

	private Color m_SelectedColor;

	private Color m_EmptyColor;

	private CureGearSettingData m_ConfigData;

	private MedkitRouletteEnum m_CurState;

	private bool m_IsSelect;

	private int m_CurCount;

	private void Awake()
	{
	}

	private void SetGameObjectActive(GameObject go, bool flag)
	{
	}

	public void SetConfigData(CureGearSettingData configData)
	{
	}

	public void RefreshItemState()
	{
	}

	public void SetState(MedkitRouletteEnum state)
	{
	}

	public void SetSelectState(bool isSelect)
	{
	}

	public void SendMedkitRequest()
	{
	}

	public bool isHasItem()
	{
		return false;
	}

	public void Update()
	{
	}
}
