using System;
using System.IO;

namespace GCommon;

public class CSVThreadWork
{
	public ResourceID resID;

	public Type type;

	public TextReader csvText;

	public bool isDone;

	public Action callBack;

	public CSVThreadProcessType processType;

	public CSVThreadWorkCallback CustomCallBack;

	public CSVThreadWork(CSVThreadProcessType _processType, CSVThreadWorkCallback _CustomCallBack)
	{
	}
}
