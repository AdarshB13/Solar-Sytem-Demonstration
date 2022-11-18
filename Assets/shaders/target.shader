Shader "Unlit/target"
{
    Properties
    {
        
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct interpolator
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            interpolator vert (appdata v)
            {
                interpolator o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            float4 frag (interpolator i) : SV_Target
            {
                float2 dis=i.uv*2-1;
                dis=distance(float2(0,0),dis);
                dis=dis-0.5f;
                dis=dis*5;
                float4 col=float4(dis.xxx,1);
                col=frac(col);
                return col;
            }
            ENDCG
        }
    }
}
