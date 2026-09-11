using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using UnityEngine;

namespace COW.GamePlay;

public interface HLCJKONLOKE
{
	Transform PCLGHFLMICA { get; }

	List<BE_ProcessBlock> KEDCGLGOJDM { get; set; }

	BE_ProcessBlock MONFFKHMKOM { get; }

	BE_BlockSpot EFBHBLPHPHO { get; }

	BE_BlockSpot AILODNJIBEC { get; }

	BE_BlockSectionHeader KAIOGMBHMBC { get; }

	int NKOKDGIKMLB { get; set; }

	UISprite CAHPCNLNPEG { get; }

	BodyData ONKLFKIHKMP { get; set; }

	UIWidget GetWidget();

	void UpdateSize();

	void SetBGColor(Color NJMGFOAPCGA);

	void UpdateDepth(int HOEICAABLAP = 1);

	void SetErrState(bool HLPPDIODONL);

	void SetHighLightState(bool CBCAJJJCKLH);

	void SetEnabled(bool CBCAJJJCKLH);
}
