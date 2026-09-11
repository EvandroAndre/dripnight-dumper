using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudWLSnowSlidePlayerStatsController : UIHudButtonBaseController
{
	public const string BUTTON_MAPPING_NAME = "WLSnowSlidePlayerStats";

	private UIHudWLSnowSlidePlayerStatsView m_View;

	private bool m_GetOn;

	private float m_CdTime;

	private float m_LeftTime;

	private uint m_SnowSlideEnergyFullVfxHolder;

	private readonly ResourceID m_CanUseHintVfxRes;

	private VisualInstanceHolder m_CanUseHintVfxHolder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void OnEnergyChange(object[] data)
	{
	}

	private void PlayEnergyFullVfx()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnPlayerStateChange(GEvent data)
	{
	}

	private void OnAddLocalPlayer(object[] data)
	{
	}

	private void OnObservePlayer(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnActionBtnClick()
	{
	}

	private void OnPickUpSnowSlideItem(object[] data)
	{
	}

	private void UpdateShowHide()
	{
	}

	private void UpdateOnOff(Player localPlayer)
	{
	}

	private void SetGetOn(bool getOn)
	{
	}

	private void UpdateCdBar(Player localPlayer)
	{
	}

	private void HideCdBar()
	{
	}

	private void Update()
	{
	}

	private void ShowCdBar(float cd, float remain)
	{
	}

	private void OnPlayerSnowSlideChange()
	{
	}

	private void CheckShowSnowSlideEquipmentUseHint()
	{
	}

	private void ShowCanUseHintVfx(bool show)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
