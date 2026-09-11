using GCommon;
using proto;

namespace COW;

public class UISeasonYearRewardItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UISeasonYearRewardItemView m_View;

	private UIStandardItemMiniController m_ItemCtrl;

	private const uint BigRewardHeroicCnt = 6u;

	protected ClientActivityDesc m_TaskDesc;

	private bool m_IsBigReward;

	private uint m_SeasonYearId;

	private int m_Index;

	protected string FirstInAnim;

	protected string NormalInAnim;

	private uint m_AnimDelayCall;

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

	public void SetRewardView(ClientActivityDesc taskDesc, uint seasonYearId, int index)
	{
	}

	public void PlayDelayShowAnim(ESeasonYearMainAnimType animType)
	{
	}

	private void DelayShowUIFX()
	{
	}

	protected virtual void OnClaimBtnClick()
	{
	}

	private void LogPreviewClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CPlayDelayShowAnim_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
