using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILobbyNotificationPopUpManager : SingletonModule<UILobbyNotificationPopUpManager>
{
	private List<UILobbyNotificationPopUpController> m_FreeList;

	private List<UILobbyNotificationPopUpController> m_ActiveList;

	private UILobbyNotificationPopUpController _003CActiveCtrl_003Ek__BackingField;

	public UILobbyNotificationPopUpController ActiveCtrl
	{
		get
		{
			return _003CActiveCtrl_003Ek__BackingField;
		}
		private set
		{
			_003CActiveCtrl_003Ek__BackingField = value;
		}
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public UILobbyNotificationPopUpController ReleasePopUp()
	{
		return null;
	}

	public void CollectPopUp()
	{
	}

	public void CollectPopUp(UILobbyNotificationPopUpController ctrl)
	{
	}

	private int GetNextPanelBaseDepth()
	{
		return 0;
	}

	public UILobbyNotificationPopUpController GetLastActiveCtrl()
	{
		return null;
	}
}
