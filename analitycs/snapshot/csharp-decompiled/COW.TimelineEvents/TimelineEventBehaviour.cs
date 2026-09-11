using System;
using System.Reflection;
using GCommon;
using UnityEngine;
using UnityEngine.Playables;

namespace COW.TimelineEvents;

[Serializable]
public class TimelineEventBehaviour : PlayableBehaviour
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public string methodName;

		public bool methodWitharg;

		internal bool _003CGetInvocationInfo_003Eb__0(MethodInfo m)
		{
			return false;
		}
	}

	public string HandlerKey;

	public bool IsMethodWithParam;

	public bool InvokeEventsInEditMode;

	public GameObject TargetObject;

	public string ArgValue;

	public EAnimAudioBusType AudioBus;

	public string AudioSource;

	private EventInvocationInfo invocationInfo;

	[NonSerialized]
	public string DirectorName;

	public bool EvaluateInvokeFunc;

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	private void UpdateDelegates()
	{
	}

	private EventInvocationInfo GetInvocationInfo(bool isEnabled, string methodKey, EventInvocationInfo currentInfo, bool methodWitharg)
	{
		return null;
	}

	private void GetBehaviourAndMethod(bool isEnabled, string key, ref Behaviour targetBehaviour, ref string methodName)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBehaviourPlay(Playable P0, FrameData P1)
	{
	}
}
