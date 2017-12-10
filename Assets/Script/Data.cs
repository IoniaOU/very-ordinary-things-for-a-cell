using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Data
{
	public static GameObject moleculePrefab;
	public static Text status;
    public static Slider damage;
	public static int currentLevel;
	public static Molecule[] molecules = new Molecule[] {
		new Molecule ("Karbomoil\nFosfat Sentetaz", "FKS", 1,Color.cyan,true),
		new Molecule ("Omitin trans\nkarbomoliaz", "OTK", 1,Color.cyan,true),
		new Molecule ("Arginino\nsüksinat sentaz", "ASS", 1,Color.cyan,true),
		new Molecule ("Arginino\nsüksinat liyaz", "ASL", 1,Color.cyan,true),
		new Molecule ("Arginaz", "ARG", 1,Color.cyan,true),

		new Molecule ("Karbondioksit","CO2",1,Color.white,false),
		new Molecule ("Amonyak","NH4",1,Color.white,false),
		new Molecule ("Karbamoil Fosfat","KP",1,Color.white,false),
		new Molecule ("Ornitin","O",1,Color.white,false),
		new Molecule ("Sitrulin","S",1,Color.white,false),
		new Molecule ("Aspartat","A",1,Color.white,false),
		new Molecule ("Arginino Süksinat","AS",1,Color.white,false),
		new Molecule ("Arginin","AR",1,Color.white,false),
		new Molecule ("Üre","U",1,Color.yellow,false),

		new Molecule ("Hidrojen","CO2",0.3f,Color.magenta,false),
		new Molecule ("ADP","CO2",0.5f,Color.magenta,false),
		new Molecule ("Pi","CO2",0.4f,Color.magenta,false),
		new Molecule ("AMP","CO2",0.5f,Color.magenta,false),
		new Molecule ("Fumarat","CO2",0.7f,Color.magenta,false),
		new Molecule ("Ornitin","Or",0.9f,Color.magenta,false)
	};

	public static Reaction[] reactions = new Reaction[]
	{
		new Reaction("2 ATP kullanıldı. Karbamoil fosfat oluştu. 3 hidrojen 2 ADP 1 fosfat atıldı.",Data.molecules[0],Data.molecules[5],Data.molecules[6],Data.molecules[7],new Molecule[]{Data.molecules[14],Data.molecules[14],Data.molecules[14],Data.molecules[15],Data.molecules[15],Data.molecules[16]}),
		new Reaction("Sitrülin oluştu. 1 fosfat atıldı.",Data.molecules[1],Data.molecules[7],Data.molecules[8],Data.molecules[9],new Molecule[]{Data.molecules[16]}),
		new Reaction("Argininosüksinat oluştu.",Data.molecules[2],Data.molecules[9],Data.molecules[10],Data.molecules[11],new Molecule[]{Data.molecules[17],Data.molecules[16],Data.molecules[16]}),
		new Reaction("Arginin oluştu. Fumarat atıldı",Data.molecules[3],Data.molecules[11],null,Data.molecules[12],new Molecule[]{Data.molecules[18]}),
		new Reaction("Üre oluştu, başardın! Ornitin atıldı.",Data.molecules[4],Data.molecules[12],null,Data.molecules[13],new Molecule[]{Data.molecules[19]})
	};

	public static Level[] levels = new Level[]
	{
		new Level(new Molecule[]
			{
			Data.molecules[0],
			Data.molecules[1],
			Data.molecules[2],
			Data.molecules[3],
			Data.molecules[4],
			Data.molecules[5],
			Data.molecules[6],
			Data.molecules[8],
				Data.molecules[10]},Data.molecules[13])
	};
}
