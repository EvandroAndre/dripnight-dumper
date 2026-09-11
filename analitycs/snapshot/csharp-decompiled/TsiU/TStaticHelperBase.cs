namespace TsiU;

public class TStaticHelperBase<T> : TSingleton<T> where T : class, new()
{
	private bool _003ChasInited_003Ek__BackingField;

	protected bool hasInited
	{
		get
		{
			return _003ChasInited_003Ek__BackingField;
		}
		private set
		{
			_003ChasInited_003Ek__BackingField = value;
		}
	}

	public void Init()
	{
	}

	public void Uninit()
	{
	}

	protected virtual void onInit()
	{
	}

	protected virtual void onUninit()
	{
	}
}
