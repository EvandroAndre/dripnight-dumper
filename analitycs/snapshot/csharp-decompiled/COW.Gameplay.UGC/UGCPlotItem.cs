using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class UGCPlotItem : UGCResource
{
	public string PlotId;

	public string PlotName;

	public List<HMJODCEJBFF> Dialogues;

	public bool AllowSkip;

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}
}
