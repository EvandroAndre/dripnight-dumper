using GCommon;
using proto;

namespace COW;

public class UIBigEventLobbyEnterItemControler : UIEasyListItemController
{
	private UIBigEventLobbyEnterItemView m_View;

	private ulong m_StartTimeStamp;

	private ulong m_EndTimeStamp;

	private BigEventEntryDesc m_ViewData;

	private CustomEventEntryDesc m_ViewDataTemplate;

	private uint m_EntryId;

	private string m_StartTime;

	private string m_EndTime;

	private string m_AwardIcon;

	private string m_AwardBgCdn;

	private bool m_IsPushShow;

	private string m_GoPos;

	private string m_SubGoPos;

	private string m_WebUrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshView()
	{
	}

	protected virtual void OnGotoBtnClick()
	{
	}

	private void OnNotifyCheckboxChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
