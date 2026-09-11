using GCommon;

namespace COW;

internal class UIHudSwimmingSurfController : UIHudButtonBaseController
{
	private UIHudSwimmingSurfView m_View;

	private const string SpriteWaterSurfing = "UI_icon_WaterSurfing";

	private const string SpriteWaterSurfingHighlight = "UI_icon_WaterSurfing_Choose";

	private bool mIsHighlight;

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

	private void Update()
	{
	}

	private void OnShowSwimmingSurfHud(object[] param)
	{
	}

	private void SetHighLight(bool highlight)
	{
	}

	private void SetSwimmingSurfIconView(string spriteName, bool useHighlightColor = false)
	{
	}

	private void RefreshCanSurfNoticeVfx()
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
