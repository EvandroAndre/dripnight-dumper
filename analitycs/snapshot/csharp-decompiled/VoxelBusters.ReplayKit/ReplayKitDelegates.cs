namespace VoxelBusters.ReplayKit;

public class ReplayKitDelegates
{
	public delegate void InitialiseCallback(ReplayKitInitialisationState state, string message);

	public delegate void PreviewStateChangedCallback(ReplayKitPreviewState state, string message);

	public delegate void RecordingUIActionChangedCallback(RecordingUIAction action);

	public delegate void OnRecordingPreviewAvailable(string path, string error);

	public delegate void OnRecordActionCallback(bool result, string message);

	public delegate void OnThumbnailCallback(string input, string output);

	public delegate void OnVideoInfoCallback(string path, string size, string duration);

	public delegate void OnVideoMuxerActionCallback(int result, int progress);

	public delegate void OnAudioEncodeProgressCallback(int progress);
}
