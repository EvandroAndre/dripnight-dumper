using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudTakeTurnsShopItemViewExt : UIHudTakeTurnsShopItemBaseView
{
	public enum CoinIconType
	{
		ExchangeToken,
		ShopCoin,
		TrainingToken
	}

	private BitArrayBoolean m_ShowGraySprite;

	public const uint ISUNLOCK = 1u;

	public const uint TOKEN_LACK = 2u;

	public const uint CAPACITY_LACK = 4u;

	public const uint LIMIT_LACK = 8u;

	public const uint PLIERS_NOTOK = 16u;

	public const uint IN_CD = 32u;

	public const uint NOT_MY_TURN = 64u;

	private Color limitColor;

	private Camera m_Camera;

	private UICamera m_UICamera;

	private float dist;

	public void OnInit()
	{
	}

	public void SetUIData(HENEHAGJCLI itemData1, uint count1, bool showSkin = false, HENEHAGJCLI itemData2 = null, uint price = 0u, uint quality = 0u, bool hasBonus = false, bool isLimited = false, bool showNewTag = false, bool showCoin = true, CoinIconType coinType = CoinIconType.ShopCoin)
	{
	}

	private void SetImageInOtherAtlas(bool hasBonus, bool showNewTag)
	{
	}

	public void UpdateGrayCondition(uint condType, bool condValue, bool playFadeOut = false)
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

	public static string GetCoinIconByType(CoinIconType iconType)
	{
		return null;
	}

	private bool CheckPos(Vector2 pos)
	{
		return false;
	}

	private bool CheckPCTouch(Vector3 pos)
	{
		return false;
	}

	private bool CheckMobileTouch()
	{
		return false;
	}

	private void TryGetCameraComponent()
	{
	}

	public void Update()
	{
	}

	private void _003CUpdateGrayCondition_003Eb__16_0()
	{
	}
}
