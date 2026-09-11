using GCommon;
using UnityEngine;

namespace GAudio.Tools;

public struct AudioLogMessage
{
	public AudioLogVerbosity AudioLogVerbosity;

	public string Time;

	public EAudioEngineType Engine;

	public AudioObjectType ObjectType;

	public AudioAction Action;

	public string ObjectName;

	public Object Context;

	public string ContextName;

	public string Message;
}
