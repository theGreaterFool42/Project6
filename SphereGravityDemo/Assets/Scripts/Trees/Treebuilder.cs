using UnityEngine;
using UnityEditor;
using System.Collections;

public class Treebuilder : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        GameObject tree = new GameObject("tree");
        tree.AddComponent<Rigidbody>();
        tree.AddComponent<MeshRenderer>();
        tree.AddComponent<BoxCollider>();
        tree.AddComponent<MeshFilter>();
        
        Mesh mesh = (Mesh)Resources.Load("Assets/Models/Baumstamm", typeof(Mesh));
        //public MeshFilter mf;
        tree.GetComponent<MeshFilter>().mesh = mesh;

        //ImportExample();
        //AssetDatabase.Refresh();

    }

    [MenuItem("AssetDatabase/ImportExample")]
    static void ImportExample()
    {
        //AssetDatabase.ImportAsset("Assets/Models/Baumstamm.fbx", ImportAssetOptions.Default);
        


    }
    // Update is called once per frame
    void Update () {




        
    }
   
}
