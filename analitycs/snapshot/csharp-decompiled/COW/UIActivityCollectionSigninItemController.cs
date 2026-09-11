using GCommon;
using proto;

namespace COW;

public class UIActivityCollectionSigninItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIActivityCollectionSigninItemView m_View;

	private uint m_ID;

	private FestivalAttendanceItem m_Info;

	private UIModelActivity m_Model;

	private const uint GREY_COLOR = 2122219263u;

	private const uint YELLOW_COLOR = 4120519679u;

	private int m_NowDay;

	private UIStandardItemMAXBController m_AwardUI;

	public bool IsSignButNotClaimed()
	{
		return false;
	}

	public bool IsNowDay()
	{
		return false;
	}

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

	public void OnClickClaimed()
	{
	}

	public void SetData(FestivalAttendanceItem info)
	{
	}

	private void UpdateView()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
