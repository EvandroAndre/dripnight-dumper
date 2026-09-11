using GCommon;

namespace COW;

public class UIPrimeSettingPopUpController : UIPopupWindowController
{
	private enum PrimeSettingUIType
	{
		SettingItem,
		Line
	}

	private UIPrimeSettingPopUpView m_View;

	private UIModelPrime m_ModelPrime;

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

	public void SetViewData()
	{
	}

	private void InitTemplate()
	{
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__7_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__7_1()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
