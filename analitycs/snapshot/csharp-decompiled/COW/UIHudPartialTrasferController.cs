using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudPartialTrasferController : UIBaseController
{
	private UIHudPartialTrasferView m_View;

	private UIItem m_DropItem;

	private BHGGAEEHJCO m_Receiver;

	private int m_DroppedCount;

	private UIClickMask m_ClickMask;

	private bool m_IsToken;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void CreateClickMask()
	{
	}

	private void DestroyClickMask()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void SetUIData(UIItem dropitem, BHGGAEEHJCO id)
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnComfirmBtnClick()
	{
	}

	private void OnMinusBtn()
	{
	}

	private void OnPlusBtn()
	{
	}

	private void RefreshCount(bool refreshSlider = true)
	{
	}

	private void RefreshSlider()
	{
	}

	private void OnCntValueChange()
	{
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
