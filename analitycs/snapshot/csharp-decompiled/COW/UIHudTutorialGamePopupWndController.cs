using COW.GamePlay;
using GCommon;
using proto;

namespace COW;

internal class UIHudTutorialGamePopupWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum PopWndState
	{
		Open,
		CountDownStart,
		CountDownEnd
	}

	private UIHudTutorialGamePopupWndView m_View;

	private FNIFJFFGDDO.AHGIFAGEFNK m_TutorialPopUpType;

	private new UIPopupGlassBG m_Glass;

	private const int COUNTDOWN = 15;

	private UIModelForceTutorial m_ModelForceTutorial;

	private EAccount.NewbieChoice m_NewBieChoice;

	private float m_Time;

	private PopWndState m_PopWndState;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Hide()
	{
	}

	public override void Show()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnContinueClick()
	{
	}

	private void ReturnToLobby()
	{
	}

	private void StartBRTutorialMatch()
	{
	}

	public void UpdateBGBlur()
	{
	}

	public void ShowEndContent(EAccount.NewbieChoice newBieChoice)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
