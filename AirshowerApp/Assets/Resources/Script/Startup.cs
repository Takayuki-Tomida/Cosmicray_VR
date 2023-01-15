using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Startup : MonoBehaviour
{

    private void Awake()
    {
        // アイバッファ解像度（フレネルレンズの歪みを考慮した解像度）の変更（1.0f:デフォルト)
        //UnityEngine.XR.XRSettings.eyeTextureResolutionScale = 0.8f;

        // 固定中心窩レンダリングのレベル変更。 Off/LMSLow/LMSMedium/LMSHigh　外側の解像度が減っていく
        OVRManager.fixedFoveatedRenderingLevel = OVRManager.FixedFoveatedRenderingLevel.HighTop;

        // 72Hzモード（綺麗になるがフレームレート安定が犠牲になる）
        //OVRManager.display.displayFrequency = 72.0f;

        // CPU,GPUのパフォーマンスレベル。0～3の大きいほど放熱が高く高スペックな動作をする。既定値は2。
        //OVRManager.suggestedCpuPerfLevel = OVRManager.ProcessorPerformanceLevel.Boost;
        //OVRManager.suggestedGpuPerfLevel = OVRManager.ProcessorPerformanceLevel.Boost;
        // テクスチャ解像度 デフォルトは1.0 上げれば上げるほどVR内のジャギーが消えてなめらかに描画できる。(効果は絶大だが劇的に重くなる)
        //UnityEngine.XR.XRSettings.eyeTextureResolutionScale = 1.0f;

        // 画面端の方が赤っぽくなることへの補正を入れる (adb shell setprop debug.oculus.forceChroma 1 相当)
        //OVRPlugin.chromatic = true;
        XRSettings.eyeTextureResolutionScale = 1.3f;
        // アンチエイリアシング。あまり実感できない
        // QualitySettings.antiAliasing = 4;

        // シングルパスステレオレンダリング (普通は右目用と左目用の2回レンダリングを行うところを、1シーンにそれを無理やり押し込める手法)
        // Edit > ProjectSettings > Player
        //   XRSettings > StereoRenderingMethod: MultiPass→SinglePass

        // ・OVRCameraRigのOVR ManagerにあるEnable Adaptive Resolutionをオフにする
        // GPUの使用率が高くなるとフレーム落ちしないように自動的に解像度を下げる機能
        // かなり効果があったとのこと
    }
}