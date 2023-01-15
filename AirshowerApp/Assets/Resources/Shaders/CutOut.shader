Shader "Custom/Cutout" {
    Properties {
        _Color ("Color", Color) = (1,1,1,1)
    }

    SubShader {
        Tags {"Queue" = "Background-1"
        }

        Cull Off
        Pass{
            Zwrite On
            ColorMask 0
        }
    }
}
