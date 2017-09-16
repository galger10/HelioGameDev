using System;
using UnityEngine;

namespace Artisan
{
    public class BoardObject : MonoBehaviour
    {

		public static Action<Transform> SendPoint;
		void Start()
        {
			SendPoint(transform);
        }

		void OnMouseDown()
		{
			SendPoint(transform);
			transform.position = new Vector3(0,8,0);

		}
       
    }
}
