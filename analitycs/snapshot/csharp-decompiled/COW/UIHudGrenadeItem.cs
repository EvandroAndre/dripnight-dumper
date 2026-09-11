using GCommon;
using UnityEngine;

namespace COW;

public class UIHudGrenadeItem : MonoBehaviour
{
	public UISprite ItemNormalBG;

	public UISprite ItemSelectBG;

	public UISprite ItemTxtBG;

	public UILabel ItemTxt;

	public UISprite ItemInfinityIcon;

	public UISprite ItemDisable;

	public GameObject ItemDisableUse;

	public float StartAngle1;

	public float EndAngle1;

	public float StartAngle2;

	public float EndAngle2;

	private Color m_SelectedColor;

	private Color m_EmptyColor;

	private GrenadeTypeSettingData m_ConfigData;

	private MedkitRouletteEnum m_CurState;

	private bool m_IsSelect;

	private uint m_ItemID;

	private uint m_FixedItemID;

	private int m_Index;

	public void OnInitUI(int index)
	{
	}

	private void SetGameObjectActive(GameObject go, bool flag)
	{
	}

	public void SetConfigData(uint itemID, ResourceID overrideIcon, bool isFixed = false)
	{
	}

	public string GetCountTxtByItemTypeAndCount(uint itemID, int count)
	{
		return null;
	}

	public void SetState(MedkitRouletteEnum state)
	{
	}

	public void SetSelectState(bool isSelect)
	{
	}

	public void SendGrenadeRequest()
	{
	}

	public bool isHasItem()
	{
		return false;
	}

	private void RefreshInfinityIcon()
	{
	}

	public void ForceRefreshInfityIcon()
	{
	}

	protected bool IsInfiniteIceWall()
	{
		return false;
	}

	private bool IsUnlimitedThrowables()
	{
		return false;
	}

	private void Update()
	{
	}

	private void UpdateDisableUseState()
	{
	}

	public bool IsDisableUse()
	{
		return false;
	}
}
