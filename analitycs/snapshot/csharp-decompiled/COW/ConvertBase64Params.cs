namespace COW;

public class ConvertBase64Params
{
	public EAudioDataFormat Format;

	public float[] Samples;

	public int Frequency;

	public int BitRate;

	public bool IsStereo;

	public ConvertAudioReturnParams Result;

	public ConvertBase64Params(EAudioDataFormat format, float[] samples, int frequency, int bitRate, bool isStereo, ConvertAudioReturnParams result)
	{
	}
}
