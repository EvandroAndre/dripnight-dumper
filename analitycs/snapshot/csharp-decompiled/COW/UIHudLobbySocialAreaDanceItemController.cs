using GCommon;

namespace COW;

public class UIHudLobbySocialAreaDanceItemController : UIBaseController
{
	private UIHudLobbySocialAreaDanceItemView m_View;

	private UIHudLobbySocialAreaDancePanelController m_PanelController;

	private uint _003CDanceEmoteID_003Ek__BackingField;

	private bool _003CIsPlaying_003Ek__BackingField;

	public uint DanceEmoteID
	{
		get
		{
			return _003CDanceEmoteID_003Ek__BackingField;
		}
		private set
		{
			_003CDanceEmoteID_003Ek__BackingField = value;
		}
	}

	public bool IsPlaying
	{
		get
		{
			return _003CIsPlaying_003Ek__BackingField;
		}
		private set
		{
			_003CIsPlaying_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public void InitInfo(uint danceEmoteId, string cdnUrl)
	{
	}

	public void SetPlayingState(bool isPlaying)
	{
	}

	private void OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
