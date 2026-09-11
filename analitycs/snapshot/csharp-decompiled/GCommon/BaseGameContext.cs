namespace GCommon;

public abstract class BaseGameContext
{
	private bool m_HasInit;

	private BaseGame _003CCurrentGame_003Ek__BackingField;

	public BaseGame CurrentGame
	{
		get
		{
			return _003CCurrentGame_003Ek__BackingField;
		}
		internal set
		{
			_003CCurrentGame_003Ek__BackingField = value;
		}
	}

	public void Init()
	{
	}

	public void Destory()
	{
	}

	protected virtual void OnInit()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void OnReInit()
	{
	}
}
