using GCommon;

namespace COW;

public class UISPHudHighlightPlayItemController : UIBaseController
{
	private UISPHudHighlightPlayItemView m_View;

	private ulong m_UserID;

	private UISPHudHighlightInfoListController m_ParentController;

	private EHighLightPlayType _003CHighlightType_003Ek__BackingField;

	public EHighLightPlayType HighlightType
	{
		get
		{
			return _003CHighlightType_003Ek__BackingField;
		}
		private set
		{
			_003CHighlightType_003Ek__BackingField = value;
		}
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

	public void SetData(ulong userID, EHighLightPlayType highlightType, int highlightCount)
	{
	}

	public void RefreshPlayingState()
	{
	}

	public void SetParentController(UISPHudHighlightInfoListController parent)
	{
	}

	private void OnPlayBtnClick()
	{
	}

	private string GetHighlightTypeLabel(EHighLightPlayType type)
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
