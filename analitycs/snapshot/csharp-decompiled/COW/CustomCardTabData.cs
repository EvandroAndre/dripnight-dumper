using System;

namespace COW;

public class CustomCardTabData : ICustomCardTabData
{
	public class TabIndex
	{
		public const int RECEIVE = 0;

		public const int GIVE = 1;

		public const int SHOP = 2;
	}

	protected int m_index;

	protected bool m_red;

	private Action<int> _003ConSelected_003Ek__BackingField;

	private Action<bool> _003ConRedState_003Ek__BackingField;

	public int Index => 0;

	public bool RedState => false;

	public Action<int> onSelected
	{
		get
		{
			return _003ConSelected_003Ek__BackingField;
		}
		set
		{
			_003ConSelected_003Ek__BackingField = value;
		}
	}

	public Action<bool> onRedState
	{
		get
		{
			return _003ConRedState_003Ek__BackingField;
		}
		set
		{
			_003ConRedState_003Ek__BackingField = value;
		}
	}

	public virtual string GetTabName()
	{
		return null;
	}

	public virtual void Init(int index)
	{
	}

	public virtual void Clear()
	{
	}
}
