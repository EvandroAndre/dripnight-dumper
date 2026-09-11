using System;
using UMA;
using UnityEngine;

[Serializable]
public class SharedColorTable : ScriptableObject, ISerializationCallbackReceiver
{
	public int channelCount;

	public string sharedColorName;

	public float colorNormalized;

	public OverlayColorData[] colors;

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
