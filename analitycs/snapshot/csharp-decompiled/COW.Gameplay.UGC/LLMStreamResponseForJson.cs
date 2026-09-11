using System.Text;

namespace COW.Gameplay.UGC;

public class LLMStreamResponseForJson : LLMStreamResponseBase
{
	public string AudioBytes;

	public string DeltaAudio;

	public int AudioBytesLength;

	public StringBuilder DeltaAudioStr;
}
