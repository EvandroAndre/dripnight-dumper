using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudMetropolisMapAreaItemController : UIBaseController
{
	private UIHudMetropolisMapAreaItemView m_View;

	private bool m_ShowProgress;

	private UITimeLabelHelper m_TimeHelper;

	private UITimeLabelHelper m_DetailTimeHelper;

	private CLKBJIJFFOK m_Info;

	private bool m_IsSelected;

	public uint AreaID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetAreaData(CLKBJIJFFOK info)
	{
	}

	public void UpdateAreaState()
	{
	}

	public void UpdateAreaStateEndTime()
	{
	}

	public void UpdateAreaGame()
	{
	}

	public void SelectArea(bool select)
	{
	}

	public void TrackArea(bool track)
	{
	}

	private void OnClickDetailBtn()
	{
	}

	private void OnClickTrackBtn()
	{
	}

	public void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
