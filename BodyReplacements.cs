using ModelReplacement;
using UnityEngine;

namespace Kiryumodel
{
    public class MRKIRYU : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        { 
            string model_name = "Kiryu";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }public class MRKIRYU_ : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        { 
            string model_name = "Kiryu";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
}