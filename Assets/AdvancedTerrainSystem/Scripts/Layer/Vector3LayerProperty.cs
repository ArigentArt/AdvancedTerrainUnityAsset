using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace AdvancedTerrainSystem
{

    [System.Serializable]
    public class Vector3LayerProperty : LayerProperty
    {

        public Vector3LayerProperty(string name) : base(name, "Vector3")
        {



        }



        public virtual void Apply2Material(Material material, uint layerIndex)
        {

            material.SetVector(MatPropReferenceWithLayerIndex(layerIndex), Vector3_Value);

        }

    }

}
