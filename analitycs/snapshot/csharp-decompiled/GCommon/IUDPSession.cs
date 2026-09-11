using ICSharpCode.SharpZipLib.GZip;

namespace GCommon;

public interface IUDPSession
{
	TeaEncTempBuffer EncBuffer { get; }

	byte[] ZipOutputBuffer { get; }

	byte[] ZipWorkingBuffer { get; }

	GZipInputStream GZipInputStream { get; }

	byte[] DecTempBuffer { get; }

	TeaDecTempBuffer DecBuffer { get; }

	byte[] EncTempBuffer { get; }

	byte[] GetSecretKey();

	int[] GetHeadSecretKey();
}
