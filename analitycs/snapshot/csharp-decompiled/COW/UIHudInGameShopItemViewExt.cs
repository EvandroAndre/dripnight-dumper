using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInGameShopItemViewExt : UIHudInGameShopItemView
{
	public enum CoinIconType
	{
		ExchangeToken,
		ShopCoin,
		TrainingToken,
		PVEToken
	}

	public static readonly Color LimitColor;

	public static readonly Color RareItemNameColor;

	public static readonly Color DiscountPriceColor;

	private BitArrayBoolean m_ShowGraySprite;

	public const uint ISUNLOCK = 1u;

	public const uint TOKEN_LACK = 2u;

	public const uint CAPACITY_LACK = 4u;

	public const uint LIMIT_LACK = 8u;

	public const uint PLIERS_NOTOK = 16u;

	public const uint IN_CD = 32u;

	public const uint NOT_MY_TURN = 64u;

	public const uint POINT_LACK = 128u;

	public const uint GAMEMISSION_LOCK = 256u;

	public const uint TIME_LIMIT = 512u;

	public const uint BATTLE_LEVEL_LIMIT = 1024u;

	public const uint BATTLE_STYLE_ABILITY_LIMIT = 2048u;

	public const uint BOOYAH_BOUNTY_LIMIT = 4096u;

	public const uint EP_FULL = 8192u;

	public const uint TEAM_LIMIT_LACK = 16384u;

	public const uint CS_ABILITY_POINT_SINGLE_PURCHASE_LIMIT = 32768u;

	public const uint START_SALE_TIME_LIMIT = 65536u;

	public UITimeLabelHelper m_TimeHelper;

	public UITimeLabelHelper m_LimitTimer;

	private bool m_StaticInited;

	public uint m_CSMysteryBoxVFXHolder;

	private bool m_HasDiscountPrice;

	private Vector3 m_ItemSpriteScale;

	private Quaternion m_ItemSpriteRotation;

	public void OnInit()
	{
	}

	public void ResetForRecycle()
	{
	}

	public void SetUIData(HENEHAGJCLI itemData1, uint count1, bool showSkin = false, HENEHAGJCLI itemData2 = null, uint price = 0u, uint quality = 0u, bool hasBonus = false, bool isLimited = false, bool showNewTag = false, bool showCoin = true, CoinIconType coinType = CoinIconType.ShopCoin, bool forceInit = false, bool showNewbieRecommendIcon = false, bool hidePrice = false, bool showNewTagIcon = false, bool isTeamLimited = false, bool isSurpriseItem = false, uint originalPrice = 0u, bool useResShowImage = false)
	{
	}

	private void OnItemSpriteSetSpriteNameAsyncSuccess()
	{
	}

	private void ForceUpdateAnchorsWhenItemChange()
	{
	}

	public void RefreshPriceAndLimit(uint price, bool isLimited)
	{
	}

	private void SetImageInOtherAtlas(bool hasBonus, bool showNewTag)
	{
	}

	public void UpdateGrayCondition(uint condType, bool condValue, bool playFadeOut = false)
	{
	}

	private void SetBooyahBountyIcon()
	{
	}

	public bool IsAvailable()
	{
		return false;
	}

	public void RefreshShortCoinStatus(bool shortCoin)
	{
	}

	public void RefreshLimiteStatus(bool isLimited)
	{
	}

	public void RefreshTeamLimiteStatus(bool isLimited)
	{
	}

	public static string GetCoinIconByType(CoinIconType iconType)
	{
		return null;
	}

	public static bool ShouldUseStoreShowImage(HENEHAGJCLI itemData)
	{
		return false;
	}

	public static Vector3 GetStoreShowImageItemSpriteScale()
	{
		return default(Vector3);
	}

	public static Quaternion GetStoreShowImageItemSpriteRotation()
	{
		return default(Quaternion);
	}

	private static bool IsWeaponUpgradeInfoItem(uint itemId)
	{
		return false;
	}

	private static bool IsWeaponPreviewReplacerItem(HENEHAGJCLI itemData)
	{
		return false;
	}

	private static bool IsWeaponReplacerItem(uint itemId)
	{
		return false;
	}

	private static bool IsWeaponItem(uint itemId)
	{
		return false;
	}

	public void RefreshNewTag(uint itemID)
	{
	}

	public void Update()
	{
	}

	private void _003CUpdateGrayCondition_003Eb__36_0()
	{
	}
}
