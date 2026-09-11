using System.Collections.Generic;

namespace TsiU;

public class TBlackBoard
{
	public class TBlackboardItem
	{
		private object _value;

		private float _life;

		public void SetValue(object v)
		{
		}

		public T GetValue<T>()
		{
			return default(T);
		}

		public float GetLife()
		{
			return 0f;
		}

		public void SetInfinity()
		{
		}

		public void SetExpiredTime(float gameTime)
		{
		}

		public bool IsExpired(float gameTime)
		{
			return false;
		}
	}

	private Dictionary<string, TBlackboardItem> _items;

	private float _curGameTime;

	public void Update(float gameTime)
	{
	}

	public TBlackboardItem SetValue(string key, object v)
	{
		return null;
	}

	public T GetValue<T>(string key, T defaultValue)
	{
		return default(T);
	}

	public float GetLifeTime(string key)
	{
		return 0f;
	}
}
