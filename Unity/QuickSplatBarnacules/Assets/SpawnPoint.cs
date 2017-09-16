using System;
using System.Collections.Generic;
using UnityEngine;

namespace Artisan
{
    public class SpawnPoint : MonoBehaviour
    {

		public static Action<Transform> SendPoint;
        // Use this for initialization
        void Start()
        {
			SendPoint(transform);
        }

		void OnTriggerExit()
		{
			SendPoint(transform);
		}
    }
}

