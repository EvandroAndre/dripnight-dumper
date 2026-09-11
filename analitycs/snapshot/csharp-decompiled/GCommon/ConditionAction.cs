using System.Collections.Generic;

namespace GCommon;

public class ConditionAction : IObjectPoolCallback
{
	public delegate bool ActionHandler();

	public delegate bool ConditionHandler();

	public enum State
	{
		Active,
		DeActive
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public float startTime;

		public float durationSecond;

		internal bool _003CWhenAfterTime_003Eb__0()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public float startTime;

		public float intervalSecond;

		internal bool _003CWhenIntervalTime_003Eb__0()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public float startTime;

		public float durationSecond;

		internal bool _003CCancelWhenAfterTime_003Eb__0()
		{
			return false;
		}
	}

	private static int GUID_INDEX;

	private ActionHandler m_actionHandler;

	private List<ConditionHandler> m_actionConditionHandlers;

	private List<ConditionHandler> m_cancelConditionHandlers;

	private State _003Cstate_003Ek__BackingField;

	private int _003CGUID_003Ek__BackingField;

	private bool m_IsInPool;

	private float m_lastCheckConditionTime;

	private float m_checkConditionInterval;

	public State state
	{
		get
		{
			return _003Cstate_003Ek__BackingField;
		}
		private set
		{
			_003Cstate_003Ek__BackingField = value;
		}
	}

	public int GUID
	{
		get
		{
			return _003CGUID_003Ek__BackingField;
		}
		private set
		{
			_003CGUID_003Ek__BackingField = value;
		}
	}

	public void OnAllocated()
	{
	}

	public void OnCollected()
	{
	}

	public bool IsInPool()
	{
		return false;
	}

	public void RunOneFrame()
	{
	}

	public ConditionAction SetAction(ActionHandler callbackActionHandler)
	{
		return null;
	}

	public ConditionAction When(ConditionHandler conditionHandler)
	{
		return null;
	}

	public ConditionAction WhenAfterTime(float durationSecond)
	{
		return null;
	}

	public ConditionAction WhenIntervalTime(float intervalSecond)
	{
		return null;
	}

	public ConditionAction CancelWhen(ConditionHandler conditionHandler)
	{
		return null;
	}

	public ConditionAction CancelWhenAfterTime(float durationSecond)
	{
		return null;
	}

	public ConditionAction CheckConditionInterval(float intervalSecond)
	{
		return null;
	}

	public void Cancel()
	{
	}
}
