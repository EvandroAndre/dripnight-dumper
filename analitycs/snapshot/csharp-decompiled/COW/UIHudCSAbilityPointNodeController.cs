using GCommon;

namespace COW;

public class UIHudCSAbilityPointNodeController : UIBaseController
{
	protected UIHudCSAbilityPointNodeView m_View;

	private uint m_Level;

	private uint m_SetId;

	private bool m_IsRandomNode;

	private bool m_IsChoose;

	private bool m_StateDirty;

	private string m_DisableGgSpriteDefault;

	private string m_EnableBGSpriteDefault;

	private ResourceID m_PowerUpAbilityPointUnlockFXDefault;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(uint level)
	{
	}

	private void RecordDefaultSkinInfo()
	{
	}

	private static ResourceID GetVFXHelperDefaultResId(VFXCreateHelper vfxHelper)
	{
		return default(ResourceID);
	}

	private void SetSkin(bool resetToDefault = false)
	{
	}

	public void TryPlayRandomAnim()
	{
	}

	private void RefreshSetIcon()
	{
	}

	private void RefreshState()
	{
	}

	private void ResetChoosedItemContainers()
	{
	}

	private void RefreshChoosedItemState()
	{
	}

	private void OnAbilityPointSelected(uint level)
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void OnUpdateCSAbilityPointInfo()
	{
	}

	private void OnCSAbilityPointChanged(int newValue, int oldValue)
	{
	}

	private void OnCSAbilityPointCanChooseLevelChanged(uint newValue, uint oldValue)
	{
	}

	private void LateUpdate()
	{
	}

	private void OnAbilityPointBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
