using System;
using UnityEngine;

namespace COW;

public class GlobalClickRecorder : MonoBehaviour
{
	[Serializable]
	public class ClickRecord
	{
		public float x;

		public float y;

		public float timestamp;

		public int fingerId;

		public int frameCount;

		public ClickRecord(float posX, float posY, float time, int finger)
		{
		}

		public Vector2 GetPosition()
		{
			return default(Vector2);
		}
	}

	private static GlobalClickRecorder s_Instance;

	private bool m_IsRecording;

	private UIModelSetting m_ModelSetting;

	private bool m_AutoStartRecording;

	private KeyCode m_ToggleKey;

	private bool m_StartRecording;

	private bool m_StopRecording;

	private bool m_ClearRecords;

	public static GlobalClickRecorder Instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void CaptureInputs()
	{
	}

	private void RecordClick(float x, float y, float time, int fingerId)
	{
	}

	public void StartRecording()
	{
	}

	public void StopRecording()
	{
	}

	public void ClearRecords()
	{
	}

	public bool IsRecording()
	{
		return false;
	}

	public int GetRecordCount()
	{
		return 0;
	}
}
