using System;

namespace COW;

public class CodeInputPopupData
{
	public string PopWindowTitle;

	public string Title;

	public Action<object> Callback;

	public int CodeNumber;

	public object Ext;

	public CodeInputPopupData(string popwindowTitle = "", string title = "", Action<object> callback = null, int codeNumber = 6, object ext = null)
	{
	}
}
