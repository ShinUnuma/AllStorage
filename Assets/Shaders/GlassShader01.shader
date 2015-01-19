Shader "Custom/GlassShader01" {
	Properties {
		_EnvMap ("EnvMap", Cube) = "white" {}
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert

		samplerCUBE _EnvMap;

        struct Input {
            float3 worldRefl;
            float3 viewDir;
            float3 worldNormal;
        };

        void surf (Input IN, inout SurfaceOutput o)
        {
        	float margin = 1.0 - dot( normalize( IN.viewDir ), normalize( IN.worldNormal ) );
            float3 refractVect = refract( normalize( IN.viewDir ), normalize( IN.worldNormal ), 0.667 );
    		o.Emission = texCUBE( _EnvMap, refractVect ).rgb  * ( 1.0 - margin ); 
   			o.Emission += texCUBE( _EnvMap, IN.worldRefl ).rgb * margin;
			o.Alpha = 1.0;
        }
		ENDCG
	} 
	FallBack "Diffuse"
}
