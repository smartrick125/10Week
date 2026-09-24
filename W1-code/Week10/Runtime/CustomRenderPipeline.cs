using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CustomRenderPipeline : RenderPipeline
{
    CameraRenderer renderer = new CameraRenderer();//注意写到类字段上而不是写到for循环中，只造一个相机对象循环使用
    protected override void Render(
        ScriptableRenderContext context, List<Camera> cameras
        )
    {
        for (int i = 0; i < cameras.Count; i++)
        {
            renderer.Render(context, cameras[i]);
        }
    }

    public CustomRenderPipeline()
    {
        Debug.Log("Pipeline被实例创建构造函数触发");
    }
}