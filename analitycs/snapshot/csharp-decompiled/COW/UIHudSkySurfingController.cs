using GCommon;

namespace COW;

internal class UIHudSkySurfingController : UIHudButtonBaseController
{
	private UIHudSkySurfingView m_View;

	private bool m_IsHighlight;

	private bool m_HaveFlilght;

	private const string m_SkySurfingIcon = "UI_icon_SkydivingStance";

	private const string m_SkySurfingIconHighLight = "UI_icon_SkydivingStance_choose";

	private const string m_SkyFlightSurfingIcon = "UI_icon_Mounts_Dive";

	private const string m_SkyFlightSurfingIconHighLight = "UI_icon_Mounts_Dive_Choose";

	public const uint VISIBILITY_STATE_FAST_FALLING = 1073741824u;

	private uint m_IIVWeakEffect;

	private uint m_IIVEffect;

	private uint m_FullScreenVfxId;

	private const string m_IIVFastFallingIcon = "FF_UI_IIV_GP_icon_Skyexits";

	private const string m_IIVFastFallingIconHighLight = "FF_UI_IIV_GP_icon_Skyexits_choose";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitIsNewUI()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	private void RefreshVisibilityWithFastFalling(bool isEnter)
	{
	}

	private void SetHightlight(bool highlight, bool haveFlilght)
	{
	}

	private void RefreshIcon()
	{
	}

	private void SetSkySurfingIconView(string spriteName, bool useHighlightColor = false)
	{
	}

	private void OnStopSkySurfing(object[] param)
	{
	}

	private void OnSkydivingBackToOnBoard()
	{
	}

	private void OnStartSkyDiving()
	{
	}

	private void OnShowSurfingTutorial(object[] param)
	{
	}

	private void OnLocalPlayerTeamParachuteModeChange(object[] param)
	{
	}

	protected override void OnBtnDown()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}
}
