using GCommon;
using UnityEngine;

namespace COW;

public class UILegendClothVaultSlotItemController : UIPopupWindowController
{
	private UILegendClothVaultSlotItemView m_View;

	private UIModelAvatarBase.EWardrobeType m_WardrobeType;

	private LegendClothVaultPageType m_PageType;

	private Color m_WearingColor;

	private Color m_NotWearingColor;

	private const uint InvalidClothId = 0u;

	private uint _003CClothId_003Ek__BackingField;

	private int _003CLevel_003Ek__BackingField;

	private bool _003CIsWearing_003Ek__BackingField;

	private bool m_IsGenderValid;

	public uint ClothId
	{
		get
		{
			return _003CClothId_003Ek__BackingField;
		}
		private set
		{
			_003CClothId_003Ek__BackingField = value;
		}
	}

	public int Level
	{
		get
		{
			return _003CLevel_003Ek__BackingField;
		}
		private set
		{
			_003CLevel_003Ek__BackingField = value;
		}
	}

	public bool IsWearing
	{
		get
		{
			return _003CIsWearing_003Ek__BackingField;
		}
		private set
		{
			_003CIsWearing_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetData(UIModelAvatarBase.EWardrobeType wardrobeType, uint clothId, int level = -1)
	{
	}

	public void SetPageType(LegendClothVaultPageType pageType)
	{
	}

	private void OnClickBtnChoose()
	{
	}

	private void OnClickBtnCancel()
	{
	}

	public void RefreshView()
	{
	}

	public void SetIsGenderValid(bool isGenderValid)
	{
	}

	public void SetIsWearing(bool isWearing)
	{
	}

	public void SetSlotBgRotate(UIModelAvatarBase.EWardrobeType wardrobeType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
