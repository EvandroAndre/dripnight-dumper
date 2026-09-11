using UnityEngine;

namespace GCommon;

public class UIItemVariable : MonoBehaviour
{
	public EUIItemExportType ExportType;

	public string CustomExportTypeName;

	public string ExportName;

	public Object ExportObject;

	public void TryToAttachObject()
	{
	}

	public string GetExportedName()
	{
		return null;
	}

	public string GetEUIItemExportTypeCorrespondOriginTypeName(EUIItemExportType euiItemExportType, UIItemVariable InItemVar)
	{
		return null;
	}
}
