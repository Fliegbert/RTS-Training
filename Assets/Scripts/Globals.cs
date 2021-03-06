using System.Collections.Generic;

public class Globals
{
    public static int TERRAIN_LAYER_MASK = 1 << 8;
    public static List<UnitManager> SELECTED_UNITS = new List<UnitManager>();
    public static BuildingData[] BUILDING_DATA;
    /*{
        new BuildingData("House", 100, new Dictionary<string, int>()
        {
            { "gold", 100 },
            { "wood", 120 }
        }),
        new BuildingData("Tower", 100, new Dictionary<string, int>()
        {
            { "gold", 80 },
            { "wood", 80 },
            { "stone", 100 }
        })
    };*/

    public static Dictionary<string, GameResource> GAME_RESOURCES = new Dictionary<string, GameResource>()
    {
        { "gold", new GameResource("Gold", 300) },
        { "wood", new GameResource("Wood", 300) },
        { "stone", new GameResource("Stone", 300) }
    };

}
