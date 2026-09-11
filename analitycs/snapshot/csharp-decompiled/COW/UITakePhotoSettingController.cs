using GCommon;

namespace COW;

public class UITakePhotoSettingController : UIBaseController
{
	private ITakePhotoSettingObserver m_TakePhotoObserver;

	private UITakePhotoSettingView m_View;

	private UIClickMask m_ClickMask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetTakePhotoCtrl(ITakePhotoSettingObserver observer, TakePhotoSettingData settingData, bool needClickMask = true)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected void OnPlayerNameSettingBtn()
	{
	}

	protected void OnTeammateSettingBtn()
	{
	}

	public void RefreshSelected()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003COnUIInit_003Eb__4_0()
	{
	}

	private void _003COnUIInit_003Eb__4_1()
	{
	}

	private void _003COnUIInit_003Eb__4_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
