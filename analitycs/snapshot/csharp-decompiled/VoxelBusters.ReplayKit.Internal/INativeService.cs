namespace VoxelBusters.ReplayKit.Internal;

public interface INativeService
{
	void Initialise(INativeCallbackListener listener);

	bool IsRecordingAPIAvailable();

	bool IsRecording();

	bool IsPreviewAvailable();

	bool IsCameraEnabled();

	bool IsExistVideo(string filePath);

	void SetMicrophoneStatus(bool enable);

	void SetRecordingUIVisibility(bool show);

	void PrepareRecording();

	void StartRecording(string video_path);

	void SetAudio(string filePath, int sampleRate, int channels);

	void WriteAudio(float[] data, int channels);

	void WriteRecordoPauseTime(long millisecond);

	void StopRecording(string sandbox_video_path);

	bool Preview();

	bool Discard(string filePath);

	bool Discard();

	string GetPreviewFilePath();

	void SavePreview(string filename, string outputPath);

	void SharePreview(string text = null, string subject = null);

	void DiscardVideo(string filePath);

	void PreviewVideo(string filePath);

	void GetThumbnail(string input, int kind, string output);

	void GetVideoInfo(string filePath);

	string GetDeviceHardWare();

	void PreviewVideoFinish();
}
