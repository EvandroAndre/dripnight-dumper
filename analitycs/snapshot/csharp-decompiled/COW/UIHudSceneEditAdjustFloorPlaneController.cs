using GCommon;

namespace COW;

public class UIHudSceneEditAdjustFloorPlaneController : UIHudUGCTutorialRestrictionBaseController
{
	private const uint VISIBILITY_STATE_TUTORIAL_RESTRICTION = 1073741824u;

	private UIHudSceneEditAdjustFloorPlaneView m_View;

	private float mPressIntevalMin;

	private float mPressIntevalMax;

	private float mCurrentPressInterval;

	private float mLastClickTime;

	private float mSpeed;

	private float mLastPressTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void Update()
	{
	}

	private void OnSubmitInputNum()
	{
	}

	private void OnBtnMoveUp()
	{
	}

	private void OnBtnMoveDown()
	{
	}

	private void OnEnableFloorAdjust(object[] data)
	{
	}

	public void EnableFloorAdjust(bool enable)
	{
	}

	private void OnItemPanelChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
