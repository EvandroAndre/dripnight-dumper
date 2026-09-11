using GCommon;

namespace COW;

public class UIHudSocialLobbyPrimeGroupMemberInfoShareClothesController : UIBaseController
{
	private UIHudSocialLobbyPrimeGroupMemberInfoShareClothesView m_View;

	private UIModelPrime m_ModelPrime;

	private ulong m_AccountID;

	private const string COUNTDOWN_TIME_FORMAT = "({0}s)";

	private EPrimeSetShareState m_State;

	private UIModelMatch m_ModelMatch;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitView()
	{
	}

	private void OnApplySetShareInit()
	{
	}

	private void OnOfferSetShareInit()
	{
	}

	private void OnApplyAndOfferSetShareInit()
	{
	}

	public void SetViewData(EPrimeSetShareState state, ulong accountID)
	{
	}

	private void ApplyCurrentStateView()
	{
	}

	private void RegisterApplyAndOfferSetShareDelegate()
	{
	}

	private bool CheckInMatchMaking()
	{
		return false;
	}

	private void OnExpandClick()
	{
	}

	private void OnExpandCloseMaskClick()
	{
	}

	private void OnExpandClickView()
	{
	}

	private void DisableExpand()
	{
	}

	private void TryDisableExpand(ulong accountID)
	{
	}

	private void OnExpandApplyClick()
	{
	}

	private void OnExpandOfferClick()
	{
	}

	private void OnClickDisable()
	{
	}

	private void RegisterApplySetShareDelegate()
	{
	}

	private void OnApplyClick()
	{
	}

	private void RegisterOfferSetShareDelegate()
	{
	}

	private void OnOfferClick()
	{
	}

	private void RequestApplySetShare()
	{
	}

	private void RequestOfferSetShare()
	{
	}

	public UIWidget GetGuideWidget()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
