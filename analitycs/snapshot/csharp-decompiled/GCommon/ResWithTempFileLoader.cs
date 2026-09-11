namespace GCommon;

public class ResWithTempFileLoader : ResWithTimeoutFileLoader
{
	public string TempPath;

	public string TempFileHash;

	public string FlagPath;

	public virtual long CELL_SIZE => 0L;

	public string ResFileHash => null;

	public ResFileType FileType => ResFileType.Compulsory;
}
