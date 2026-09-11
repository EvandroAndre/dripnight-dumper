namespace VoxelBusters.ReplayKit.Internal;

public interface INativeCallbackListener
{
	void OnInitialiseSuccess();

	void OnInitialiseFailed(string message);

	void OnRecordingStarted();

	void OnRecordingStopped();

	void OnRecordingFailed(string message);

	void OnRecordingAvailable(string message);

	void OnPreviewOpened();

	void OnPreviewClosed();

	void OnPreviewShared();

	void OnPreviewSaveScuessed(string filePath);

	void OnPreviewSaveFailed(string error);

	void OnPreviewVideo(string filePath);

	void OnDiscardVideo(string filePath);

	void OnThumbnail(string input, string output);

	void OnVideoInfo(string filePath, string size, string duration);

	void OnVideoMuxerStart();

	void OnVideoMuxerProgress(int iValue);

	void OnVideoMuxerEnd();

	void OnAudioEncodeProgress(int iValue);
}
