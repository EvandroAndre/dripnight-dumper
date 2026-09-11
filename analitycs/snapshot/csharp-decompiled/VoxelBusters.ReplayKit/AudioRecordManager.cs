using UnityEngine;
using VoxelBusters.ReplayKit.Common.DesignPatterns;

namespace VoxelBusters.ReplayKit;

public class AudioRecordManager : SingletonPattern<AudioRecordManager>
{
	private enum RecordState
	{
		None,
		Normal,
		Pause,
		Pause_Resume
	}

	private RecordState mRecordState;

	private const int WAIT_FRAME_HIGH = 30;

	private const int WAIT_FRAME_NORMAL = 60;

	private float[] sample_data;

	private int m_WaitFrame;

	private long mLastRecordPoint;

	private long mResumeTicks;

	private AudioListener mAudioListener;

	private AudioRecordListener listener;

	public bool isRecording => false;

	protected override void Init()
	{
	}

	public void StartRecord(string filePath)
	{
	}

	public void PauseRecord()
	{
	}

	public void ResumeRecord()
	{
	}

	private void Update()
	{
	}

	public void WriteData(float[] data, int channels)
	{
	}

	public void EndRecord()
	{
	}

	protected override void OnDestroy()
	{
	}
}
