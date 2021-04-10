Shader "Unlit/RandomOffset"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
		[PerRenderData] _OffsetX("OffsetX", float) = 0
		[PerRenderData] _OffsetY("OffsetY", float) = 0

    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
			#pragma multi_compile_instancing
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
				UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
				UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

			UNITY_INSTANCING_BUFFER_START(PropBuffer)
				UNITY_DEFINE_INSTANCED_PROP(float, _OffsetX)
				UNITY_DEFINE_INSTANCED_PROP(float, _OffsetY)
			UNITY_INSTANCING_BUFFER_END(PropBuffer)

            v2f vert (appdata v)
            {
                v2f o;

				UNITY_SETUP_INSTANCE_ID(v);
				UNITY_TRANSFER_INSTANCE_ID(v, o);

				//Update Offset here				
				_MainTex_ST.z = _MainTex_ST.z + UNITY_ACCESS_INSTANCED_PROP(PropBuffer, _OffsetX);
				_MainTex_ST.w = _MainTex_ST.w + UNITY_ACCESS_INSTANCED_PROP(PropBuffer, _OffsetY);

                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
}
