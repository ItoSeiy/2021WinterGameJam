using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultTree : MonoBehaviour
{
    [SerializeField] GameObject[] items = default;
    //[SerializeField] int[] itemID;
    [SerializeField] float SpawnXmin;
    [SerializeField] float SpawnXmax;
    [SerializeField] float SpawnYmin;
    [SerializeField] float SpawnYmax;
    [SerializeField] Vector2 tripos1, tripos2, tripos3;
    List<int> itemID = GameObject.Find("GameManager").GetComponent<GameManager>().ItemId;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var go in itemID)
        {
            Vector2 iPos = new Vector2(Random.Range(SpawnXmin, SpawnXmax), Random.Range(SpawnYmin, SpawnYmax));//TriPos();
            var itemGo = Instantiate(items[go],iPos, Quaternion.identity,this.transform);
            itemGo.GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }

    private Vector2 TriPos()
    {
        Vector2 pos = new Vector2(Random.Range(SpawnXmin, SpawnXmax), Random.Range(SpawnYmin, SpawnYmax));

        Vector2 AB = sub_vector(ref tripos2, ref tripos1);
        Vector2 BP = sub_vector(ref pos, ref tripos2);

        Vector2 BC = sub_vector(ref tripos3, ref tripos2);
        Vector2 CP = sub_vector(ref pos, ref tripos3);

        Vector2 CA = sub_vector(ref tripos1, ref tripos3);
        Vector2 AP = sub_vector(ref pos, ref tripos1);

        double c1 = AB.x * BP.y - AB.y * BP.x;
        double c2 = BC.x * CP.y - BC.y * CP.x;
        double c3 = CA.x * AP.y - CA.y * AP.x;

        if (!((c1 > 0 && c2 > 0 && c3 > 0) || (c1 < 0 && c2 < 0 && c3 < 0)))
        {
            TriPos();
        }
        return pos;
    }
    Vector2 sub_vector(ref Vector2 a, ref Vector2 b )
    {
        Vector2 ret = new Vector2();
        ret.x = a.x - b.x;
        ret.y = a.y - b.y;
        return ret;
    }
}
