using System.Collections.Generic;
using message;

namespace COW;

public interface IRoomParamsBase
{
	KDPGIMNMLFE ParamData { get; set; }

	Dictionary<string, string> LocDict { get; }

	void SetViewData(KDPGIMNMLFE data, Dictionary<string, string> dict);

	void RefreshLocKey();

	void Close();

	string GetRoomParamsLoc(string key, string defaultText = "");
}
