using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;


namespace Actions
{
    [ManagedReference.ManagedReferenceGroup("Wait")]
    [Serializable]
    public class WaitAction : BaseAction
    {
        [SerializeField]

        private int _delayInSeconds;

        public override void Stop()
        {

        }

        public override async UniTask RunAsync(CancellationToken cancellationToken)
        {
            await UniTask.Delay(_delayInSeconds * 1000).AttachExternalCancellation(cancellationToken);
        }
    }
}
