using GCommon;
using message;

namespace COW;

internal class UIHudCSShopEntryController : UIBaseController
{
	private UIHudCSShopEntryView m_View;

	private MHEGIGKNCJL m_ShopFlow;

	private ICOMCEBCCKC m_MatchPhase;

	private int m_CurRound;

	private int m_MaxRound;

	private LJDMEHFMAFK m_TakeTurnsShopState;

	public const uint VISIBILITY_STATE_GetOnVehicle = 1073741824u;

	private bool m_NeedUpdate;

	private float m_HideTime;

	private UITimeLabelHelper m_TimeHelper;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	private void OnGetOnVehicleShow(bool show)
	{
	}

	private void OnGetOverrideMatchSetting()
	{
	}

	private void OnShowCSGuideStoreBtn(object[] data)
	{
	}

	private void OnShowCSVestGuideShopEntry(uint data)
	{
	}

	private void OnConflictShow(bool value)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	private void OnShopBtnClick()
	{
	}

	public UIButton GetTutorialBtn()
	{
		return null;
	}

	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	private void UpdateShopState(object[] data)
	{
	}

	public void SetCountdownTime(float secs)
	{
	}

	private void UpdateVisibleState()
	{
	}

	private void DispatchVisibleEvent(bool value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
