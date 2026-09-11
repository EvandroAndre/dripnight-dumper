using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class CommonSettingItemDataToggleBtns : CommonSettingItemDataBase
{
	public bool ShowBtnBG;

	public List<CommonSettingItemToggleData> ToggleData;

	public Func<int> GetBtnSelectFromRightToLeft;

	public string CommonPrefsKey;

	public List<int> CommonPrefsValue;

	public List<string> CommonPrefsToggleKey;

	public int DefalutValue;

	public uint EHDResType;

	public ResDownloadType ResDownloadType;

	public uint OptionalRedefID;

	public uint DownLoadCtrlPos;

	public bool NeedRestart;

	public bool doNotRevertLastToggleSprite;
}
