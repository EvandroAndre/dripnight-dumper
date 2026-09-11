using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UITopButtonGotoTokenController : UIBaseController, IUIModelDataChangeObserver
{
	public enum GotoIconStyle
	{
		None,
		Plus,
		Arrow
	}

	public const string YELLOW_COLOR_STR = "#F5B902";

	public const string WHITE_COLOR_STR = "#FFFFFF";

	private const int m_StandardCommonTokenWidth = 28;

	private const int m_StandardCommonTokenHeight = 28;

	private EInventory.AwardType m_TokenType;

	private uint m_TokenID;

	private string m_TokenDescKey;

	private bool m_HideAmount;

	private bool m_HideAmountIfZero;

	private GotoIconStyle m_GotoIconStyle;

	private UITopButtonGotoTokenView m_View;

	private UINavigationTopbarViewData.GotoTokenDetailData m_DetailData;

	private bool IsReady => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnCoinsUpdate(object[] data)
	{
	}

	private void SetupDefaultState()
	{
	}

	private void AdjustStandardTokenSize()
	{
	}

	private void SetupTokenIcon(string customizedSprite, UIUtils.SpriteScaleType scaleType, bool makePixelPerfect, bool hideTokenSprite)
	{
	}

	private void SetupGotoIconStyle()
	{
	}

	private void SetupTokenDesc()
	{
	}

	private void SetupTokenAmountColorInternal(Color color)
	{
	}

	private void SetupTokenDescColorInternal(Color color)
	{
	}

	private void SetupGotoIconColorInternal(Color color)
	{
	}

	private bool GachaNeedUpdateToken()
	{
		return false;
	}

	private bool RefreshTokenAmount()
	{
		return false;
	}

	private static bool IsSupportedTokenType(EInventory.AwardType tokenType)
	{
		return false;
	}

	private static bool IsStandardSizeTokenType(EInventory.AwardType tokenType)
	{
		return false;
	}

	private void BindOnGotoBtnClick(EventDelegate.Callback onGotoBtnClick = null)
	{
	}

	private void BindOnConvertBtnClick(EventDelegate.Callback onConvertBtnClick = null)
	{
	}

	private void OnGotoTokenLayoutChanged()
	{
	}

	internal void SetViewData(UINavigationTopbarViewData.GotoTokenDetailData detailData)
	{
	}

	public void SetupTokenDescColor(string colorStr)
	{
	}

	public void SetupGotoIconColor(string colorStr)
	{
	}

	public Vector3 GetTokenAmountLabelCenterPos()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
