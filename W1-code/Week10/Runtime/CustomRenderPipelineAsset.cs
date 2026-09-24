using System.Collections.Generic;//核心作用：让你能直接使用 List<T>、Dictionary<K, V> 等泛型动态容器
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(menuName = "Rendering/Custom Render Pipeline")]
public class CustomRenderPipelineAsset : RenderPipelineAsset//硬盘上的一张配置表
{
    protected override RenderPipeline CreatePipeline()//真正干活的工人
    {
        return new CustomRenderPipeline();
    }
}