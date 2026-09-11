namespace COW;

public class ConvertAudioReturnParams
{
	public string Base64String;

	public byte[] AudioBytes;

	public int AudioSize;

	public ConvertBase64ThreadErrorCode Status;

	public ConvertAudioReturnParams()
	{
	}

	public ConvertAudioReturnParams(string base64String, ConvertBase64ThreadErrorCode status)
	{
	}
}
