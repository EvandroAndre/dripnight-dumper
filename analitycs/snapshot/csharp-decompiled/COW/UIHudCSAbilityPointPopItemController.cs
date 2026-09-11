using GCommon;

namespace COW;

public class UIHudCSAbilityPointPopItemController : UIBaseController
{
	private UIHudCSAbilityPointPopItemView m_View;

	private uint m_Level;

	private uint m_SetId;

	private string m_UpHalfLineSpriteDefault;

	private string m_DownHalfLineSpriteDefault;

	private string m_ActiveBgSpriteDefault;

	private string m_DeactiveBgSpriteDefault;

	private bool m_PendingRefresh;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetLevelData(uint level)
	{
	}

	private void RecordDefaultSkinInfo()
	{
	}

	private void SetSkin(bool resetToDefault = false)
	{
	}

	private void RefreshSetIcon()
	{
	}

	private void RefreshState()
	{
	}

	private void OnUpdateCSAbilityPointInfo()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
