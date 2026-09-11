using System.IO;

namespace COW.Gameplay.UGC;

public class LLMStreamResponseForProtobuf : LLMStreamResponseBase
{
	public MemoryStream AudioStream;

	public int DeltaAudioLength;

	public int DeltaAudioOffset;
}
