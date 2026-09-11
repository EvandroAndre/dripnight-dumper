using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using UnityEngine.Audio;

namespace GAudio.Tools;

public static class AudioDebugHelper
{
	public static Action<AudioLogMessage> ConsoleCallback;

	private static Dictionary<GameObject, string> m_DisplayNameMap;

	public static bool ShouldLog => false;

	public static void LogAudioClip(AudioAction action, AudioClip clip, string message = "")
	{
	}

	public static void LogMultiSound(AudioAction action, ResourceID soundID, bool result)
	{
	}

	public static void LogSound(AudioAction action, ResourceID soundID, GameObject emitter = null, uint playingID = 0u, PlaySoundResult result = PlaySoundResult.Success)
	{
	}

	public static void LogMusic(AudioAction action, AudioResource musicRes, string message = "")
	{
	}

	public static void LogVoice(AudioAction action, ResourceID voiceID, GameObject emitter = null, string message = "")
	{
	}

	public static void LogState(string stateGroupName, string stateName, EAudioEngineType engine)
	{
	}

	public static void LogSwitch(string switchGroupName, string switchName, GameObject target, EAudioEngineType engine)
	{
	}

	public static void LogParameter(string paramName, float value)
	{
	}

	public static void LogSnapshot(AudioAction action, AudioMixerSnapshot snapshot)
	{
	}

	private static void AddLogEntry(AudioLogVerbosity verbosity, EAudioEngineType engine, AudioObjectType objectType, AudioAction action, string objectName, UnityEngine.Object context = null, string message = "")
	{
	}

	public static void RegisterDisplayedName(GameObject gameObject, string name)
	{
	}

	public static string GetDisplayedName(GameObject gameObject)
	{
		return null;
	}
}
