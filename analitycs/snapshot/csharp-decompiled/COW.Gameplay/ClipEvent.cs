using System;
using UnityEngine;

namespace COW.Gameplay;

[Serializable]
public class ClipEvent
{
	public AnimEventType m_EventType;

	public float m_Time;

	public string m_FunctionName;

	public string m_StringParameter;

	public float m_FloatParameter;

	public int m_IntParameter;

	public UnityEngine.Object m_GameObjectParameter;
}
