using System.IO;

namespace GCommon.Loc;

internal interface TransOffsetLoader
{
	LoadTransResult Load(FileStream fs, LoadTransParams param);
}
