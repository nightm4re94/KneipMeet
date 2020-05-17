using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeardedManStudios.Forge.Networking.Generated;

public class MoveCube : MoveCubeBehavior
{
    private void Update()
    {
        if (!networkObject.IsServer)
        {
            transform.position = networkObject.position;
            return;
        }
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * Time.deltaTime * 5f;
        networkObject.position = transform.position;
    }
}
