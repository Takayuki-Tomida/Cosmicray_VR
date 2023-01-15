Shader "Custom/OcclusionShader"
{
    Properties
    {
        //part of being occlusion
        _Color("Occlusion Color", Color) = (0,1,1,1)
        _Width("Occlusion Width", Range(0, 10)) = 1
        _Intensity("Occlusion Intensity",Range(0, 10)) = 1
        //ordinary part
        _Albedo("Albedo", 2D) = "white"{}
        _Specular("Specular (RGB-A)", 2D) = "black"{}
        _Normal("Nromal", 2D) = "bump"{}
        _AO("AO", 2D) = "white"{}
    }
}
