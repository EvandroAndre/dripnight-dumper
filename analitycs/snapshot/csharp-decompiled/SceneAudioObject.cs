using UnityEngine;

public class SceneAudioObject : MonoBehaviour
{
	public enum EMultiPositionType
	{
		Simple_Mode,
		Large_Mode,
		MultiPosition_Mode
	}

	public enum EAttenuationSphere
	{
		Dont_Show,
		Current_Event_Only,
		All_Events
	}

	private string m_ResourceID;
}
