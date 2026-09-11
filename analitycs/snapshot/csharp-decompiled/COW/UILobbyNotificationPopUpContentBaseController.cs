using GCommon;

namespace COW;

public abstract class UILobbyNotificationPopUpContentBaseController : UIBaseController
{
	private bool m_HasClickedInteractionBtn;

	private bool _003CActive_003Ek__BackingField;

	private bool _003CDataReady_003Ek__BackingField;

	private UIButton _003CInteractionButton_003Ek__BackingField;

	protected bool Active
	{
		get
		{
			return _003CActive_003Ek__BackingField;
		}
		private set
		{
			_003CActive_003Ek__BackingField = value;
		}
	}

	public bool DataReady
	{
		get
		{
			return _003CDataReady_003Ek__BackingField;
		}
		protected set
		{
			_003CDataReady_003Ek__BackingField = value;
		}
	}

	protected UIButton InteractionButton
	{
		get
		{
			return _003CInteractionButton_003Ek__BackingField;
		}
		private set
		{
			_003CInteractionButton_003Ek__BackingField = value;
		}
	}

	protected abstract ENotificationPopUpType NotificationType { get; }

	public void Reset()
	{
	}

	public void SetViewData(object data)
	{
	}

	protected abstract void OnReset();

	protected abstract void OnSetViewData(object data);

	public virtual void OnInAnimFinished()
	{
	}

	public virtual void OnOutAnimFinished()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected abstract void InitView();

	protected abstract UIButton InitInteractionButton();

	protected virtual void OnInteractionBtnClick()
	{
	}

	public virtual void OnCloseClick()
	{
	}

	public virtual void OnIgnoreNotification()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
