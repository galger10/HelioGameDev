using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Artisan
{
    public class SpawnController : MonoBehaviour
    {
        public List<Transform> spawnPointList = new List<Transform>();
        public List<Transform> boardObjectList = new List<Transform>();

        void Awake()
        {
            SpawnPoint.SendPoint += SendPointHandler;
            BoardObject.SendPoint += BoardOjbectHandler;
			StartCoroutine(Spawn());
        }

        private void SendPointHandler(Transform _transform)
        {
            spawnPointList.Add(_transform);
        }

        private void BoardOjbectHandler(Transform _transform)
        {
            boardObjectList.Add(_transform);
        }

		IEnumerator Spawn () {
			while (StaticVars.generateRate > 0.1f)
			{
				yield return new WaitForSeconds (StaticVars.generateRate);
				int randPoint = UnityEngine.Random.Range(0, spawnPointList.Count);
				int randPiece = UnityEngine.Random.Range(0, boardObjectList.Count);
				boardObjectList[randPiece].position = spawnPointList[randPoint].position;
				spawnPointList.RemoveAt(randPoint);
				boardObjectList.RemoveAt(randPiece);
				StaticVars.generateRate -= 0.1f;
			}
			print("Game Over");
		}
    }
}

