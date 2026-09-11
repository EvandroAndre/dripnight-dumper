using UnityEngine;

namespace COW;

public class BaseItemView : BaseItemView2
{
	private UIUtils.SpriteScaleType m_SpriteFixedType;

	public bool m_ItemUsePerfect;

	public UISprite m_ItemBigIconSprite;

	public UISprite m_TreasureBoxSprite;

	public UISprite m_BackpackSprite;

	public UISprite m_ParachuteSprite;

	public UISprite m_HeadPicSprite;

	public UISprite m_CallSignSprite;

	public UISprite m_BundleSprite;

	public UISprite m_ClothesSprite;

	public UISprite m_SurfboardSprite;

	public UISprite m_GrowthCardSprite;

	public UISprite m_DebrisSprite;

	public UISprite m_VirtualSprite;

	public UISprite m_WeaponSprite;

	public UISprite m_SuitWeaponSprite;

	public UISprite m_VehicleSprite;

	public UISprite m_AvatarSprite;

	public UISprite m_EmoteSprite;

	public UISprite m_PetAnimSprite;

	public UISprite m_VoucherSprite;

	public UISprite m_RedEnvelopeSprite;

	public UISprite m_FlightSprite;

	public bool m_UseBigIcon;

	private void Awake()
	{
	}

	private void SetCustomizedIconInfos()
	{
	}

	private void SetCustomizedIconInfo(UISprite tarSprite, uint itemType, uint subType = 0u, uint additionalFlag = 0u)
	{
	}

	private BaseItemViewIconInfo MakeIconInfo(UISprite tarSprite)
	{
		return null;
	}

	private void CloseAllIcons()
	{
	}

	public virtual void SetViewData(BaseItemInfo m_Data)
	{
	}

	protected override void SetDimensionsWithoutCustomized(UISprite icon, Vector2 size)
	{
	}

	private Vector2 GetDefaultSpriteScale()
	{
		return default(Vector2);
	}

	private UISprite GetDefaultSprite()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetDimensionsWithoutCustomized(UISprite P0, Vector2 P1)
	{
	}
}
