using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public abstract class PlantOrgan : MonoBehaviour
{

    private static int _IdCount = 0;
    public static List<(PlantType, List<int>)> spreadProbability = new List<(PlantType, List<int>)> {
        (PlantType.harvestBush, new List<int>{}),
        (PlantType.harvestVine, new List<int>{}),
        (PlantType.obstacleThorn, new List<int>{}),
        (PlantType.platformTree, new List<int>{})
    };
    public static List<(PlantType, int)> resourcesList = new List<(PlantType, int)> {
        (PlantType.harvestBush, 0),
        (PlantType.harvestVine, 0),
        (PlantType.obstacleThorn, 0),
        (PlantType.platformTree, 0)
    };
    public int Id { get; private set; }
    public int plantId { get; private set; }
    public PlantType type {get; private set;}
    public static PlantOrganType OrganType {get; private set;}
    public Vector2 relativeDirection {get; private set;} //The direction of this node relative to its parent node
    public PlantOrgan fatherNode {get; private set;}
    public List<PlantOrgan> spreadOrgans;
    public bool isPlanted = false ;
    public bool isWithering = true;
    public int resources { get; private set;}
    public int layer { get; private set;}
    public Vector2 position { get { return transform.position; } }

    public PlantOrgan(int Layer, int PlantId, PlantOrgan FatherNode){
        this.Id = _IdCount++;
        this.layer = Layer;
        this.plantId = PlantId;
        this.resources = resourcesList.Where( p => p.Item1 == this.type).Select( p => p.Item2).ToArray()[0];
        this.fatherNode = FatherNode;
        this.spreadOrgans = _SpreadPlant();
    }

    protected List<PlantOrgan> _SpreadPlant(){
        List<PlantOrgan> generateList = new List<PlantOrgan>();
        
        return generateList;
    }

}
