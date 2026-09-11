using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudSceneEditPutController : UIBaseController
{
	private UIHudSceneEditPutView m_View;

	private float mLastPutDownTime;

	private const string ENABLE_PUT_ICON = "UI_Customize_Confirm_icon";

	private const string DISABLE_PUT_ICON = "UI_Customize_Canot_icon";

	private bool m_CheckValid;

	private bool m_ItemGenPanelPop;

	private HNDHJGJILHC m_Game;

	private SceneEditAgent m_Agent;

	private SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshShow()
	{
	}

	private void RefreshDesc()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void UpdateConfirm()
	{
	}

	private bool CheckPutCooldown()
	{
		return false;
	}

	private void OnBtnConfirm()
	{
	}

	private void OnBtnCancel()
	{
	}

	private void TutorialPutDownBoj()
	{
	}

	private void OnItemGenPanelAppear()
	{
	}

	private void OnItemGenPanelDisappear(object[] data)
	{
	}

	private void RefreshPos()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
