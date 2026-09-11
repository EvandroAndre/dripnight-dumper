using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCLevelParamsHelper
{
	public class UGCLevelParams
	{
		public Dictionary<string, bool> paramsBool;

		public Dictionary<string, int> paramsInt;

		public Dictionary<string, float> paramsFloat;

		public Dictionary<string, string> paramsString;

		public Dictionary<string, Vector3> paramVector3;
	}

	private UGCLevelParams m_LevelParams;

	private Dictionary<uint, UGCRoomParamsItem> m_RoomParamsConfig;

	private UGCRuntime m_Runtime;

	public UGCLevelParamsHelper Init(UGCRuntime runtime, bool applyToGeneralModeSetting)
	{
		return null;
	}

	private void LoadRoomParams()
	{
	}

	public void OverrideFromMetaModeSettings(APELAOJEDNI modeData)
	{
	}

	private void SetRoomParamToGeneralModeSetting()
	{
	}

	public bool HasLevelParams(string key)
	{
		return false;
	}

	public bool GetLevelParamsBool(string key)
	{
		return false;
	}

	public int GetLevelParamsInt(string key)
	{
		return 0;
	}

	public float GetLevelParamsFloat(string key)
	{
		return 0f;
	}

	public Vector3 GetLevelParamsVector3(string key)
	{
		return default(Vector3);
	}
}
