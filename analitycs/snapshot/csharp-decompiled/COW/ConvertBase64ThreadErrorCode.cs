namespace COW;

public enum ConvertBase64ThreadErrorCode
{
	Processing = 1,
	OK = 0,
	ExceptionError = -1,
	AudioClipNullError = -2,
	ConvertToNullError = -3,
	TimeOut = -4,
	BufferInUseError = -5
}
